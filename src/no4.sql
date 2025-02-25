-- 4a
SELECT *
FROM Barang
WHERE HARGA_SATUAN > 10000
ORDER BY HARGA_SATUAN ASC;

-- 4b
SELECT *
FROM Pelanggan
WHERE NAMA like '%g%' AND
ALAMAT = 'BANDUNG';

-- 4c
SELECT 
    t.KODE,
    t.TANGGAL,
    p.NAMA AS "NAMA PELANGGAN",
    b.NAMA AS "NAMA BARANG",
    t.JUMLAH,
    b.HARGA_SATUAN AS "HARGA SATUAN",
    (t.JUMLAH * b.HARGA_SATUAN) AS "TOTAL"
FROM Transaksi t
JOIN Barang b ON b.KODE = t.KODE_BARANG
JOIN Pelanggan p ON p.KODE = t.KODE_PELANGGAN;

-- 4d
SELECT
    p.NAMA,
    t.JUMLAH,
    (t.JUMLAH * b.HARGA_SATUAN) AS "TOTAL HARGA"
FROM Transaksi t
JOIN Barang b ON b.KODE = t.KODE_BARANG
JOIN Pelanggan p ON p.KODE = t.KODE_PELANGGAN;