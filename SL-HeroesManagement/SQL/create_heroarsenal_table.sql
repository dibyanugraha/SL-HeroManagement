if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[xtHeroArsenal]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[xtHeroArsenal]
GO

CREATE TABLE [dbo].[xtHeroArsenal](
	[HeroID] [char](10) NOT NULL,
	[ID] [char](30) NOT NULL,
	[Description] [char](60) NOT NULL,
	[ProdClassID] [char](6) NOT NULL,
	[UOM] [char](6) NOT NULL,
	[CpnyID] [char](10) NOT NULL,
	[tstamp] [timestamp] NOT NULL,
 CONSTRAINT [xtHeroArsenal0] PRIMARY KEY CLUSTERED 
(
	[CpnyID] ASC,
	[HeroID] ASC,
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


