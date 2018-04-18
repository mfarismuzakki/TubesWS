create database perpustakaan;
use perpustakaan;

create table penulis(
	id_penulis int primary key AUTO_INCREMENT,
	nama_penulis varchar(50) not null,
	tempat_lahir varchar(30) not null,
	tanggal_lahir varchar(30) not null,
	domisili varchar(30) not null
); 

	insert into penulis values(null,'faris','bandung','14/07/1998','bandung');
	insert into penulis values(null,'teguh','karawang','14/07/1998','bandung');
	insert into penulis values(null,'resky','karawang','14/07/1998','bandung');
	insert into penulis values(null,'gitgit','tasik','14/07/1998','bandung');
	insert into penulis values(null,'Rifqi','Bekasi','08/03/1998','bandung');




create table kategori(
	id_kategori int primary key AUTO_INCREMENT,
	nama_kategori varchar(30) not null
);

create table bahasa(
	id_bahasa int primary key AUTO_INCREMENT,
	nama_bahasa varchar(50) not null
);

create table penerbit(
	id_penerbit int primary key AUTO_INCREMENT,
	nama_penerbit varchar(50) not null,
	lokasipercetakan varchar(50) not null,
	notelepon varchar(20) not null 
);

create table judulbuku(
	id_buku int primary key AUTO_INCREMENT,
	judul_buku varchar(50) not null,
	cetakan int not null,
	tanggalterbit varchar(30) not null,
	id_penulis int not null,
	id_penerbit int not null,
	id_bahasa int not null,
	id_kategori int not null,

	foreign key (id_penulis) references penulis(id_penulis),
	foreign key (id_bahasa) references bahasa(id_bahasa),
	foreign key (id_kategori) references kategori(id_kategori),
	foreign key (id_penerbit) references penerbit(id_penerbit)
);

create table deskripsi(
	id_deskripsi int primary key AUTO_INCREMENT,
	isi varchar(500) not null,
	id_buku int not null,
	foreign key (id_buku) references judulbuku(id_buku)
);

