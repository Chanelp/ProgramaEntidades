CREATE DATABASE SellPoint
use SellPoint

CREATE TABLE GruposEntidades
( 
  IdGrupoEntidad INT IDENTITY(1,1) PRIMARY KEY,
  Descripcion varchar(120),
  Comentario text,
  Status varchar(10) DEFAULT 'Activa',
  NoEliminable bit DEFAULT 0,
  FechaRegistro datetime DEFAULT GETDATE()
);

CREATE TABLE TiposEntidades
( IdTipoEntidad INT IDENTITY(1,1) PRIMARY KEY,
  Descripcion varchar(120),
  IdGrupoEntidad INT foreign key references GruposEntidades(IdGrupoEntidad),
  Comentario text,
  Status varchar(10) DEFAULT 'Activa' ,
  NoEliminable bit DEFAULT 0 ,
  FechaRegistro date  DEFAULT GETDATE()
);
CREATE TABLE Entidades
( IdEntidad INT IDENTITY(1,1) PRIMARY KEY,
  Descripcion varchar(120),
  Direccion text,
  Localidad varchar(40),
  TipoEntidad varchar(8),
  TipoDocumento varchar(9) default 'Jurídica',
  NumeroDocumento varchar(15) default 'RNC',
  Teléfonos varchar(60),
  URLPaginaWeb varchar(120),
  URLFacebook varchar(120),
  URLInstagram varchar(120),
  URLTwitter varchar(120),
  URLTikTok varchar(120),
  IdGrupoEntidad int foreign key references GruposEntidades(IdGrupoEntidad),
  IdTipoEntidad int foreign key references TiposEntidades(IdTipoEntidad),
  LimiteCredito numeric(15,2),
  UserNameEntidad varchar(60),
  PassworEntidad varchar(30),
  RolUserEntidad varchar(10),
  Comentario text,
  Status varchar(10) DEFAULT 'Activa' ,
  NoEliminable bit DEFAULT 0,
  FechaRegistro date DEFAULT GETDATE(),
);