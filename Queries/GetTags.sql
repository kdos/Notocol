USE [NotCol]
GO
/****** Object:  StoredProcedure [dbo].[GetTags]    Script Date: 3/2/2015 1:09:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[GetTags]
	-- Add the parameters for the stored procedure here
	@userID as bigint,
	@strToSearch as varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
WITH Hierarchy(ChildId, ChildName, ParentId, Parents)
AS
(
    SELECT Id, Name, ParentId, CAST('' AS VARCHAR(MAX))
        FROM Tag AS FirtGeneration
        WHERE ParentId = 0    and UserID=@userID
    UNION ALL
    SELECT NextGeneration.Id, NextGeneration.Name, Parent.ChildId,
    CAST(CASE WHEN Parent.Parents = ''
        THEN(CAST(NextGeneration.Name AS VARCHAR(MAX)))
        ELSE(Parent.Parents + '->' + CAST(NextGeneration.Name AS VARCHAR(MAX)))
    END AS VARCHAR(MAX))
        FROM Tag AS NextGeneration
        INNER JOIN Hierarchy AS Parent ON NextGeneration.ParentId = Parent.ChildId    
		where UserID = @userID
)
SELECT *
    FROM Hierarchy
OPTION(MAXRECURSION 32767)

select * from Tag
where UserID = 2
END
