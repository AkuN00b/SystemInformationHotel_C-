-- Menggunakan database
USE SI_Hotel

--Kamar
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE or ALTER PROCEDURE [dbo].[sp_CariKamar]
	@cari		nvarchar(50)
AS
BEGIN 
	SELECT * FROM Kamar
	WHERE id_kamar LIKE '%' + @cari + '%'
	OR status_kamar LIKE '%' + @cari + '%'
END

--jenis kamar
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER PROCEDURE [dbo].[sp_CariJenisKamar]
	@cari		nvarchar(50)
AS
BEGIN 
	SELECT * FROM JenisKamar
	WHERE id_jenis_kamar LIKE '%' + @cari + '%'
	OR nama_jenis_kamar LIKE '%' + @cari + '%'
	or deskripsi_jenis_kamar LIKE '%' + @cari + '%'
	OR harga_jenis_kamar LIKE '%' + @cari + '%'
END

--------------kelas kamar
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER PROCEDURE [dbo].[sp_CariKelasKamar]
	@cari		nvarchar(50)
	
AS
BEGIN 
	SELECT * FROM KelasKamar 
	WHERE id_kelas_kamar LIKE '%' + @cari + '%'
	OR nama_kelas_kamar LIKE '%' + @cari + '%'
	OR deskripsi_kelas_kamar LIKE '%' + @cari + '%'
	OR harga_kelas_kamar LIKE '%' + @cari + '%'
END
----------------
-- Menu 
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER PROCEDURE [dbo].[sp_CariMenu]
	@cari		nvarchar(50)
AS
BEGIN 
	SELECT m.id_menu_makanan, jm.nama_jenis_makanan, m.nama_makanan, m.harga_makanan, m.deskripsi_makanan, CASE WHEN m.status_makanan > 0 THEN 'Tersedia' ELSE 'Tidak Tersedia' END AS status FROM [Menu] m
	INNER JOIN JenisMenu jm ON m.id_jenis_makanan = jm.id_jenis_makanan
	WHERE m.id_menu_makanan LIKE '%' + @cari + '%'
	OR jm.nama_jenis_makanan LIKE '%' + @cari + '%'
	OR m.nama_makanan LIKE '%' + @cari + '%'
	OR m.harga_makanan LIKE '%' + @cari + '%'
	OR m.deskripsi_makanan LIKE '%' + @cari + '%'
	OR CASE WHEN m.status_makanan > 0 THEN 'Tersedia' ELSE 'Tidak Tersedia' END LIKE '%' + @cari + '%'
END
DROP PROCEDURE sp_CariMenuMakanan

--Jenis Menu
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER PROCEDURE [dbo].[sp_CariJenisMenu]
	@cari		nvarchar(50)
AS
BEGIN 
	SELECT * FROM JenisMenu
	WHERE id_jenis_makanan LIKE '%' + @cari + '%'
	OR nama_jenis_makanan LIKE '%' + @cari + '%'
	OR deskripsi_jenis_makanan LIKE '%' + @cari + '%'
END
DROP PROCEDURE sp_CariJenisMakanan

--Ruangan
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER PROCEDURE [dbo].[sp_CariRuangan]
	@cari		nvarchar(50)
AS
BEGIN 
	SELECT id_ruangan, nama_ruangan, harga_ruangan, CASE WHEN status_ruangan > 0 THEN 'Tersedia' ELSE 'Tidak Tersedia' END AS status FROM Ruangan
	WHERE id_ruangan LIKE '%' + @cari + '%'
	OR nama_ruangan LIKE '%' + @cari + '%'
	OR harga_ruangan LIKE '%' + @cari +'%'
	OR CASE WHEN status_ruangan > 0 THEN 'Tersedia' ELSE 'Tidak Tersedia' END LIKE '%' + @cari + '%'
END

---Role 
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_CariRole]
	@cari		nvarchar(50)
AS
BEGIN 
	SELECT * FROM [Role]
	WHERE id_role LIKE '%' + @cari + '%'
	OR nama_role LIKE '%' + @cari + '%'
END

--User
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER PROCEDURE [dbo].[sp_CariUser]
	@cari		nvarchar(50)
AS
BEGIN 
	SELECT u.id_user, u.nama_user, u.email_user, u.password, r.nama_role, du.nama FROM [User] u
	INNER JOIN [Role] r ON u.id_role = r.id_role
	INNER JOIN DetailUser du ON u.id_dt_user = du.id
	WHERE u.id_user LIKE '%' + @cari + '%'
	OR u.nama_user  LIKE '%' + @cari + '%'
	OR u.email_user  LIKE '%' + @cari + '%'
	OR r.nama_role  LIKE '%' + @cari + '%'
	OR du.nama  LIKE '%' + @cari + '%'
END

--- Detail User
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER PROCEDURE [dbo].[sp_CariDetailUser]
	@cari		nvarchar(50)
AS
BEGIN 
	SELECT * FROM DetailUser
	WHERE id LIKE '%' + @cari + '%'
	OR nama LIKE '%' + @cari + '%'
	OR nik LIKE '%' + @cari + '%'
	OR tanggal_lahir LIKE '%' + @cari + '%'
	OR alamat LIKE '%' + @cari + '%'
END

-- Detail Fasilitas Kamar
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER PROCEDURE [dbo].[sp_CariDetailFasilitasKamar]
	@cari		nvarchar(50)
AS
BEGIN 
	SELECT d.id_dt_fasilitas_kamar, k.nama_kelas_kamar, f.nama_fasilitas, d.qty FROM DetailFasilitasKamar d
	INNER JOIN KelasKamar k ON d.id_kelas_kamar = k.id_kelas_kamar
	INNER JOIN Fasilitas f ON d.id_fasilitas = f.id_fasilitas
	WHERE d.id_dt_fasilitas_kamar LIKE '%' + @cari + '%'
	OR k.nama_kelas_kamar  LIKE '%' + @cari + '%'
	OR f.nama_fasilitas  LIKE '%' + @cari + '%'
	OR d.qty  LIKE '%' + @cari + '%'
END

-- Kamar
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER PROCEDURE [dbo].[sp_CariKamar]
	@cari		nvarchar(50)
AS
BEGIN 
	SELECT k.id_kamar, kk.nama_kelas_kamar, jk.nama_jenis_kamar, CASE WHEN k.status_kamar > 0 THEN 'Tersedia' ELSE 'Tidak Tersedia' END AS status FROM Kamar k 
	INNER JOIN JenisKamar jk ON k.id_jenis_kamar = jk.id_jenis_kamar
	INNER JOIN KelasKamar kk ON k.id_kelas_kamar = kk.id_kelas_kamar
	WHERE k.id_kamar LIKE '%' + @cari + '%'
	OR kk.nama_kelas_kamar  LIKE '%' + @cari + '%'
	OR jk.nama_jenis_kamar  LIKE '%' + @cari + '%'
	OR CASE WHEN k.status_kamar > 0 THEN 'Tersedia' ELSE 'Tidak Tersedia' END LIKE '%' + @cari + '%'
END

-- Fasilitas
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE or ALTER PROCEDURE [dbo].[sp_CariFasilitas]
	@cari		nvarchar(50)
AS
BEGIN 
	SELECT * FROM Fasilitas
	WHERE id_fasilitas LIKE '%' + @cari + '%' 
	OR nama_fasilitas LIKE '%' + @cari + '%'
	OR qty LIKE '%' + @cari + '%'
END

-- Customer
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER  PROCEDURE [dbo].[sp_CariCustomer]
	@cari		nvarchar(50)
AS
BEGIN 
	SELECT id_user, nama_user, email_user FROM [User]
	WHERE id_role = 3 AND (id_user LIKE '%' + @cari + '%'
	OR nama_user LIKE '%' + @cari + '%'
	OR email_user LIKE '%' + @cari + '%')
END

USE SI_Hotel

-- Kamar Transaksi
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER PROCEDURE [dbo].[sp_CariKamarTransaksi]
	@cari		nvarchar(50)
AS
BEGIN
	SELECT k.id_kamar, kk.nama_kelas_kamar, jk.nama_jenis_kamar, CASE WHEN k.status_kamar > 0 THEN 'Tersedia' ELSE 'Tidak Tersedia' END AS status FROM Kamar k
	INNER JOIN JenisKamar jk ON k.id_jenis_kamar = jk.id_jenis_kamar
	INNER JOIN KelasKamar kk ON k.id_kelas_kamar = kk.id_kelas_kamar
	WHERE k.status_kamar = 1 AND (k.id_kamar LIKE '%' + @cari + '%'
	OR kk.nama_kelas_kamar LIKE '%' + @cari + '%'
	OR jk.nama_jenis_kamar LIKE '%' + @cari + '%'
	OR CASE WHEN k.status_kamar > 0 THEN 'Tersedia' ELSE 'Tidak Tersedia' END LIKE '%' + @cari + '%')
END

--- Search Transaksi Kamar
CREATE PROCEDURE [dbo].[sp_CariTransaksiKamar]
	@cari		nvarchar(50)
AS
BEGIN
	SELECT tk.id_tr_kamar, c.nama_user, r.nama_user, tk.id_kamar, kk.nama_kelas_kamar, jk.nama_jenis_kamar, tk.tgl_transaksi, tk.check_in, tk.check_out, tk.total_harga, CASE WHEN tk.status_transaksi > 1 THEN 'Check Out' ELSE 'Check In' END AS status FROM TransaksiKamar tk
	INNER JOIN [User] c ON tk.id_customer = c.id_user
	INNER JOIN [User] r ON tk.id_receptionist = r.id_user
	INNER JOIN Kamar k ON tk.id_kamar = k.id_kamar
	INNER JOIN KelasKamar kk ON k.id_kelas_kamar = kk.id_kelas_kamar
	INNER JOIN JenisKamar jk ON k.id_jenis_kamar = jk.id_jenis_kamar
	WHERE tk.status_transaksi = 1 AND (tk.id_tr_kamar LIKE '%' + @cari + '%'
	OR c.nama_user LIKE '%' + @cari + '%'
	OR r.nama_user LIKE '%' + @cari + '%'
	OR tk.id_kamar LIKE '%' + @cari + '%'
	OR kk.nama_kelas_kamar LIKE '%' + @cari + '%'
	OR jk.nama_jenis_kamar LIKE '%' + @cari + '%'
	OR tk.tgl_transaksi LIKE '%' + @cari + '%'
	OR tk.check_in LIKE '%' + @cari + '%'
	OR tk.check_out LIKE '%' + @cari + '%'
	OR tk.total_harga LIKE '%' + @cari + '%'
	OR CASE WHEN tk.status_transaksi > 1 THEN 'Check Out' ELSE 'Check In' END LIKE '%' + @cari + '%')
END

-- Search TransaksiKamarMenu
CREATE PROCEDURE [dbo].[sp_CariTransaksiKamarMenu]
	@cari		nvarchar(50)
AS
BEGIN
	SELECT tk.id_tr_kamar, tk.id_customer, c.nama_user, r.nama_user, tk.id_kamar, kk.nama_kelas_kamar, jk.nama_jenis_kamar, tk.tgl_transaksi, tk.check_in, tk.check_out, tk.total_harga, CASE WHEN tk.status_transaksi > 1 THEN 'Check Out' ELSE 'Check In' END AS status FROM TransaksiKamar tk
	INNER JOIN [User] c ON tk.id_customer = c.id_user
	INNER JOIN [User] r ON tk.id_receptionist = r.id_user
	INNER JOIN Kamar k ON tk.id_kamar = k.id_kamar
	INNER JOIN KelasKamar kk ON k.id_kelas_kamar = kk.id_kelas_kamar
	INNER JOIN JenisKamar jk ON k.id_jenis_kamar = jk.id_jenis_kamar
	WHERE tk.status_transaksi = 1 AND (tk.id_tr_kamar LIKE '%' + @cari + '%'
	OR c.nama_user LIKE '%' + @cari + '%'
	OR r.nama_user LIKE '%' + @cari + '%'
	OR tk.id_kamar LIKE '%' + @cari + '%'
	OR kk.nama_kelas_kamar LIKE '%' + @cari + '%'
	OR jk.nama_jenis_kamar LIKE '%' + @cari + '%'
	OR tk.tgl_transaksi LIKE '%' + @cari + '%'
	OR tk.check_in LIKE '%' + @cari + '%'
	OR tk.check_out LIKE '%' + @cari + '%'
	OR tk.total_harga LIKE '%' + @cari + '%'
	OR CASE WHEN tk.status_transaksi > 1 THEN 'Check Out' ELSE 'Check In' END LIKE '%' + @cari + '%')
END

-- Search Menu Transaksi
CREATE OR ALTER PROCEDURE [dbo].[sp_CariMenuTransaksi]
	@cari		nvarchar(50)
AS
BEGIN
	SELECT m.id_menu_makanan, jm.nama_jenis_makanan, m.nama_makanan, m.harga_makanan, m.deskripsi_makanan, CASE WHEN m.status_makanan > 0 THEN 'Tersedia' ELSE 'Tidak Tersedia' END AS status FROM [Menu] m
	INNER JOIN JenisMenu jm ON m.id_jenis_makanan = jm.id_jenis_makanan
	WHERE m.status_makanan = 1 AND (m.id_menu_makanan LIKE '%' + @cari + '%'
	OR jm.nama_jenis_makanan LIKE '%' + @cari + '%'
	OR m.nama_makanan LIKE '%' + @cari + '%'
	OR m.harga_makanan LIKE '%' + @cari + '%'
	OR m.deskripsi_makanan LIKE '%' + @cari + '%'
	OR CASE WHEN m.status_makanan > 0 THEN 'Tersedia' ELSE 'Tidak Tersedia' END LIKE '%' + @cari + '%')
END

-- Search Detail Pembelian
CREATE OR ALTER PROCEDURE [dbo].[sp_CariDetailTrsMenu]
	@id_tr_dapur		VARCHAR(10),
	@cari				VARCHAR(50)
AS
BEGIN
	SELECT dt.id_tr_dapur, m.nama_makanan, dt.qty, dt.total_harga FROM DetailTransaksiPembelian dt
	INNER JOIN Menu m ON m.id_menu_makanan = dt.id_menu_makanan
	WHERE dt.id_tr_dapur = @id_tr_dapur AND (dt.id_tr_dapur LIKE '%' + @cari + '%'
	OR m.nama_makanan LIKE '%' + @cari + '%'
	OR m.nama_makanan LIKE '%' + @cari + '%'
	OR dt.qty LIKE '%' + @cari + '%'
	OR dt.total_harga LIKE '%' + @cari + '%')
END