-- Membuat sp Update 
-- Hotel 
USE SI_Hotel

--Kamar
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER PROCEDURE [dbo].[sp_UpdateKamar]
	@id_kamar		        varchar(10),
	@id_kelas_kamar int,
	@id_jenis_kamar int
AS
BEGIN 
	UPDATE Kamar
	SET id_kelas_kamar = @id_kelas_kamar,
		id_jenis_kamar = @id_jenis_kamar
	WHERE id_kamar = @id_kamar
END

--jenis kamar
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_UpdateJenisKamar]
	@id_jenis_kamar		        int,
	@nama_jenis_Kamar		    varchar(50),
	@deskripsi_jenis_kamar		text,
	@harga_jenis_kamar          money
AS
BEGIN 
	UPDATE JenisKamar
	SET nama_jenis_kamar = @nama_jenis_kamar,
		deskripsi_jenis_kamar = @deskripsi_jenis_kamar,
		harga_jenis_kamar = @harga_jenis_kamar
	WHERE id_jenis_kamar = @id_jenis_kamar
END

-- Kelas Kamar 
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_UpdateKelasKamar]
	@id_kelas_kamar		        int,
	@nama_kelas_Kamar		    varchar(50),
	@deskripsi_kelas_kamar		text,
	@harga_kelas_kamar          money
AS
BEGIN 
	UPDATE KelasKamar
	SET nama_kelas_kamar = @nama_kelas_kamar,
		deskripsi_kelas_kamar = @deskripsi_kelas_kamar,
		harga_kelas_kamar = @harga_kelas_kamar
	WHERE id_kelas_kamar = @id_kelas_kamar
END

-- Detail Fasilitas Kamar
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER PROCEDURE [dbo].[sp_UpdateDetailFasilitasKamar]
	@id_dt_fasilitas int,
	@id_kelas_kamar int,
	@id_fasilitas			varchar(10),
	@qty int,
	@temp int,
	@temp2 int = 0
AS
BEGIN 
	UPDATE DetailFasilitasKamar
	SET id_kelas_kamar = @id_kelas_kamar,
		id_fasilitas = @id_fasilitas,
		qty = @qty
	WHERE id_dt_fasilitas_kamar = @id_dt_fasilitas

	SET @temp2 = @qty
	SET @temp -= @temp2

	UPDATE Fasilitas
	SET qty += @temp
	WHERE id_fasilitas = @id_fasilitas
END

---Menu 
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_UpdateMenu]
	@id_menu		        varchar(10),
	@id_jenis_menu			int,
	@nama_menu				varchar(50),
	@harga_menu				money,
	@deskripsi_menu         text,
	@status_menu			int
AS
BEGIN 
	UPDATE Menu
	SET id_jenis_makanan = @id_jenis_menu,
		nama_makanan = @nama_menu,
		harga_makanan = @harga_menu,
		deskripsi_makanan = @deskripsi_menu,
		status_makanan = @status_menu
	WHERE id_menu_makanan = @id_menu
END

--Jenis Menu 
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_UpdateJenisMenu]
	@id_jenis_menu		        int,
	@nama_jenis_menu			varchar(50),
	@deskripsi_jenis_menu       text
	
AS
BEGIN 
	UPDATE JenisMenu
	SET nama_jenis_makanan = @nama_jenis_menu,
		deskripsi_jenis_makanan = @deskripsi_jenis_menu
	WHERE id_jenis_makanan = @id_jenis_menu
END

--Ruangan
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER PROCEDURE [dbo].[sp_UpdateRuangan]
	@id_ruangan		        varchar(10),
	@deskripsi_ruangan		text,
	@harga_ruangan			money
	
AS
BEGIN 
	UPDATE Ruangan
	SET nama_ruangan = @deskripsi_ruangan,
		harga_ruangan = @harga_ruangan
	WHERE id_ruangan = @id_ruangan
END

--Role 
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_UpdateRole]
	@id_role		        int,
	@nama_role				varchar(50)
	
AS
BEGIN 
	UPDATE Role
	SET nama_role= @nama_role
	WHERE id_role= @id_role
END

--- User 
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER PROCEDURE [dbo].[sp_UpdateUser]
	@id_user		varchar(10),
	@nama_user		varchar(50),
	@email_user		varchar(50),
	@password		varchar(50),
	@id_role		int,	
	@id_dt_user		int
AS
BEGIN 
	UPDATE [User]
	SET nama_user= @nama_user,
		email_user = @email_user,
		password = @password,
		id_role = @id_role,
		id_dt_user = @id_dt_user
	WHERE id_user= @id_user
END

--- Detail User 
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER PROCEDURE [dbo].[sp_UpdateDetailUser]
	@id				int,
	@nama			varchar(50),
	@nik			varchar(50),
	@tanggal_lahir	date,
	@alamat			text
AS
BEGIN 
	UPDATE [DetailUser]
	SET nama = @nama,
		nik = @nik,
		tanggal_lahir = @tanggal_lahir,
		alamat = @alamat
	WHERE id= @id
END

--- Fasilitas
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_UpdateFasilitas]
	@id_fasilitas		        varchar(10),
	@nama_fasilitas				varchar(50),
	@qty						int	
AS
BEGIN 
	UPDATE Fasilitas
	SET nama_fasilitas = @nama_fasilitas,
		qty = @qty
	WHERE id_fasilitas= @id_fasilitas
END

--- Update Status Transaksi Kamar
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_UpdateTrsKamar]
	@id_tr_kamar	varchar(10),
	@id_kamar		varchar(10)
AS
BEGIN 
	UPDATE TransaksiKamar
	SET status_transaksi = 2
	WHERE id_tr_kamar= @id_tr_kamar

	UPDATE Kamar
	SET status_kamar = 1
	WHERE id_kamar = @id_kamar
END

--- Update Detail Transaksi Menu
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_UpdateDetailTrsMenu]
	@id_tr_dapur		varchar(10),
	@id_menu_makanan	varchar(10),
	@qty				int,
	@total_harga		money,
	@tempHarga			money
AS
BEGIN 
	UPDATE DetailTransaksiPembelian
	SET qty = @qty, total_harga = @total_harga
	WHERE id_tr_dapur = @id_tr_dapur AND id_menu_makanan = @id_menu_makanan

	UPDATE TransaksiPembelian
	SET total_harga += @tempHarga
	WHERE id_tr_dapur = @id_tr_dapur
END

--- Update Pembayaran Menu
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_UpdatePembayaranTransaksiMenu]
	@id_tr_dapur		varchar(10),
	@total_harga		money,
	@status_transaksi	int
AS
BEGIN 
	UPDATE TransaksiPembelian
	SET status_transaksi = @status_transaksi, total_harga = @total_harga
	WHERE id_tr_dapur = @id_tr_dapur
END

--- Update Status Transaksi Ruangan
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_UpdateTrsRuangan]
	@id_tr_ruangan	varchar(10),
	@id_ruangan		varchar(10)
AS
BEGIN 
	UPDATE TransaksiRuangan
	SET status_transaksi = 2
	WHERE id_tr_ruangan= @id_tr_ruangan

	UPDATE Ruangan
	SET status_ruangan = 1
	WHERE id_ruangan = @id_ruangan
END

--- Update Status Otomatis Trs Ruangan
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_UpdateAutoStatusTrsRuangan]
AS
BEGIN 
	UPDATE TransaksiRuangan
	SET status_transaksi = 2
	WHERE TransaksiRuangan.checkout < GETDATE()

	UPDATE Ruangan
	SET Ruangan.status_ruangan = 1
	FROM Ruangan,TransaksiRuangan
	WHERE Ruangan.id_ruangan = TransaksiRuangan.id_ruangan
	AND TransaksiRuangan.checkout < GETDATE()
END

--- Update Status Otomatis Trs Kamar
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER PROCEDURE [dbo].[sp_UpdateAutoStatusTrsKamar]
AS
BEGIN 
	UPDATE TransaksiKamar
	SET status_transaksi = 2
	WHERE TransaksiKamar.check_out < GETDATE()

	UPDATE Kamar
	SET Kamar.status_kamar = 1
	FROM Kamar,TransaksiKamar
	WHERE Kamar.id_kamar = TransaksiKamar.id_kamar
	AND TransaksiKamar.check_out < GETDATE()

	UPDATE TransaksiPembelian
	SET status_transaksi = 2
	FROM TransaksiKamar, TransaksiPembelian
	WHERE TransaksiKamar.id_tr_kamar = TransaksiPembelian.id_tr_kamar
	AND TransaksiKamar.check_out < GETDATE()
END

-- Tagihan Pembelian Menu (Check Out Kamar)
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER PROCEDURE [dbo].[sp_CekTagihanKamar]
	@id_transaksi		nvarchar(50)
AS
BEGIN 
	SELECT sum(tp.total_harga) 
	FROM TransaksiPembelian tp
	WHERE tp.id_tr_kamar = @id_transaksi
	AND tp.status_transaksi = 1
END

-- Bayar Tagihan
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER PROCEDURE [dbo].[sp_BayarTagihan]
	@id_transaksi		nvarchar(50) 
AS
BEGIN 
	UPDATE TransaksiPembelian
	SET status_transaksi = 2
	WHERE id_tr_kamar = @id_transaksi
END

-- Hapus Keranjang
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER PROCEDURE [dbo].[sp_HapusKeranjang] 
AS
BEGIN 
	DELETE 
	FROM DetailTransaksiPembelian
		FROM DetailTransaksiPembelian AS tp 
		INNER JOIN TransaksiPembelian AS dtp ON tp.id_tr_dapur = dtp.id_tr_dapur
    WHERE dtp.status_transaksi = 0

DELETE
	FROM TransaksiPembelian
	WHERE status_transaksi = 0
END
	
SELECT * FROM TransaksiPembelian
SELECT * FROM DetailTransaksiPembelian
SELECT * FROM TransaksiKamar

EXEC sp_HapusKeranjang