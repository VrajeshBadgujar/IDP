namespace MinimalAPIDemo;

public static class Api
{
    public static void ConfigureApi(this WebApplication app)
    {
		//All of my API endpoints mapping
		app.MapGet("/Users", GetUsers);
		app.MapGet("/Users/{id}", GetUser);
		app.MapPost("/Users", InsertUser);
		app.MapPut("Users", UpdateUser);
		app.MapDelete("Users", DeleteUser);

    }

    private static async Task<IResult> GetUsers(IUserData data)
    {
		try
		{  
			var list = data.GetUsers();
			Console.WriteLine("This is reached here at get users");
			
            return Results.Ok(list);
		}
		catch (Exception ex)
		{

			return Results.Problem("The getusers api hited");
		}
    }

	private static async Task<IResult>GetUser(int id, IUserData data)
	{
		try
		{
			var results = await data.GetUser(id);
			if(results == null) return Results.NotFound();
			return Results.Ok(results);
        }
		catch (Exception ex)
		{

			return Results.Problem(ex.Message);
		}
	}

	private static async Task<IResult>InsertUser(UserModel user, IUserData data)
	{
        try
        {
           await data.InsertUser(user);
		    return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem("Insert api hited");
        }
    }

	private static async Task<IResult>UpdateUser(UserModel user,
		IUserData data)
	{
		try
		{
			await data.UpdateUser(user);
			
			return Results.Ok();
		}
		catch (Exception ex)
		{

			return Results.Problem(ex.Message);
		}
	}

	private static async Task<IResult> DeleteUser(int id, 
		IUserData data)
	{
		try
		{
			await data.DeleteUser(id);
			return Results.Ok();
		}
		catch (Exception ex)
		{

            return Results.Problem(ex.Message);
        }
	}

}
