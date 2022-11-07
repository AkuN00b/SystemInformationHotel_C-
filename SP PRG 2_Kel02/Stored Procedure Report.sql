use SI_Hotel

SELECT * FROM LaporanTransaksiKamar

CREATE OR ALTER PROCEDURE ReportKamar
	@dari date,
	@sampai date
AS
BEGIN
	SELECT * FROM LaporanTransaksiKamar
	WHERE tgl_transaksi BETWEEN @dari AND @sampai
	ORDER BY id_tr_kamar ASC
END

CREATE OR ALTER PROCEDURE ReportRuangan
	@dari date,
	@sampai date
AS
BEGIN
	SELECT * FROM LaporanTransaksiRuangan
	WHERE tgl_transaksi BETWEEN @dari AND @sampai
	ORDER BY id_tr_ruangan ASC
END

SELECT * FROM TransaksiPembelian

--- Grafik Total Pendapatan Transaksi Pembelian
CREATE OR ALTER VIEW GrafikTransaksiPembelian AS
SELECT YEAR(tgl_transaksi) AS Year, 
CASE
          WHEN MONTH(tgl_transaksi) = 1 THEN 'January'
          WHEN MONTH(tgl_transaksi) = 2 THEN 'February'
          WHEN MONTH(tgl_transaksi) = 3 THEN 'March'
          WHEN MONTH(tgl_transaksi) = 4 THEN 'April'
          WHEN MONTH(tgl_transaksi) = 5 THEN 'May'
          WHEN MONTH(tgl_transaksi) = 6 THEN 'June'
          WHEN MONTH(tgl_transaksi) = 7 THEN 'July'
          WHEN MONTH(tgl_transaksi) = 8 THEN 'August'
          WHEN MONTH(tgl_transaksi) = 9 THEN 'September'
          WHEN MONTH(tgl_transaksi) = 10 THEN 'October'
          WHEN MONTH(tgl_transaksi) = 11 THEN 'November'
          WHEN MONTH(tgl_transaksi) = 12 THEN 'December'
END AS Month, SUM(total_harga) 
AS Total_Pendapatan FROM TransaksiPembelian
GROUP BY YEAR(tgl_transaksi), MONTH(tgl_transaksi)

SELECT * FROM TransaksiPembelian
SELECT * FROM GrafikTransaksiPembelian

--- Grafik Total Pendapatan Transaksi Kamar
CREATE OR ALTER VIEW GrafikTransaksiKamar AS
SELECT YEAR(tgl_transaksi) AS Year,
CASE
          WHEN MONTH(tgl_transaksi) = 1 THEN 'January'
          WHEN MONTH(tgl_transaksi) = 2 THEN 'February'
          WHEN MONTH(tgl_transaksi) = 3 THEN 'March'
          WHEN MONTH(tgl_transaksi) = 4 THEN 'April'
          WHEN MONTH(tgl_transaksi) = 5 THEN 'May'
          WHEN MONTH(tgl_transaksi) = 6 THEN 'June'
          WHEN MONTH(tgl_transaksi) = 7 THEN 'July'
          WHEN MONTH(tgl_transaksi) = 8 THEN 'August'
          WHEN MONTH(tgl_transaksi) = 9 THEN 'September'
          WHEN MONTH(tgl_transaksi) = 10 THEN 'October'
          WHEN MONTH(tgl_transaksi) = 11 THEN 'November'
          WHEN MONTH(tgl_transaksi) = 12 THEN 'December'
END AS Month, SUM(total_harga)  
AS Total_Pendapatan FROM TransaksiKamar
GROUP BY YEAR(tgl_transaksi), MONTH(tgl_transaksi)

SELECT * FROM GrafikTransaksiKamar


--- Grafik Total Pendapatan Transaksi Ruangan
CREATE OR ALTER VIEW GrafikTransaksiRuangan AS
SELECT YEAR(tgl_transaksi) AS Year, 
CASE
          WHEN MONTH(tgl_transaksi) = 1 THEN 'January'
          WHEN MONTH(tgl_transaksi) = 2 THEN 'February'
          WHEN MONTH(tgl_transaksi) = 3 THEN 'March'
          WHEN MONTH(tgl_transaksi) = 4 THEN 'April'
          WHEN MONTH(tgl_transaksi) = 5 THEN 'May'
          WHEN MONTH(tgl_transaksi) = 6 THEN 'June'
          WHEN MONTH(tgl_transaksi) = 7 THEN 'July'
          WHEN MONTH(tgl_transaksi) = 8 THEN 'August'
          WHEN MONTH(tgl_transaksi) = 9 THEN 'September'
          WHEN MONTH(tgl_transaksi) = 10 THEN 'October'
          WHEN MONTH(tgl_transaksi) = 11 THEN 'November'
          WHEN MONTH(tgl_transaksi) = 12 THEN 'December'
END AS Month, SUM(total_harga) 
AS Total_Pendapatan FROM TransaksiRuangan
GROUP BY YEAR(tgl_transaksi), MONTH(tgl_transaksi)

SELECT * FROM GrafikTransaksiRuangan

-- Combo Box Tahun Transaksi Ruangan
CREATE VIEW CBTahunGrafikTransaksiRuangan AS
SELECT ([Year])
FROM GrafikTransaksiRuangan
GROUP BY ([Year])
HAVING COUNT(*) > 1

SELECT * FROM CBTahunGrafikTransaksiRuangan

-- Combo Box Tahun Transaksi Kamar
CREATE VIEW CBTahunGrafikTransaksiKamar AS
SELECT ([Year])
FROM GrafikTransaksiKamar
GROUP BY ([Year])
HAVING COUNT(*) > 1

SELECT * FROM CBTahunGrafikTransaksiKamar

-- Combo Box Tahun Transaksi Pembelian
CREATE VIEW CBTahunGrafikTransaksiPembelian AS
SELECT ([Year])
FROM GrafikTransaksiPembelian
GROUP BY ([Year])
HAVING COUNT(*) > 1

SELECT * FROM CBTahunGrafikTransaksiPembelian