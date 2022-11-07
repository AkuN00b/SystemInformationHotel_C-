use SI_Hotel

-- Role
CREATE PROCEDURE [dbo].[sp_ComboBoxRole]
AS
BEGIN
	SELECT nama_role FROM [Role]
END

-- Role (Get ID)
CREATE PROCEDURE [dbo].[sp_ComboBoxGetIDRole]
	@cari		varchar(50)
AS
BEGIN
	SELECT id_role FROM [Role] WHERE nama_role LIKE '%' + @cari + '%'
END

-- Jenis Menu
CREATE PROCEDURE [dbo].[sp_ComboBoxJenisMenu]
AS
BEGIN
	SELECT nama_jenis_makanan FROM JenisMenu
END

-- Jenis Menu (Get ID)
CREATE PROCEDURE [dbo].[sp_ComboBoxGetIDJenisMenu]
	@cari		varchar(50)
AS
BEGIN
	SELECT id_jenis_makanan FROM JenisMenu WHERE nama_jenis_makanan LIKE '%' + @cari + '%'
END

-- Kelas Kamar
CREATE PROCEDURE [dbo].[sp_ComboBoxKelasKamar]
AS
BEGIN
	SELECT nama_kelas_kamar FROM KelasKamar
END

-- Kelas Kamar (Get ID)
CREATE PROCEDURE [dbo].[sp_ComboBoxGetIDKelasKamar]
	@cari		varchar(50)
AS
BEGIN
	SELECT id_kelas_kamar FROM KelasKamar WHERE nama_kelas_kamar LIKE '%' + @cari + '%'
END

-- Fasilitas
CREATE PROCEDURE [dbo].[sp_ComboBoxFasilitas]
AS
BEGIN
	SELECT nama_fasilitas FROM Fasilitas
END

-- Fasilitas (Get ID)
CREATE PROCEDURE [dbo].[sp_ComboBoxGetIDFasilitas]
	@cari		varchar(50)
AS
BEGIN
	SELECT id_fasilitas FROM Fasilitas WHERE nama_fasilitas LIKE '%' + @cari + '%'
END

-- Jenis Kamar
CREATE PROCEDURE [dbo].[sp_ComboBoxJenisKamar]
AS
BEGIN
	SELECT nama_jenis_kamar FROM JenisKamar
END

-- Kelas Kamar (Get ID)
CREATE PROCEDURE [dbo].[sp_ComboBoxGetIDJenisKamar]
	@cari		varchar(50)
AS
BEGIN
	SELECT id_jenis_kamar FROM JenisKamar WHERE nama_jenis_kamar LIKE '%' + @cari + '%'
END