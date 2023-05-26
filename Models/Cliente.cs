using System.ComponentModel.DataAnnotations;

namespace Ceiberapp.Backend.Api.Models
{
    public class Cliente
    {
        [Key]
        public Guid gIdCliente { get; set; }
        public Guid gIdEmpresa { get; set; }
        public Guid gIdUsuario { get; set; }    
        public string? sPrimerNombre { get; set; }
        public string? sSegundoNombre { get; set; }
        public string? sApellidoPaterno { get; set; }
        public string? sApellidoMaterno { get; set; }
        public string? sTipoDocumento { get; set; }
        public string? sNumeroDocumento { get; set; }
        public string? sCorreo { get; set; }
        public string? sDireccion { get; set; }
        public string? sDistrito { get; set; }
        public string? sProvincia { get; set; }
        public string? sDepartamento { get; set; }
        public string? sCelular1 { get; set; }
        public string? sCelular2 { get; set; }
        public string? sTelefono { get; set; } 
        public string? FLAG_CASADO { get; set; }
        public Guid? gIdClienteConyuge { get; set; }
        public string? sApellidosNombres { get; set; }
    }
}

/*
 -- ceiberapp.dbo.CLIENTES definition

-- Drop table

-- DROP TABLE ceiberapp.dbo.CLIENTES;

CREATE TABLE ceiberapp.dbo.CLIENTES (
	gIdCliente			uniqueidentifier NOT NULL,
	gIdEmpresa			uniqueidentifier NULL,
	gIdUsuario			uniqueidentifier NULL,
	sPrimerNombre		varchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	sSegundoNombre		varchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	sApellidoPaterno	varchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	sApellidoMaterno	varchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	sTipoDocumento		varchar(2) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	sNumeroDocumento	varchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	sCorreo				varchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	sDireccion			varchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	sDistrito			varchar(6) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	sProvincia			varchar(6) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	sDepartamento		varchar(6) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	sCelular1			varchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	sCelular2			varchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	sTelefono			varchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	FLAG_CASADO			varchar(1) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	gIdClienteConyuge	uniqueidentifier NULL,
	sApellidosNombres	varchar(400) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	CONSTRAINT pk_clientes PRIMARY KEY (gIdCliente)
);


-- ceiberapp.dbo.CLIENTES foreign keys

ALTER TABLE ceiberapp.dbo.CLIENTES ADD CONSTRAINT fk_clientesConyuge FOREIGN KEY (gIdClienteConyuge) REFERENCES ceiberapp.dbo.CLIENTES(gIdCliente);
ALTER TABLE ceiberapp.dbo.CLIENTES ADD CONSTRAINT fk_clientesEmpresa FOREIGN KEY (gIdEmpresa) REFERENCES ceiberapp.dbo.EMPRESAS(gIdEmpresa);
ALTER TABLE ceiberapp.dbo.CLIENTES ADD CONSTRAINT fk_clientesUsuario FOREIGN KEY (gIdUsuario) REFERENCES ceiberapp.dbo.USUARIOS(gIdUsuario);
 */