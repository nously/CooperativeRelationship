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
	`namaFile`	TEXT UNIQUE,
	`tahun`	INTEGER,
	`jenisKerjasama`	INTEGER,
	`institusi`	TEXT,
	`nomorPerjanjianFisip`	TEXT UNIQUE,
	`nomorPerjanjianInstitusi`	TEXT UNIQUE,
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
INSERT INTO `kerjasama` (id,namaFile,tahun,jenisKerjasama,institusi,nomorPerjanjianFisip,nomorPerjanjianInstitusi,tempatTanggalTTD,mulaiBerlaku,berhentiBerlaku,fokusPerjanjian,penandatanganFisip,penandatanganInstitusi,unitPengusul,unitPengguna,namaNarahubungFisip,handphoneNarahubungFisip,emailNarahubungFisip,namaNarahubungInstitusi,handphoneNarahubungInstitusi,emailNarahubungInstitusi,jabatanNarahubungFisip,jabatanNarahubungInstitusi,nilaiKerjasama,filePath) VALUES (1,'1_Test_.docx',2014,2,'Lembaga Pemasyarakatan Kelas I Malang','…/KS','…/KS','Malang, … … 2017','30/11/2014','30/11/2017','Praktek Kerja Nyata (PKN) atau Magang Mahasiswa|Penelitian Dosen dan Mahasiswa|Pemberdayaan dan Pembinaan Sumberdaya pada Masing-masing instansi','Dekan FISIP UB: Prof. Dr. Unti Ludigdo, Ak','Test','Jurusan Psikologi FISIP UB','Jurusan Sosiologi|Jurusan Ilmu Komunikasi|Jurusan Psikologi|Jurusan Politik Pemerintahan dan Hubungan Internasional','Ibnu Asqori Pohan','0878 5249 2519','inbuasqoripohan@ub.ac.id','test','test','test','Koordinator Kerjasama FISIP UB','test',5000000,'C:\Users\nousl\OneDrive\Documents\Hubungan Kerja Sama\Luar Negeri\2014\1_Test_.docx'),
 (2,'2_Test_.docx',2014,2,'Test','Test','Test','Test','Test','Test','Test','Test','Test','Test','Test','Test','Test','Test','Test','Test','Test','Test','Test',1000000,'C:\Users\nousl\OneDrive\Documents\Hubungan Kerja Sama\Luar Negeri\2014\2_Test_.docx');
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
INSERT INTO `daftar_tahun` (id,tahun,jenis_kerjasama) VALUES (1,2014,2),
 (2,2015,2),
 (3,2016,2),
 (4,2015,1),
 (5,2016,1),
 (6,2017,1),
 (7,2013,1);
COMMIT;
