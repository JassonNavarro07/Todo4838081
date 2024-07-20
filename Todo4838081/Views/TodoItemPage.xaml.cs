using Todo4838081.Data;
using Todo4838081.Models;
namespace Todo4838081.Views;


[QueryProperty("Item", "Item")]
public partial class TodoItemPage : ContentPage
{
    TodoItem item;


    public TodoItem Item
    {
        get => BindingContext as TodoItem;
        set => BindingContext = value;
    }
    TodoItemDatabase database;
	public TodoItemPage(TodoItemDatabase todoItemDatabase)
	{
		InitializeComponent();
        database = todoItemDatabase;
	}

    private async void OnSaveCliecked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(item.Name))
        {
            await DisplayAlert("Name Required", "Please enter a name for the todo item", "OK");
        }

        await database.SaveItemAsync(item);
        await Shell.Current.GoToAsync("..");
    }

    private async void OnDeleteCliecked(object sender, EventArgs e)
    {
        if(Item.ID == 0)
            return;
        await database.DeleteItemAsync(Item);
        await Shell.Current.GoToAsync("..");
    }

    private async void OnCancelCliecked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}