--sp Input data 
USE SI_Hotel

--Kamar
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_InsertKamar]
	@id_kamar				varchar	(10),
	@id_kelas_kamar			int,
	@id_jenis_kamar			int,
	@status_kamar			int
	
AS
BEGIN
	INSERT INTO Kamar
	VALUES(@id_kamar, @id_kelas_kamar, @id_jenis_kamar, @status_kamar)
END

--Menu

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[sp_InsertMenu]
	@id_menu			VARCHAR	(10),
	@id_jenis_menu		int,
	@nama_menu			varchar(50),
	@harga_menu			money,
	@deskripsi_menu		text,
	@status_menu		int
AS
BEGIN
	INSERT INTO Menu
	VALUES(@id_menu, @id_jenis_menu, @nama_menu, @harga_menu, @deskripsi_menu, @status_menu)
END


---Role
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_InsertRole]
	@nama_role		VARCHAR	(50)
AS
BEGIN
	INSERT INTO Role
	VALUES(@nama_role)
END


-----Ruangan
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER PROCEDURE [dbo].[sp_InsertRuangan]
	@id_ruangan			VARCHAR	(10),
	@deskripsi_ruangan	varchar(50),
	@harga_ruangan		money,
	@status_ruangan		int
AS
BEGIN
	INSERT INTO Ruangan
	VALUES(@id_ruangan,@deskripsi_ruangan,@harga_ruangan, @status_ruangan)
END

------User
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_InsertUser]
	@id_user		VARCHAR	(10),
	@nama_user		VARCHAR	(50),
	@email_user		VARCHAR	(50),
	@password		VARCHAR	(50),
	@id_role			int
AS
BEGIN
	INSERT INTO [User]
	VALUES(@id_user, @nama_user, @email_user, @password, @id_role)
END

------------Jenis Menu
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[sp_InsertJenisMenu]
	@nama_jenis_menu		VARCHAR	(50),
	@deskripsi_jenis_menu	text
AS
BEGIN
	INSERT INTO JenisMenu (nama_jenis_makanan, deskripsi_jenis_makanan)
	VALUES(@nama_jenis_menu, @deskripsi_jenis_menu)
END

-------Jenis Kamar
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[sp_InsertJenisKamar]
	@nama_jenis_kamar	VARCHAR	(50),
	@deskripsi_jenis_kamar		text,
	@harga_jenis_kamar		money
AS
BEGIN
	INSERT INTO JenisKamar (nama_jenis_kamar, deskripsi_jenis_kamar, harga_jenis_kamar)
	VALUES(@nama_jenis_kamar, @deskripsi_jenis_kamar, @harga_jenis_kamar)
END

-------Detail User
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[sp_InsertDetailUser]
	@nama			varchar(50),
	@nik			varchar(50),
	@tanggal_lahir	date,
	@alamat			text
AS
BEGIN
	INSERT INTO DetailUser (nama, nik, tanggal_lahir, alamat)
	VALUES(@nama, @nik, @tanggal_lahir, @alamat)
END

SELECT * FROM JenisKamar

--Kelas Kamar
USE SI_Hotel

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_InsertKelasKamar]
	@nama_kelas_kamar			Varchar	(50),
	@deskripsi_kelas_kamar		text,
	@harga_kelas_kamar			money
AS
BEGIN
	INSERT INTO KelasKamar (nama_kelas_kamar, deskripsi_kelas_kamar, harga_kelas_kamar)
	VALUES(@nama_kelas_kamar, @deskripsi_kelas_kamar, @harga_kelas_kamar)
END

SELECT * FROM KelasKamar

---------Fasilitas
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_InsertFasilitas]
	@id_fasilitas	VARCHAR	(10)	,
	@nama_fasilitas	VARCHAR	(50),
	@qty			int
AS
BEGIN
	INSERT INTO Fasilitas
	VALUES(@id_fasilitas, @nama_fasilitas, @qty)
END

--Detail Fasilitas Kamar
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_InsertDetailFasilitasKamar]
	@id_kelas_kamar int,
	@id_fasilitas			varchar(10),
	@qty int
AS
BEGIN
	INSERT INTO DetailFasilitasKamar (id_kelas_kamar, id_fasilitas, qty)
	VALUES (@id_kelas_kamar, @id_fasilitas, @qty)

	UPDATE Fasilitas
	SET qty -= @qty
	WHERE id_fasilitas = @id_fasilitas
END

------------Detail Transaksi Pembelian
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_InsertDetailTransaksiPembelian]
	@id_tr_dapur varchar(10),
	@id_menu varchar(10),
	@qty int,
	@total_harga money
AS
BEGIN

	INSERT INTO DetailTransaksiPembelian
	VALUES(@id_tr_dapur, @id_menu, @qty, @total_harga)
END

-- Transaksi Kamar
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[sp_InsertTransaksiKamar]
	@id_transaksi_kamar		varchar	(10),
	@id_customer			varchar	(10),
	@id_receptionist		varchar	(10),
	@id_kamar				varchar	(10),
	@tgl_transaksi			date,
	@check_in				date,
	@check_out				date,
	@total_harga			money,
	@status_transaksi		int
AS
BEGIN
	INSERT INTO TransaksiKamar
	VALUES(@id_transaksi_kamar, @id_customer, @id_receptionist, @id_kamar, @tgl_transaksi, @check_in, @check_out, @total_harga, @status_transaksi)

	UPDATE Kamar
	SET status_kamar = 0
	WHERE id_kamar = @id_kamar
END

-- DetailMenuTransaksi
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[sp_InsertDetailTrsPembelian]
	@id_tr_dapur			varchar	(10),
	@id_tr_kamar			varchar (10),
	@id_menu_makanan		varchar	(10),
	@qty					int,
	@total_harga			money,

	@id_customer			varchar(10),
	@id_receptionist		varchar(10),
	@id_kamar				varchar(10),
	@tgl_transaksi			date
AS
BEGIN
	INSERT INTO TransaksiPembelian
	VALUES (@id_tr_dapur, @id_tr_kamar, @id_customer, @id_receptionist, @id_kamar, @tgl_transaksi, 0, 0)

	INSERT INTO DetailTransaksiPembelian
	VALUES (@id_tr_dapur, @id_menu_makanan, @qty, @total_harga)
	
	UPDATE TransaksiPembelian
	SET total_harga += @total_harga
	WHERE id_tr_dapur = @id_tr_dapur
END

-- Transaksi Ruangan
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[sp_InsertTransaksiRuangan]
	@id_transaksi_ruangan	varchar	(10),
	@id_customer			varchar	(10),
	@id_receptionist		varchar	(10),
	@id_ruangan				varchar	(10),
	@tgl_transaksi			date,
	@check_in				date,
	@check_out				date,
	@total_harga			money,
	@status_transaksi		int
AS
BEGIN
	INSERT INTO TransaksiRuangan
	VALUES(@id_transaksi_ruangan, @id_customer, @id_receptionist, @id_ruangan, @tgl_transaksi, @check_in, @check_out, @total_harga, @status_transaksi)

	UPDATE Ruangan
	SET status_ruangan = 0
	WHERE id_ruangan = @id_ruangan
END