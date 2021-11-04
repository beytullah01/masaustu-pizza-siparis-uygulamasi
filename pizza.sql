-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1:3306
-- Üretim Zamanı: 06 Oca 2021, 19:54:56
-- Sunucu sürümü: 5.7.31
-- PHP Sürümü: 7.3.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `pizza`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `admin`
--

DROP TABLE IF EXISTS `admin`;
CREATE TABLE IF NOT EXISTS `admin` (
  `admin` varchar(10) COLLATE utf8mb4_turkish_ci NOT NULL,
  `admin_sifre` varchar(10) COLLATE utf8mb4_turkish_ci NOT NULL,
  `admin_id` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`admin_id`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

--
-- Tablo döküm verisi `admin`
--

INSERT INTO `admin` (`admin`, `admin_sifre`, `admin_id`) VALUES
('admin', '12345', 1);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `musteri`
--

DROP TABLE IF EXISTS `musteri`;
CREATE TABLE IF NOT EXISTS `musteri` (
  `musteri_id` int(11) NOT NULL AUTO_INCREMENT,
  `musteri_adsoyad` varchar(100) COLLATE utf8mb4_turkish_ci NOT NULL,
  `musteri_telefon` varchar(100) COLLATE utf8mb4_turkish_ci NOT NULL,
  `musteri_adres` varchar(300) COLLATE utf8mb4_turkish_ci NOT NULL,
  `siparis_ozet` varchar(500) COLLATE utf8mb4_turkish_ci NOT NULL,
  `siparis_tutar` float NOT NULL,
  `siparis_tarih` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`musteri_id`)
) ENGINE=InnoDB AUTO_INCREMENT=52 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

--
-- Tablo döküm verisi `musteri`
--

INSERT INTO `musteri` (`musteri_id`, `musteri_adsoyad`, `musteri_telefon`, `musteri_adres`, `siparis_ozet`, `siparis_tutar`, `siparis_tarih`) VALUES
(10, 'bzokurt', '56357868629', 'adanaaaaa', '', 0, '2020-12-28 19:01:21'),
(11, 'adad', '5678', 'hadhahdhad', '', 0, '2020-12-28 19:01:21'),
(12, 'bozkurt', '5357868629', 'beyceli mahallesi', '', 0, '2020-12-28 19:01:21'),
(13, 'bb', '565748', 'karaca', '', 0, '2020-12-28 19:01:21'),
(14, 'fghj', 'hgujhbjkj', 'adresss', '', 0, '2020-12-28 19:01:21'),
(15, 'buyuk', '783838', 'adajdjada', 'AKDENIZ', 0, '2020-12-28 19:01:21'),
(16, 'buyuk', '783838', 'adajdjada', 'PATSO', 0, '2020-12-28 19:01:21'),
(17, 'elif', '523536', 'isparta', 'VEJETERRAInce', 0, '2020-12-28 19:01:21'),
(18, 'beytullah', '05357868619', 'ahdhahhdahd', 'Klasik', 60, '2020-12-28 19:01:21'),
(19, 'ada', '53552', 'adna ', 'Klasik', 60, '2020-12-28 19:01:21'),
(20, 'beytullah', '5357868629', 'adana seyhan', 'PATSOorta boyIncePeynir kenarTrueTrueTrue', 35, '2020-12-28 19:01:21'),
(21, 'beytullah', '5070981711', 'dana beyceli mahallesi 3561sokak ev no 3', 'AKDENIZorta boyIncePeynir kenarzeytinsalamsucuk', 30, '2020-12-28 19:01:21'),
(22, 'ali', '6363', 'beytullahahdhahda', 'AKDENIZorta boyIncePeynir kenarzeytinsalamsucuk', 30, '2020-12-28 19:01:21'),
(23, 'ali', '6363', 'beytullahahdhahda', 'AKDENIZbüyük boyIncePeynir kenarzeytinsalamsucuk', 30, '2020-12-28 19:01:21'),
(24, 'ali', '6363', 'beytullahahdhahda', 'AKDENIZbüyük boyKlasikSimit kenarzeytinsalamsucuk', 30, '2020-12-28 19:01:21'),
(25, 'orhan', '02123562363', 'ankara meydan', 'VEJETERRAorta boyIncePeynir kenarzeytinsalamsucuk', 25, '2020-12-28 19:01:21'),
(26, 'fatih', '53569633', 'kirklarlei merkez', 'AKDENIZorta boyIncePeynir kenarzeytinsalamsucuk', 25, '2020-12-28 19:01:21'),
(27, 'ahmet', '53562', 'tellider', 'PATSOorta boyIncePeynir kenarzeytinsalamsucuk', 25, '2020-12-28 19:01:21'),
(28, 'faith', '53653652', 'denizli mahallesi', 'AKDENIZorta boyIncePeynir kenarzeytinsalamsucuk', 40, '2020-12-28 19:01:21'),
(29, 'bugra', '5356223', 'adana ', 'AKDENIZorta boyIncePeynir kenarzeytinsalamsucuk', 30, '2020-12-28 19:01:21'),
(30, 'bugra', '5356223', 'adana ', 'AKDENIZorta boyIncePeynir kenarzeytinsalamsucuk', 30, '2020-12-28 19:01:21'),
(31, 'bugra', '5356223', 'adana ', 'AKDENIZorta boyIncePeynir kenarzeytinsalamsucuk', 30, '2020-12-28 19:01:21'),
(32, 'ramazan', '5356633', 'maras', 'AKDENIZorta boyIncePeynir kenarzeytinsalamsucuk', 25, '2020-12-28 19:02:08'),
(33, 'beytullah', '5357868629', 'kirklareli merkez karacaibrahim mahallesi', 'PATSOorta boyIncePeynir kenarzeytinsalamsucuk', 55, '2020-12-29 15:32:54'),
(34, 'mahmut', '05357868629', 'adana', 'PATSOorta boyIncePeynir kenarzeytinsalamsucuk', 30, '2020-12-29 17:57:26'),
(35, 'mahmut', '05357868629', 'adana', 'PATSOorta boyIncePeynir kenarzeytinsalamsucuk', 30, '2020-12-29 17:59:13'),
(36, 'seval', '5382881870', 'adana kozan', 'AKDENIZorta boyIncePeynir kenarzeytinsalamsucuk', 30, '2020-12-29 18:13:14'),
(37, 'seval', '5382881870', 'adana kozan', 'AKDENIZorta boyIncePeynir kenarzeytinsalamsucuk', 30, '2020-12-29 18:13:17'),
(38, 'seval', '5382881870', 'adana kozan', 'AKDENIZorta boyIncePeynir kenarzeytinsalamsucuk', 30, '2020-12-29 18:13:18'),
(39, 'seval', '5382881870', 'adana kozan', 'AKDENIZorta boyIncePeynir kenarzeytinsalamsucuk', 30, '2020-12-29 18:13:18'),
(40, 'seval', '5382881870', 'adana kozan', 'AKDENIZorta boyIncePeynir kenarzeytinsalamsucuk', 30, '2020-12-29 18:13:18'),
(41, 'seval', '5382881870', 'adana kozan', 'AKDENIZorta boyIncePeynir kenarzeytinsalamsucuk', 30, '2020-12-29 18:13:19'),
(42, 'seval', '5382881870', 'adana kozan', 'AKDENIZorta boyIncePeynir kenarzeytinsalamsucuk', 30, '2020-12-29 18:13:19'),
(43, 'seval', '5382881870', 'adana kozan', 'AKDENIZorta boyIncePeynir kenarzeytinsalamsucuk', 30, '2020-12-29 18:13:50'),
(44, 'seval', '5382881870', 'adana kozan', 'AKDENIZorta boyIncePeynir kenarzeytinsalamsucuk', 30, '2020-12-29 18:13:50'),
(45, 'beytullah', '5357868629', 'adnaaaa', 'AKDENIZorta boyInceSimit kenarzeytinsalamsucuk', 25, '2020-12-29 18:25:48'),
(46, 'ramiz', '535869', 'cezaevi', 'PATSOorta boyIncePeynir kenarzeytinsalamsucuk', 30, '2020-12-29 18:28:03'),
(47, 'ramiz', '535786269', 'cezaevi', 'PATSOorta boyIncePeynir kenarzeytinsalamsucuk', 100, '2020-12-29 18:30:32'),
(48, 'cengiz', '52020', 'roma', 'PATSObüyük boyIncePeynir kenarzeytinsalamsucuk', 150, '2020-12-29 18:35:47'),
(49, 'cengiz', '52020', 'roma', 'PATSObüyük boyIncePeynir kenarzeytinsalamsucuk', 150, '2020-12-29 18:36:40'),
(50, 'ADANALIII', '636464', 'AHDHAHDA', 'VEJETERRAorta boyKlasikPeynir kenarzeytinsalamsucuk', 30, '2020-12-29 18:40:21'),
(51, 'mehme', '555', 'asdasd', 'PATSObüyük boyIncePeynir kenarzeytinsalamsucuk', 30, '2020-12-29 20:06:14');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `siparisler`
--

DROP TABLE IF EXISTS `siparisler`;
CREATE TABLE IF NOT EXISTS `siparisler` (
  `siparis_id` int(11) NOT NULL AUTO_INCREMENT,
  `s_musteri_adsoyad` varchar(100) COLLATE utf8mb4_turkish_ci NOT NULL,
  `s_musteri_telefon` varchar(50) COLLATE utf8mb4_turkish_ci NOT NULL,
  `s_musteri_adres` varchar(500) COLLATE utf8mb4_turkish_ci NOT NULL,
  `s_pizzalar` varchar(100) COLLATE utf8mb4_turkish_ci NOT NULL,
  `s_hamur_tipi` varchar(100) COLLATE utf8mb4_turkish_ci NOT NULL,
  `s_adet` int(11) NOT NULL,
  `s_tutar` varchar(100) COLLATE utf8mb4_turkish_ci NOT NULL,
  `s_pizza_icerik` varchar(100) COLLATE utf8mb4_turkish_ci DEFAULT NULL,
  `s_kenartipi` varchar(50) COLLATE utf8mb4_turkish_ci NOT NULL,
  `s_tarihi` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`siparis_id`)
) ENGINE=MyISAM AUTO_INCREMENT=64 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

--
-- Tablo döküm verisi `siparisler`
--

INSERT INTO `siparisler` (`siparis_id`, `s_musteri_adsoyad`, `s_musteri_telefon`, `s_musteri_adres`, `s_pizzalar`, `s_hamur_tipi`, `s_adet`, `s_tutar`, `s_pizza_icerik`, `s_kenartipi`, `s_tarihi`) VALUES
(57, 'ramo onat', '53623', 'ahjjdhhad', 'AKDENIZ', 'Ince', 2, '60', 'kasarzeytin ', 'Peynir kenar', '2021-01-06 16:25:55'),
(60, 'polat alemdar', '911', 'istanbul cerrahpasa kahvehanesi.', 'AKDENIZ', 'Ince', 9, '270', 'zeytinsucuk', 'Peynir kenar', '2021-01-06 16:57:35'),
(61, 'memati bas', '155', 'istanbul merkez', 'PATSO', 'Klasik', 2, '120', 'zeytinsalamsucuk', 'Simit kenar', '2021-01-06 16:59:48');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
