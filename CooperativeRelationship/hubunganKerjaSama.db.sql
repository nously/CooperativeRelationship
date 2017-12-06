BEGIN TRANSACTION;
CREATE TABLE IF NOT EXISTS `unit_pengguna` (
	`id`	INTEGER PRIMARY KEY AUTOINCREMENT,
	`namaUnitPengguna`	TEXT UNIQUE
);
INSERT INTO `unit_pengguna` (id,namaUnitPengguna) VALUES (1,'Jurusan Sosiologi'),
 (2,'Jurusan Ilmu Komunikasi'),
 (3,'Jurusan Psikologi'),
 (4,'Jurusan Politik Pemerintahan dan Hubungan Internasional');
CREATE TABLE IF NOT EXISTS `kerjasama` (
	`id`	INTEGER PRIMARY KEY AUTOINCREMENT,
	`namaFile`	TEXT,
	`tahun`	INTEGER,
	`jenisKerjasama`	INTEGER,
	`institusi`	TEXT,
	`nomorPerjanjianFisip`	TEXT UNIQUE,
	`nomorPerjanjianInstitusi`	TEXT,
	`tempatTanggalTTD`	TEXT,
	`mulaiBerlaku`	TEXT,
	`berhentiBerlaku`	TEXT,
	`fokusPerjanjian`	TEXT,
	`penandatanganFisip`	TEXT,
	`penandatanganInstitusi`	TEXT,
	`unitPengusul`	TEXT,
	`unitPengguna`	TEXT,
	`namaNarahubungFisip`	TEXT,
	`handphoneNarahubungFisip`	TEXT,
	`emailNarahubungFisip`	TEXT,
	`namaNarahubungInstitusi`	TEXT,
	`handphoneNarahubungInstitusi`	TEXT,
	`emailNarahubungInstitusi`	TEXT,
	`jabatanNarahubungFisip`	TEXT,
	`jabatanNarahubungInstitusi`	TEXT,
	`nilaiKerjasama`	INTEGER,
	`filePath`	TEXT UNIQUE
);
CREATE TABLE IF NOT EXISTS `fokus_perjanjian` (
	`id`	INTEGER PRIMARY KEY AUTOINCREMENT,
	`textFokusPerjanjian`	TEXT UNIQUE
);
INSERT INTO `fokus_perjanjian` (id,textFokusPerjanjian) VALUES (1,'Praktek Kerja Nyata (PKN) atau Magang Mahasiswa'),
 (2,'Penelitian Dosen dan Mahasiswa'),
 (3,'Pemberdayaan dan Pembinaan Sumberdaya pada Masing-masing instansi');
CREATE TABLE IF NOT EXISTS `daftar_tahun` (
	`id`	INTEGER PRIMARY KEY AUTOINCREMENT,
	`tahun`	INTEGER NOT NULL,
	`jenis_kerjasama`	INTEGER NOT NULL
);
COMMIT;
