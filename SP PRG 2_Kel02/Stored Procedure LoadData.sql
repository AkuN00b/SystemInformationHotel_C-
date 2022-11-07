--sp Load Data 
use SI_Hotel
--- Load Data Jenis kamar 
CREATE PROCEDURE [dbo].[sp_LoadJenisMenu]
AS
BEGIN
SELECT * FROM JenisMenu
END

-- Load data load Fasilitas 
CREATE PROCEDURE [dbo].[sp_LoadFasilitas]
AS
BEGIN
SELECT * FROM [Fasilitas]
END

-- Load data kelas kamar 


-- Load data Ruangan
CREATE OR ALTER PROCEDURE [dbo].[sp_LoadRuangan]
AS
BEGIN
SELECT id_ruangan, nama_ruangan, harga_ruangan, CASE WHEN status_ruangan > 0 THEN 'Tersedia' ELSE 'Tidak Tersedia' END AS status FROM Ruangan r
END

CREATE OR ALTER VIEW LoadRuangan AS
SELECT id_ruangan, nama_ruangan, harga_ruangan, CASE WHEN status_ruangan > 0 THEN 'Tersedia' ELSE 'Tidak Tersedia' END AS status FROM Ruangan

SELECT * FROM LoadRuangan

Use SI_Hotel

-- Menu 
CREATE OR ALTER PROCEDURE [dbo].[sp_LoadMenu]
AS
BEGIN
SELECT m.id_menu_makanan, jm.nama_jenis_makanan, m.nama_makanan, m.harga_makanan, m.deskripsi_makanan, CASE WHEN m.status_makanan > 0 THEN 'Tersedia' ELSE 'Tidak Tersedia' END AS status FROM [Menu] m
	INNER JOIN JenisMenu jm ON m.id_jenis_makanan = jm.id_jenis_makanan
END

CREATE OR ALTER VIEW LoadMenu AS
SELECT m.id_menu_makanan, jm.nama_jenis_makanan, m.nama_makanan, m.harga_makanan, m.deskripsi_makanan, CASE WHEN m.status_makanan > 0 THEN 'Tersedia' ELSE 'Tidak Tersedia' END AS status FROM [Menu] m
INNER JOIN JenisMenu jm ON m.id_jenis_makanan = jm.id_jenis_makanan

SELECT * FROM LoadMenu

--Jenis Menu 
CREATE PROCEDURE [dbo].[sp_LoadJenisMenu]
AS
BEGIN
SELECT * FROM [JenisMenu]
END

-- Kelas Kamar
CREATE PROCEDURE [dbo].[sp_LoadKelasKamar]
AS
BEGIN
SELECT * FROM KelasKamar
END

-- Jenis Kamar
CREATE PROCEDURE [dbo].[sp_LoadJenisKamar]
AS
BEGIN
SELECT * FROM JenisKamar
END

--- Load Data Role
CREATE PROCEDURE [dbo].[sp_LoadRole]
AS
BEGIN
SELECT * FROM [Role]
END

--- Load Data User
CREATE OR ALTER PROCEDURE [dbo].[sp_LoadUser]
AS
BEGIN
	SELECT u.id_user, u.nama_user, u.email_user, u.password, r.nama_role, du.nama FROM [User] u 
	INNER JOIN [Role] r ON u.id_role = r.id_role
	INNER JOIN DetailUser du ON u.id_dt_user = du.id
END

CREATE OR ALTER VIEW LoadUser AS
SELECT u.id_user, u.nama_user, u.email_user, u.password, r.nama_role, du.nama FROM [User] u 
INNER JOIN [Role] r ON u.id_role = r.id_role
INNER JOIN DetailUser du ON u.id_dt_user = du.id

SELECT * FROM LoadUser

--- Load Data Detail User
CREATE OR ALTER PROCEDURE [dbo].[sp_LoadDetailUser]
AS
BEGIN
	SELECT id, nama, nik, tanggal_lahir, alamat FROM DetailUser
END

--- Load Kamar
CREATE OR ALTER PROCEDURE [dbo].[sp_LoadKamar]
AS
BEGIN
	SELECT k.id_kamar, kk.nama_kelas_kamar, jk.nama_jenis_kamar, CASE WHEN k.status_kamar > 0 THEN 'Tersedia' ELSE 'Tidak Tersedia' END AS status FROM Kamar k
	INNER JOIN JenisKamar jk ON k.id_jenis_kamar = jk.id_jenis_kamar
	INNER JOIN KelasKamar kk ON k.id_kelas_kamar = kk.id_kelas_kamar
END

CREATE OR ALTER VIEW LoadKamar AS
SELECT k.id_kamar, kk.nama_kelas_kamar, jk.nama_jenis_kamar, CASE WHEN k.status_kamar > 0 THEN 'Tersedia' ELSE 'Tidak Tersedia' END AS status FROM Kamar k
INNER JOIN JenisKamar jk ON k.id_jenis_kamar = jk.id_jenis_kamar
INNER JOIN KelasKamar kk ON k.id_kelas_kamar = kk.id_kelas_kamar

SELECT * FROM LoadKamar

--- Load Data Detail Fasilitas Kamar
CREATE OR ALTER PROCEDURE [dbo].[sp_LoadDetailFasilitasKamar]
AS
BEGIN
	SELECT d.id_dt_fasilitas_kamar, k.nama_kelas_kamar, f.nama_fasilitas, d.qty FROM DetailFasilitasKamar d
	INNER JOIN KelasKamar k ON d.id_kelas_kamar = k.id_kelas_kamar
	INNER JOIN Fasilitas f ON d.id_fasilitas = f.id_fasilitas
END

CREATE OR ALTER VIEW LoadDetailFasilitasKamar AS
SELECT d.id_dt_fasilitas_kamar, k.nama_kelas_kamar, f.nama_fasilitas, d.qty FROM DetailFasilitasKamar d
INNER JOIN KelasKamar k ON d.id_kelas_kamar = k.id_kelas_kamar
INNER JOIN Fasilitas f ON d.id_fasilitas = f.id_fasilitas

SELECT * FROM LoadDetailFasilitasKamar

--- Load Data Customer
CREATE PROCEDURE [dbo].[sp_LoadCustomer]
AS
BEGIN
	SELECT id_user, nama_user, email_user FROM [User]
	WHERE id_role = 3
END

--- Load Kamar Transaksi
CREATE OR ALTER PROCEDURE [dbo].[sp_LoadKamarTransaksi]
AS
BEGIN
	SELECT k.id_kamar, kk.nama_kelas_kamar, jk.nama_jenis_kamar, CASE WHEN k.status_kamar > 0 THEN 'Tersedia' ELSE 'Tidak Tersedia' END AS status, jk.harga_jenis_kamar, kk.harga_kelas_kamar FROM Kamar k
	INNER JOIN JenisKamar jk ON k.id_jenis_kamar = jk.id_jenis_kamar
	INNER JOIN KelasKamar kk ON k.id_kelas_kamar = kk.id_kelas_kamar
	WHERE k.status_kamar = 1
END

SELECT * FROM TransaksiKamar

--- Load Transaksi Kamar
CREATE OR ALTER PROCEDURE [dbo].[sp_LoadTransaksiKamar]
AS
BEGIN
	SELECT tk.id_tr_kamar, c.nama_user, r.nama_user, tk.id_kamar, kk.nama_kelas_kamar, jk.nama_jenis_kamar, tk.tgl_transaksi, tk.check_in, tk.check_out, tk.total_harga, CASE WHEN tk.status_transaksi > 1 THEN 'Check Out' ELSE 'Check In' END AS status FROM TransaksiKamar tk
	INNER JOIN [User] c ON tk.id_customer = c.id_user
	INNER JOIN [User] r ON tk.id_receptionist = r.id_user
	INNER JOIN Kamar k ON tk.id_kamar = k.id_kamar
	INNER JOIN KelasKamar kk ON k.id_kelas_kamar = kk.id_kelas_kamar
	INNER JOIN JenisKamar jk ON k.id_jenis_kamar = jk.id_jenis_kamar
	WHERE tk.status_transaksi = 1
END

--- Load Transaksi Kamar
CREATE OR ALTER PROCEDURE [dbo].[sp_LoadTransaksiKamarMenu]
AS
BEGIN
	SELECT tk.id_tr_kamar, tk.id_customer, c.nama_user, r.nama_user, tk.id_kamar, kk.nama_kelas_kamar, jk.nama_jenis_kamar, tk.tgl_transaksi, tk.check_in, tk.check_out, tk.total_harga, CASE WHEN tk.status_transaksi > 1 THEN 'Check Out' ELSE 'Check In' END AS status FROM TransaksiKamar tk
	INNER JOIN [User] c ON tk.id_customer = c.id_user
	INNER JOIN [User] r ON tk.id_receptionist = r.id_user
	INNER JOIN Kamar k ON tk.id_kamar = k.id_kamar
	INNER JOIN KelasKamar kk ON k.id_kelas_kamar = kk.id_kelas_kamar
	INNER JOIN JenisKamar jk ON k.id_jenis_kamar = jk.id_jenis_kamar
	WHERE tk.status_transaksi = 1
END

--- Load Menu
CREATE OR ALTER PROCEDURE [dbo].[sp_LoadMenuTransaksi]
AS
BEGIN
	SELECT m.id_menu_makanan, jm.nama_jenis_makanan, m.nama_makanan, m.harga_makanan, m.deskripsi_makanan, CASE WHEN m.status_makanan > 0 THEN 'Tersedia' ELSE 'Tidak Tersedia' END AS status FROM [Menu] m
	INNER JOIN JenisMenu jm ON m.id_jenis_makanan = jm.id_jenis_makanan
	WHERE m.status_makanan = 1
END

--- Load Menu
CREATE OR ALTER PROCEDURE [dbo].[sp_LoadDetailTrsMenu]
	@id_tr_dapur		VARCHAR(10)
AS
BEGIN

	SELECT dt.id_tr_dapur, dt.id_menu_makanan, m.nama_makanan, dt.qty, dt.total_harga FROM DetailTransaksiPembelian dt
	INNER JOIN Menu m ON m.id_menu_makanan = dt.id_menu_makanan
	WHERE dt.id_tr_dapur = @id_tr_dapur
END

--- Load Ruangan Transaksi
CREATE OR ALTER PROCEDURE [dbo].[sp_LoadRuanganTransaksi]
AS
BEGIN
	SELECT id_ruangan, nama_ruangan, harga_ruangan, CASE WHEN status_ruangan > 0 THEN 'Tersedia' ELSE 'Tidak Tersedia' END AS status FROM Ruangan
	WHERE status_ruangan = 1
END

--- Load Transaksi Kamar
CREATE OR ALTER PROCEDURE [dbo].[sp_LoadTransaksiRuangan]
AS
BEGIN
	SELECT tr.id_tr_ruangan, c.nama_user, r.nama_user, ru.id_ruangan, ru.nama_ruangan, tr.tgl_transaksi, tr.checkin, tr.checkout, tr.total_harga, CASE WHEN tr.status_transaksi > 1 THEN 'Check Out' ELSE 'Check In' END AS status FROM TransaksiRuangan tr
	INNER JOIN [User] c ON tr.id_customer = c.id_user
	INNER JOIN [User] r ON tr.id_receptionist = r.id_user
	INNER JOIN Ruangan ru ON tr.id_ruangan = ru.id_ruangan
	WHERE tr.status_transaksi = 1
END

select * from KelasKamar