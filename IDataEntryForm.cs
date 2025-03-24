namespace coursework
{
	public interface IDataEntryForm<T>
	{
		void SetData(T data);
		T? ShowDialogAndGetResult();
	}
}
