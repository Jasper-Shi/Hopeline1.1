EXEC(
	'CREATE procedure [dbo].[SetResourceCategoryEnableFlg] @id int, @flg int
as
begin
	set nocount on
	update resource_categories set enable_flg=@flg
	where id=@id
end'
);