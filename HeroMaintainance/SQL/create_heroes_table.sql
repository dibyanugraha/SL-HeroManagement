/****** Object:  Table [dbo].[xtHero]    Script Date: 21/03/2019 11:35:16 ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[xtHero]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[xtHero]
GO


SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[xtHero](
	[ID] [char](10) NOT NULL,
	[Name] [char](50) NOT NULL,
	[Type] [char](1) NOT NULL,
	[CpnyID] [char](10) NOT NULL,
	[tstamp] [timestamp] NOT NULL
) ON [PRIMARY]
GO


 CREATE  UNIQUE  CLUSTERED  INDEX [xtHero0] ON [dbo].[xtHero]([ID]) ON [PRIMARY]
GO
