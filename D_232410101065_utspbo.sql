

CREATE TABLE buku (
    id SERIAL PRIMARY KEY,
    judul VARCHAR(100) NOT NULL,
    pengarang VARCHAR(100) NOT NULL,
    tahun_terbit VARCHAR (4) NOT NULL);
select * from buku	
select * from pengguna

-- Menambahkan data ke tabel mahasiswa
INSERT INTO buku (judul, pengarang, tahun_terbit) VALUES
('Laut Bercerita', 'Tere Liye', '2019');

CREATE TABLE pengguna (
	id SERIAL PRIMARY KEY,
	username VARCHAR(100) NOT NULL,
	password_user VARCHAR(10) NOT NULL
);

INSERT INTO pengguna (username, password_user) VALUES
('ADMINLIBRARY', 'bacabuku');

CREATE TABLE role_user (
	id SERIAL PRIMARY KEY,
	nama_role VARCHAR(10) NOT NULL
);

