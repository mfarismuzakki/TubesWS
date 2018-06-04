-- phpMyAdmin SQL Dump
-- version 4.7.7
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 04, 2018 at 03:00 AM
-- Server version: 10.1.30-MariaDB
-- PHP Version: 7.2.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `perpustakaan`
--

-- --------------------------------------------------------

--
-- Table structure for table `anggotaperpustakaan`
--

CREATE TABLE `anggotaperpustakaan` (
  `id_anggota` int(11) NOT NULL,
  `nama_anggota` varchar(50) NOT NULL,
  `jenis_kelamin` varchar(2) NOT NULL,
  `tempat_lahir` varchar(50) NOT NULL,
  `tanggal_lahir` varchar(30) NOT NULL,
  `notelepon` varchar(20) NOT NULL,
  `alamat` varchar(500) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `anggotaperpustakaan`
--

INSERT INTO `anggotaperpustakaan` (`id_anggota`, `nama_anggota`, `jenis_kelamin`, `tempat_lahir`, `tanggal_lahir`, `notelepon`, `alamat`) VALUES
(1, 'a', 'a', 'a', 'a', 'a', 'a'),
(2, 'a', 'a', 'a', 'a', 'a', 'a');

-- --------------------------------------------------------

--
-- Table structure for table `bahasa`
--

CREATE TABLE `bahasa` (
  `id_bahasa` int(11) NOT NULL,
  `nama_bahasa` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `bahasa`
--

INSERT INTO `bahasa` (`id_bahasa`, `nama_bahasa`) VALUES
(1, 'Indonesia'),
(2, 'Inggris'),
(3, 'Jepang'),
(4, 'Perancis'),
(5, 'Korea'),
(6, 'Arab'),
(7, 'Melayu'),
(8, 'Afrika'),
(9, 'Italia'),
(10, 'Jepang'),
(11, 'Korea'),
(12, 'China'),
(13, 'Perancis'),
(14, 'Kamboja'),
(15, 'Arab'),
(16, 'Rusia');

-- --------------------------------------------------------

--
-- Table structure for table `copy_buku`
--

CREATE TABLE `copy_buku` (
  `id_copy_buku` int(11) NOT NULL,
  `id_buku` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `copy_buku`
--

INSERT INTO `copy_buku` (`id_copy_buku`, `id_buku`) VALUES
(1, 10),
(2, 11);

-- --------------------------------------------------------

--
-- Table structure for table `deskripsi`
--

CREATE TABLE `deskripsi` (
  `id_deskripsi` int(11) NOT NULL,
  `isi` varchar(500) NOT NULL,
  `id_buku` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `deskripsi`
--

INSERT INTO `deskripsi` (`id_deskripsi`, `isi`, `id_buku`) VALUES
(1, '10 Langkah Memaksimalkan Potensi Diri', 2),
(2, 'Membuat aplikasi website berteknologi Ajax dan AntiXSS; Berbagai contoh aplikasi website dari yang paling sederhana hingga yang rumit', 3),
(3, 'Catatan mahasiswa gokil', 4),
(4, 'Duel cowok ngomongin cintrong', 5),
(5, 'Informasi Teknis, Interface, Dasar-dasar video editing, video transition, video effect, titling, dan export project', 7),
(6, 'Teknik berbicara yang membawa anda ke jenjang sukses', 9),
(7, 'Buku ini digunakan sebagai dasar dalam pembelajaran Ilmu Komputer. Karena teknik informatika selalu memerlukan wawasan tentang matematika diskrit', 10),
(8, 'Novel ini menceritakan kisah Milea, siswa pindahaan dari Jakarta yang bertemu Dilan di SMA barunya di Bandung. Dengan latar waktu tahun 1990, cerita ini punya modal positif untuk menonjol di tengah generasi remaja masa kini (meski bukan itu yang jadi poin utama Pidi Baiq menulis cerita ini).', 11),
(9, 'Cerita tentang Dika. Selepas SMU, Dika (Raditya Dika), yang mempunyai nama panggilan Kambing, harus melanjutkan pendidikan di Adelaide, Australia. Ketika dia menjalani kuliah di Australia,', 12),
(10, 'Berisikan tentang 7 kebiasaan yang dapat kita lakukan untuk menjadi orang dengan tingkat efektivitas yang tinggi.', 13),
(11, 'Memberikan Pengetahuan tentang rumus-rumus dasar dalam pembelajaran Fisika', 14),
(12, 'Kisah tentang Bujang yang meceritakan kisah hidupnya', 15),
(13, 'Bercerita tentang pengalamannya belajar hidup dari apa yang dia cintai, sambil menemukan hal remeh untuk ditertawakan di sepanjang perjalanan.', 16),
(14, 'Buku ini digunakan sebagai cara penggunaan photography yang ada pada sebuah smartphone', 17),
(15, 'Memberikan prinsip serta masukan bagi pembaca dalam menempuh jalan hingga sukses', 18),
(16, 'Buku ini tentang pembelajaran astronomi tentang pengenalan atmosfer yang terdapat pada bumi', 19),
(17, 'Buku pembelajaran dalam konsep biologi yang mempelajari transformasi yang terjadi pada tumbuhan', 20),
(18, 'Novel ini mengisahkan kehidupan Fahri, tokoh utama, yang diwarnai dengan kisah hubungan lelaki dengan perempuan. Fahri adalah seorang mahasiswa Indonesia yang kuliah di Universitas Al Azhar, Mesir. Ia selalu berusaha meneladani Rasulullah Saw', 21),
(22, 'Menjelaskan trik trik jitu dalam belajar bahasa pemrograman PHP.', 25),
(23, 'Menggali potensi yang ada dalam diri kita.', 26),
(24, 'Menjelaskan trik trik jitu dalam belajar Corel.', 27),
(25, 'Menjelaskan trik trik jitu dalam belajar bahasa pemrograman Java.', 28),
(26, 'Tutorial menanam jagung di Pot Rumah.', 29),
(27, 'Trik supaya mudah menangkap ikan tanpa melukainya.', 30),
(28, 'Belajar macam macam hewan.', 31),
(29, 'Menjelaskan penjelasan tentang kuda Poni.', 32),
(30, 'Berisi tentang penjelasan framework MVC di Java.', 33),
(31, 'Menjelaskan tentang cara menghias aplikasi di java dengan javafx.', 34),
(32, 'Menjelaskan trik trik jitu dalam belajar bahasa pemrograman Java.', 35),
(33, 'Menggali Tujuan yang pasti dari diri kita.', 36),
(34, 'Menjelaskan trik trik jitu dalam belajar Photoshop.', 37),
(35, 'Menjelaskan trik trik jitu dalam belajar bahasa pemrograman PHP.', 38),
(36, 'Menjelaskan rumus-rumus dan trik perkalian kuadrat.', 39),
(37, 'Menjelaskan belajar matematika itu mudah.', 40),
(38, 'Tutorial belajar berenang.', 41),
(39, 'Trik-trik yang dapat dipelajari di sepakbola.', 42),
(40, 'Menjelaskan dasar-dasar belajar C# yang menyenangkan.', 43),
(41, 'Menjelaskan dasar-dasar HTML untuk pemula.', 44);

-- --------------------------------------------------------

--
-- Table structure for table `detail_peminjaman`
--

CREATE TABLE `detail_peminjaman` (
  `id_detail_peminjaman` int(11) NOT NULL,
  `id_peminjaman` int(11) NOT NULL,
  `id_copy_buku` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `judulbuku`
--

CREATE TABLE `judulbuku` (
  `id_buku` int(11) NOT NULL,
  `judul_buku` varchar(50) NOT NULL,
  `cetakan` int(11) NOT NULL,
  `tanggalterbit` varchar(30) NOT NULL,
  `id_penulis` int(11) NOT NULL,
  `id_penerbit` int(11) NOT NULL,
  `id_bahasa` int(11) NOT NULL,
  `id_kategori` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `judulbuku`
--

INSERT INTO `judulbuku` (`id_buku`, `judul_buku`, `cetakan`, `tanggalterbit`, `id_penulis`, `id_penerbit`, `id_bahasa`, `id_kategori`) VALUES
(2, 'Your Personal Breakthrough', 1, '2016', 8, 1, 1, 6),
(3, 'Aplikasi Website Profesional dengan PHP dan jQuery', 1, '2016', 7, 1, 1, 4),
(4, 'Anak Kos Dodol Lagi', 1, '2008', 6, 2, 1, 5),
(5, 'Si Dodol Vs Si Gokil', 2, '2009', 4, 3, 1, 5),
(7, 'Digital Video Editing dengan Adobe Premiere CS4', 3, '2009', 3, 4, 1, 4),
(9, 'Speak for Success: Komunikasi Lisan', 2, '2003', 2, 5, 1, 3),
(10, 'Matematika untuk Ilmu Komputer', 1, '2016', 1, 7, 1, 4),
(11, 'Kambing Jantan', 3, '2005', 9, 11, 1, 5),
(12, 'Sejarah Berdirinya Kota Makassar', 1, '2015', 4, 2, 1, 18),
(13, 'The 7 Habits of Highly Effective People', 1, '1989', 17, 12, 2, 6),
(14, 'Dilan: Dia adalah Dilanku Tahun 1990', 1, '2014', 14, 4, 1, 5),
(15, 'Mengenal Rumus-rumus dalam fisika', 1, '2012', 6, 3, 1, 16),
(16, 'Pulang', 1, '2016', 11, 2, 1, 5),
(17, 'Ubur-ubur Lembur', 2, '2018', 9, 5, 1, 5),
(18, 'Smartphone Photography', 3, '2009', 3, 6, 2, 4),
(19, 'Hidup Sukses', 2, '2012', 2, 8, 1, 6),
(20, 'Mengenal Atmosfer dalam bumi', 1, '2002', 18, 11, 1, 21),
(21, 'Transformasi yg terjadi pada tumbuhan', 3, '2005', 20, 16, 1, 17),
(22, 'Ayat-Ayat Cinta', 1, '2014', 22, 13, 1, 5),
(25, 'Mahir PHP 24 Jam', 1, '2014', 12, 4, 1, 4),
(26, 'Siapa Dirimu', 1, '2013', 21, 4, 1, 6),
(27, 'Mahir Corel 1 Jam', 1, '2014', 1, 4, 1, 4),
(28, 'Java From Zero To Hero', 1, '2014', 24, 4, 1, 4),
(29, 'Cara Menanam Jagung di Pot', 1, '2011', 27, 4, 1, 34),
(30, 'Trik Jitu Menangkap Ikan di Laut', 1, '2014', 23, 4, 1, 32),
(31, 'Mengenal Nama Hewan', 1, '2014', 13, 4, 1, 28),
(32, 'Mengenal Kuda Poni', 1, '2014', 27, 4, 1, 28),
(33, 'Java - MVC', 1, '2014', 11, 4, 1, 4),
(34, 'Memahami Javafx', 1, '2013', 28, 4, 1, 4),
(35, 'Mahir Java 24 Jam', 1, '2014', 38, 33, 1, 4),
(36, 'Apakah Tujuanmu?', 1, '2013', 39, 34, 1, 6),
(37, 'Mahir PhotoShop 1 Jam', 1, '2014', 40, 35, 1, 4),
(38, 'Belajar PHP Mudah', 1, '2014', 41, 36, 1, 4),
(39, 'Perkalian Kuadrat', 1, '2011', 42, 37, 1, 1),
(40, 'Matematika Itu Mudah', 1, '2014', 43, 38, 1, 1),
(41, 'Belajar Renang', 1, '2014', 44, 39, 1, 12),
(42, 'Trik-Trik Sepakbola', 1, '2014', 45, 40, 1, 12),
(43, 'C# Itu Menyenangkan', 1, '2014', 46, 41, 1, 4),
(44, 'Dasar-Dasar HTML', 1, '2013', 47, 42, 1, 4);

-- --------------------------------------------------------

--
-- Table structure for table `kategori`
--

CREATE TABLE `kategori` (
  `id_kategori` int(11) NOT NULL,
  `nama_kategori` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `kategori`
--

INSERT INTO `kategori` (`id_kategori`, `nama_kategori`) VALUES
(1, 'Matematika'),
(2, 'Pendidikan'),
(3, 'Komunikasi'),
(4, 'Komputer'),
(5, 'Novel'),
(6, 'Motivasi'),
(8, 'Psikologi'),
(9, 'Filosofi'),
(10, 'Bahasa'),
(11, 'Musik'),
(12, 'Olahraga'),
(13, 'Ekonomi'),
(14, 'Statistik'),
(15, 'Agama'),
(16, 'Fisika'),
(17, 'Biologi'),
(18, 'Sejarah'),
(19, 'Akuntansi'),
(20, 'Desain'),
(21, 'Astronomi'),
(22, 'Geografi'),
(23, 'Politik'),
(24, 'Hukum'),
(25, 'Pendidikan'),
(26, 'Teknik'),
(27, 'Kesenian'),
(28, 'Zoologi'),
(29, 'Pertanian'),
(30, 'Manufaktur'),
(31, 'Perhutanan'),
(32, 'Perikanan'),
(33, 'Pelayaran'),
(34, 'Perkebunan'),
(35, 'Konstruksi');

-- --------------------------------------------------------

--
-- Table structure for table `peminjaman`
--

CREATE TABLE `peminjaman` (
  `id_peminjaman` int(11) NOT NULL,
  `id_anggota` int(11) NOT NULL,
  `id_pustakawan` int(11) NOT NULL,
  `tanggalpinjam` varchar(30) NOT NULL,
  `tanggalkembali` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `peminjaman`
--

INSERT INTO `peminjaman` (`id_peminjaman`, `id_anggota`, `id_pustakawan`, `tanggalpinjam`, `tanggalkembali`) VALUES
(1, 1, 2, '18-05-07', '18-05-14'),
(2, 2, 2, '18-05-07', '18-05-14'),
(3, 3, 2, '18-05-16', '18-05-23'),
(4, 3, 2, '18-05-16', '18-05-23'),
(5, 3, 2, '18-05-16', '18-05-23'),
(6, 3, 2, '18-05-16', '18-05-23'),
(7, 10, 2, '18-05-16', '18-05-23'),
(8, 11, 2, '18-05-16', '18-05-23'),
(9, 12, 2, '18-05-16', '18-05-23'),
(10, 4, 2, '18-05-16', '18-05-23'),
(11, 14, 2, '18-05-16', '18-05-23'),
(12, 16, 2, '18-05-16', '18-05-23'),
(13, 18, 2, '18-05-16', '18-05-23'),
(14, 1, 1, '12', '12'),
(15, 22, 2, '18-05-16', '18-05-23'),
(16, 11, 2, '18-05-16', '18-05-23'),
(17, 100, 2, '18-05-16', '18-05-23'),
(18, 200, 2, '18-05-16', '18-05-23'),
(19, 1, 1, '20', '20');

-- --------------------------------------------------------

--
-- Table structure for table `penerbit`
--

CREATE TABLE `penerbit` (
  `id_penerbit` int(11) NOT NULL,
  `nama_penerbit` varchar(50) NOT NULL,
  `lokasipercetakan` varchar(50) NOT NULL,
  `notelepon` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `penerbit`
--

INSERT INTO `penerbit` (`id_penerbit`, `nama_penerbit`, `lokasipercetakan`, `notelepon`) VALUES
(1, 'Elex Media Komputindo', 'Jakarta', '02183247362'),
(2, 'Gradien Mediatama', 'Yogyakarta', '0274556117'),
(3, 'Sinergi Pustaka Indonesia', 'Bandung', '0227314342'),
(4, 'Bintang Indonesia', 'Jakarta', '02183492193'),
(5, 'Dahara Prize Semarang', 'Semarang', '0243511172'),
(6, 'Departemen Pedagogik FIP UPI', 'Bandung', '0818640335'),
(7, 'Graha Ilmu', 'Yogyakarta', '0274889398'),
(8, 'Grasindo', 'Jakarta', '0215483008'),
(9, 'Grahadi Group', 'Solo', '0283573838'),
(10, 'BayuMedia', 'Malang', '0341580638'),
(11, 'Gagas Media', 'Jakarta', '02183482933'),
(12, 'Free Press', 'New York', '2022651490'),
(13, 'Gaya Favorit Press', 'Jakarta', '0215253916'),
(14, 'Gema Insani', 'Yogyakarta', '0217708891'),
(15, 'EGC-Arcan', 'Bandung', '02165306283'),
(16, 'CSIS', 'Jakarta', '021386553235'),
(17, 'PT One Earth Media', 'Semarang', '0215253916'),
(18, 'Java Books Indonesia', 'Bandung', '0215483008'),
(19, 'Graha Ilmu', 'Makassar', '0274889398'),
(20, 'Grasindo', 'Jakarta', '0215483008'),
(21, 'Rosda', 'Bali', '02139049845'),
(22, 'Samudra Buku', 'Jakarta Selatan', '0217509673'),
(23, 'Bibit Unggul', 'Jakarta', '0226514901'),
(24, 'Harapan jaya', 'Bandung', '0226514902'),
(25, 'Bintang Sempurna', 'Bandung', '0226514903'),
(26, 'Grasian', 'Jakarta', '0226514904'),
(27, 'Media Star', 'Jakarta', '0226514905'),
(28, 'Ilmu Tinggi', 'Bandung', '0226514906'),
(29, 'Sinergi Bahagia', 'Bandung', '0226514907'),
(30, 'Sinta Media', 'Jakarta', '0226514908'),
(31, 'Media Kita', 'Bandung', '0226514909'),
(32, 'Pool Media', 'New York', '0226514910'),
(33, 'Media Kita', 'Subang', '0226514911'),
(34, 'Harapan Palsu', 'Bandung', '0226514912'),
(35, 'Bintang Sinar', 'Bandung', '0226514913'),
(36, 'Harapan Bintang', 'Yogyakarta', '0226514914'),
(37, 'Melodi Star', 'Jakarta', '0226514915'),
(38, 'Rising Star', 'Bandung', '0226514916'),
(39, 'Sinar Matahari', 'Bandung', '0226514917'),
(40, 'Dunia Indah', 'Jakarta', '0226514918'),
(41, 'Kertas Putih', 'Bandung', '0226514919'),
(42, 'Tinta Hitam', 'Solo', '0226514920');

-- --------------------------------------------------------

--
-- Table structure for table `penulis`
--

CREATE TABLE `penulis` (
  `id_penulis` int(11) NOT NULL,
  `nama_penulis` varchar(50) NOT NULL,
  `tempat_lahir` varchar(30) NOT NULL,
  `tanggal_lahir` varchar(30) NOT NULL,
  `domisili` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `penulis`
--

INSERT INTO `penulis` (`id_penulis`, `nama_penulis`, `tempat_lahir`, `tanggal_lahir`, `domisili`) VALUES
(1, 'faris', 'bandung', '14/07/1998', 'bandung'),
(2, 'teguh', 'karawang', '14/07/1998', 'bandung'),
(3, 'resky', 'karawang', '14/07/1998', 'bandung'),
(4, 'gitgit', 'tasik', '14/07/1998', 'bandung'),
(5, 'Rifqi', 'Bekasi', '08/03/1998', 'bandung'),
(6, 'Dewi Rieka', 'Makassar', '1980-04-02', 'Semarang'),
(7, 'Wardana', 'Buton', '1960-08-17', 'Bau-bau'),
(8, 'Valensius Calvin', 'Jakarta', '1975-01-20', 'Jakarta'),
(9, 'Raditya Dika', 'Jakarta', '1984-12-28', 'Jakarta'),
(10, 'Tere Liye', 'Palembang', '1979-05-21', 'Jakarta'),
(11, 'Andrea Hirata', 'Belitung Timur', '1967-10-24', 'Jakarta'),
(12, 'Asma Nadia', 'Jakarta', '1972-03-26', 'Jakarta'),
(13, 'Dewi Lestari', 'Bandung', '1976-01-20', 'Bandung'),
(14, 'Pidi Baiq', 'Bandung', '1972-08-08', 'Bandung'),
(15, 'Ahmad Fuadi', 'Maninjau', '1973-12-30', 'Jakarta'),
(17, 'Stephen Covey', 'Utah', '1932-10-24', 'Idaho'),
(18, 'A. Handoyo ', 'Bogor', '1984-03-27', 'Jakarta'),
(19, 'Ali Shariati ', 'Makassar', '1921-04-24', 'Palembang'),
(20, 'Fujiko F Fujio', 'Jepang', '1976-02-07', 'Kyoto'),
(21, 'Chappy Hakim ', 'Yogyakarta', '1982-05-03', 'Malang'),
(22, 'Claire Rayner ', 'Chicago', '1983-06-16', 'LA'),
(23, 'Andi Pramono ', 'Makassar', '1982-02-22', 'Solo'),
(24, 'Robert Powell ', 'Perancis', '1963-01-07', 'Paris'),
(25, 'Ali Shariati ', 'Jakarta', '1977-01-08', 'Bandung'),
(26, 'Dr. Ahmad Rahman, M.Ag ', 'Bali', '1985-11-18', 'Jakarta'),
(27, 'Rizki Pandu Permana ', 'Palembang', '1978-06-12', 'Bekasi'),
(28, 'Asep Sunandar', 'Rancaekek', '1932-10-20', 'Bandung'),
(29, 'Doni Ahmad', 'Bandung', '1932-8-24', 'Bandung'),
(30, 'Bayu Fuadi', 'Cimahi', '1932-9-24', 'Jakarta'),
(31, 'Budi Gunawan', 'Cicalengka', '1932-7-24', 'Jakarta'),
(32, 'Toni Suhendar', 'Jakarta', '1932-1-24', 'Bandung'),
(33, 'Siska Nadia', 'Jakarta', '1932-5-24', 'Bandung'),
(34, 'Afif Rahman', 'Bandung', '1932-3-24', 'Jakarta'),
(35, 'Tania Linda', 'Bali', '1932-10-5', 'Bandung'),
(36, 'Andre Siregar', 'Medan', '1932-10-12', 'Jakarta'),
(37, 'Agung Budi', 'Bandung', '1932-10-8', 'Jakarta'),
(38, 'Asep Sugandi', 'Subang', '1933-10-20', 'Bandung'),
(39, 'Dadang Rusyadi', 'Bandung', '1934-8-24', 'Bandung'),
(40, 'Rafi Alfath', 'Cimahi', '1935-9-24', 'Jakarta'),
(41, 'Tara Tasya', 'Cicalengka', '1936-7-24', 'Jakarta'),
(42, 'Toni Suciptor', 'Jakarta', '1937-1-24', 'Bandung'),
(43, 'Dian Siska', 'Jakarta', '1938-5-24', 'Bandung'),
(44, 'Dandi Surandi', 'Bandung', '1939-3-24', 'Jakarta'),
(45, 'Linda Amelia', 'Bali', '1940-10-5', 'Bandung'),
(46, 'Andre Sitorus', 'Medan', '1941-10-12', 'Jakarta'),
(47, 'Agung Budiman', 'Bandung', '1942-10-8', 'Jakarta');

-- --------------------------------------------------------

--
-- Table structure for table `pustakawan`
--

CREATE TABLE `pustakawan` (
  `id_pustakawan` int(11) NOT NULL,
  `nama_pustakawan` varchar(50) NOT NULL,
  `jenis_kelamin` varchar(2) NOT NULL,
  `tempat_lahir` varchar(50) NOT NULL,
  `tanggal_lahir` varchar(30) NOT NULL,
  `notelepon` varchar(20) NOT NULL,
  `alamat` varchar(500) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `stok_buku`
--

CREATE TABLE `stok_buku` (
  `id_stok` int(11) NOT NULL,
  `id_buku` int(11) NOT NULL,
  `stok` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `id_user` int(11) NOT NULL,
  `username` varchar(13) NOT NULL,
  `password` varchar(9) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`id_user`, `username`, `password`) VALUES
(1, 'admin', 'admin'),
(2, 'endou', 'endou123'),
(3, 'lisa', 'lisa123');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `anggotaperpustakaan`
--
ALTER TABLE `anggotaperpustakaan`
  ADD PRIMARY KEY (`id_anggota`);

--
-- Indexes for table `bahasa`
--
ALTER TABLE `bahasa`
  ADD PRIMARY KEY (`id_bahasa`);

--
-- Indexes for table `copy_buku`
--
ALTER TABLE `copy_buku`
  ADD PRIMARY KEY (`id_copy_buku`),
  ADD KEY `id_buku` (`id_buku`);

--
-- Indexes for table `deskripsi`
--
ALTER TABLE `deskripsi`
  ADD PRIMARY KEY (`id_deskripsi`),
  ADD KEY `id_buku` (`id_buku`);

--
-- Indexes for table `detail_peminjaman`
--
ALTER TABLE `detail_peminjaman`
  ADD PRIMARY KEY (`id_detail_peminjaman`),
  ADD KEY `id_peminjaman` (`id_peminjaman`),
  ADD KEY `id_copy_buku` (`id_copy_buku`);

--
-- Indexes for table `judulbuku`
--
ALTER TABLE `judulbuku`
  ADD PRIMARY KEY (`id_buku`),
  ADD KEY `id_penulis` (`id_penulis`),
  ADD KEY `id_bahasa` (`id_bahasa`),
  ADD KEY `id_kategori` (`id_kategori`),
  ADD KEY `id_penerbit` (`id_penerbit`);

--
-- Indexes for table `kategori`
--
ALTER TABLE `kategori`
  ADD PRIMARY KEY (`id_kategori`);

--
-- Indexes for table `peminjaman`
--
ALTER TABLE `peminjaman`
  ADD PRIMARY KEY (`id_peminjaman`);

--
-- Indexes for table `penerbit`
--
ALTER TABLE `penerbit`
  ADD PRIMARY KEY (`id_penerbit`);

--
-- Indexes for table `penulis`
--
ALTER TABLE `penulis`
  ADD PRIMARY KEY (`id_penulis`);

--
-- Indexes for table `pustakawan`
--
ALTER TABLE `pustakawan`
  ADD PRIMARY KEY (`id_pustakawan`);

--
-- Indexes for table `stok_buku`
--
ALTER TABLE `stok_buku`
  ADD PRIMARY KEY (`id_stok`),
  ADD KEY `id_buku` (`id_buku`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id_user`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `anggotaperpustakaan`
--
ALTER TABLE `anggotaperpustakaan`
  MODIFY `id_anggota` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `bahasa`
--
ALTER TABLE `bahasa`
  MODIFY `id_bahasa` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT for table `copy_buku`
--
ALTER TABLE `copy_buku`
  MODIFY `id_copy_buku` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `deskripsi`
--
ALTER TABLE `deskripsi`
  MODIFY `id_deskripsi` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=42;

--
-- AUTO_INCREMENT for table `detail_peminjaman`
--
ALTER TABLE `detail_peminjaman`
  MODIFY `id_detail_peminjaman` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `judulbuku`
--
ALTER TABLE `judulbuku`
  MODIFY `id_buku` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=45;

--
-- AUTO_INCREMENT for table `kategori`
--
ALTER TABLE `kategori`
  MODIFY `id_kategori` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=36;

--
-- AUTO_INCREMENT for table `peminjaman`
--
ALTER TABLE `peminjaman`
  MODIFY `id_peminjaman` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- AUTO_INCREMENT for table `penerbit`
--
ALTER TABLE `penerbit`
  MODIFY `id_penerbit` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=43;

--
-- AUTO_INCREMENT for table `penulis`
--
ALTER TABLE `penulis`
  MODIFY `id_penulis` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=48;

--
-- AUTO_INCREMENT for table `pustakawan`
--
ALTER TABLE `pustakawan`
  MODIFY `id_pustakawan` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `stok_buku`
--
ALTER TABLE `stok_buku`
  MODIFY `id_stok` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `id_user` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `copy_buku`
--
ALTER TABLE `copy_buku`
  ADD CONSTRAINT `copy_buku_ibfk_1` FOREIGN KEY (`id_buku`) REFERENCES `judulbuku` (`id_buku`);

--
-- Constraints for table `deskripsi`
--
ALTER TABLE `deskripsi`
  ADD CONSTRAINT `deskripsi_ibfk_1` FOREIGN KEY (`id_buku`) REFERENCES `judulbuku` (`id_buku`);

--
-- Constraints for table `detail_peminjaman`
--
ALTER TABLE `detail_peminjaman`
  ADD CONSTRAINT `detail_peminjaman_ibfk_1` FOREIGN KEY (`id_peminjaman`) REFERENCES `peminjaman` (`id_peminjaman`),
  ADD CONSTRAINT `detail_peminjaman_ibfk_2` FOREIGN KEY (`id_copy_buku`) REFERENCES `copy_buku` (`id_copy_buku`);

--
-- Constraints for table `judulbuku`
--
ALTER TABLE `judulbuku`
  ADD CONSTRAINT `judulbuku_ibfk_1` FOREIGN KEY (`id_penulis`) REFERENCES `penulis` (`id_penulis`),
  ADD CONSTRAINT `judulbuku_ibfk_2` FOREIGN KEY (`id_bahasa`) REFERENCES `bahasa` (`id_bahasa`),
  ADD CONSTRAINT `judulbuku_ibfk_3` FOREIGN KEY (`id_kategori`) REFERENCES `kategori` (`id_kategori`),
  ADD CONSTRAINT `judulbuku_ibfk_4` FOREIGN KEY (`id_penerbit`) REFERENCES `penerbit` (`id_penerbit`);

--
-- Constraints for table `stok_buku`
--
ALTER TABLE `stok_buku`
  ADD CONSTRAINT `stok_buku_ibfk_1` FOREIGN KEY (`id_buku`) REFERENCES `judulbuku` (`id_buku`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
