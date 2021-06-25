CREATE PROCEDURE [dbo].[BFSP_DeleteCategory]
	@Id int
AS
BEGIN
	DELETE FROM [Category] WHERE Id = @Id;
	RETURN 0
END
