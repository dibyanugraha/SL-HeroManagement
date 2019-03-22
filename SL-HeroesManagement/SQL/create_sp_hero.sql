SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER OFF
GO

create procedure [dbo].[xpHero_all]
	@parm1 char(10)
AS
Select * 
	From xtHero 
	Where HeroID like @parm1 
	order by HeroID

GO