public interface IRequestableUIView
{
	void Request(object requester);
	void RemoveRequest(object requester);
}
