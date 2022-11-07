--Database
--Pembuatan sp Delete 
Use SI_Hotel

--- Jenis Kamar
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE sp_DeleteJenisKamar
	@id_jenis_kamar		VARCHAR	(10)
AS
BEGIN
	DELETE FROM JenisKamar WHERE id_jenis_kamar = @id_jenis_kamar
END

--- Detail User
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE sp_DeleteDetailUser
	@id		int
AS
BEGIN
	DELETE FROM DetailUser WHERE id = @id
END

--- Kelas Kamar
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE sp_DeleteKelasKamar
	@id_kelas_kamar		int
AS
BEGIN
	DELETE FROM KelasKamar WHERE id_kelas_kamar = @id_kelas_kamar
END

--- Kamar
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE sp_DeleteKamar
	@id_kamar		varchar(10)
AS
BEGIN
	DELETE FROM Kamar WHERE id_kamar = @id_kamar
END

-- Jenis Menu 
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE sp_DeleteJenisMenu
	@id_jenis_menu		VARCHAR	(10)
AS
BEGIN
	DELETE FROM JenisMenu WHERE id_jenis_menu = @id_jenis_menu
END

--Menu
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE sp_DeleteMenu
	@id_menu		VARCHAR	(10)
AS
BEGIN
	DELETE FROM Menu WHERE id_menu_makanan = @id_menu
END

-- Kelas Kamar 
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE sp_DeleteKelasKamar
	@id_kelas_kamar		VARCHAR	(10)
AS
BEGIN
	DELETE FROM KelasKamar WHERE id_kelas_kamar = @id_kelas_kamar
END

-- Fasilitas
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE sp_DeleteFasilitas
	@id_fasilitas		VARCHAR	(10)
AS
BEGIN
	DELETE FROM Fasilitas WHERE id_fasilitas = @id_fasilitas
END


--Delete Ruangan 
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE sp_DeleteRuangan
	@id_ruangan		VARCHAR	(10)
AS
BEGIN
	DELETE FROM Ruangan WHERE id_ruangan = @id_ruangan
END

--- Role
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE sp_DeleteRole
	@id_role		VARCHAR	(10)
AS
BEGIN
	DELETE FROM [Role] WHERE id_role = @id_role
END

--- User
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE sp_DeleteUser
	@id_user		VARCHAR	(10)
AS
BEGIN
	DELETE FROM [User] WHERE id_user = @id_user
END

--- Detail Fasilitas Kamar
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE sp_DeleteFasilitasKamar
	@id_dt_fasilitas int,
	@id_fasilitas varchar(10),
	@qty int
AS
BEGIN
	DELETE FROM [DetailFasilitasKamar] WHERE id_dt_fasilitas_kamar = @id_dt_fasilitas

	UPDATE Fasilitas
	SET qty += @qty
	WHERE id_fasilitas = @id_fasilitas
END

--- Jenis Makanan
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE sp_DeleteJenisMakanan
	@id_jenis_menu int
AS
BEGIN
	DELETE FROM JenisMenu WHERE id_jenis_makanan = @id_jenis_menu
END

--- Detail Transaksi Menu
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE sp_DeleteTransaksiMenu
	@id_tr_dapur		varchar(10),
	@id_menu_makanan	varchar(10),	
	@harga				money

AS
BEGIN
	DELETE FROM DetailTransaksiPembelian WHERE id_tr_dapur = @id_tr_dapur AND id_menu_makanan = @id_menu_makanan

	UPDATE TransaksiPembelian
	SET total_harga -= @harga
	WHERE id_tr_dapur = @id_tr_dapur
END

--- Detail Transaksi Menu
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE sp_DeleteAllTransaksiMenu
	@id_tr_dapur		varchar(10)
AS
BEGIN
	DELETE FROM DetailTransaksiPembelian WHERE id_tr_dapur = @id_tr_dapur

	UPDATE TransaksiPembelian
	SET total_harga = 0
	WHERE id_tr_dapur = @id_tr_dapur
END

--- Transaksi Menu
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE sp_DeleteTransaksi
	@id_tr_dapur		varchar(10)
AS
BEGIN
	DELETE FROM DetailTransaksiPembelian WHERE id_tr_dapur = @id_tr_dapur

	DELETE FROM TransaksiPembelian WHERE id_tr_dapur = @id_tr_dapur
END