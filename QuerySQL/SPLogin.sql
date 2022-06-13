/*
  Aplikasi Sistem Informasi Hotel
  Kelompok 02
  Gerlando Aryaf Garibaldi Corputty
  Nabilah Rahmah Wati
  Zahra Salsabilla Ananda Putri
*/

USE SI_Hotel

----Store Procedure Login----

/*
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Login]
	@id VARCHAR	(10)
AS
BEGIN
	DELETE FROM tblPegawailogin
	INSERT INTO tblPegawailogin VALUES (@id)
END
*/

-----------------------------

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE[dbo].[sp_Login]
	@email_user varchar(50),
	@password varchar(50)
AS
BEGIN
	SELECT id_user, nama_user, email_user, password, id_role FROM [User] WHERE email_user = @email_user AND password = @password 
END

-----------------------------