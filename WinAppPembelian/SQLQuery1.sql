create database dbpembelian

create table jenis(
id_jenis varchar(10) primary key,
jenis varchar(20)
)

create table bahan(
id_bahan varchar(10) primary key,
bahan varchar(20)
)

create table barang(
id_barang int identity(1,1) primary key,
nama varchar(50),
id_jenis varchar(10) references jenis(id_jenis) ,
id_bahan varchar(10) references bahan(id_bahan),
harga_pokok money,
keterangan varchar(50)
)

