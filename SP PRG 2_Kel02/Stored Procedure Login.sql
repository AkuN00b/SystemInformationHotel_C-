--sp Login 
USE SI_Hotel

SET ANSI_NULLS ON
GO 
SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER PROCEDURE[dbo].[sp_Login]
	@email_user varchar(50),
	@password varchar(50)
	AS
BEGIN

EXEC sp_HapusKeranjang
EXEC sp_UpdateAutoStatusTrsKamar
EXEC sp_UpdateAutoStatusTrsRuangan

SELECT id_user,nama_user,email_user,password,id_role FROM [User] WHERE email_user = @email_user
	AND password = @password
END 

CREATE OR ALTER VIEW LaporanTransaksiRuangan AS
SELECT tr.id_tr_ruangan, c.nama_user AS 'NamaCustomer', r.nama_user AS 'NamaResepsionis', tr.id_ruangan, ru.nama_ruangan, tr.tgl_transaksi, tr.checkin, tr.checkout, tr.total_harga, CASE WHEN tr.status_transaksi > 1 THEN 'Check Out' ELSE 'Check In' END AS status FROM TransaksiRuangan tr
INNER JOIN [User] c ON tr.id_customer = c.id_user
INNER JOIN [User] r ON tr.id_receptionist = r.id_user
INNER JOIN Ruangan ru ON tr.id_ruangan = ru.id_ruangan