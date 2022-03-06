namespace MinimanAPIDemo.API;

public static class User
{
    public static void ConfigureUserAPI(this WebApplication app)
    {
        app.MapGet(pattern: "/GetUsers", GetUsers);
        app.MapGet(pattern: "/GetUser/{id}", GetUser);
        app.MapPost(pattern: "/InsertUser", InsertUser);
        app.MapPut(pattern: "/UpdateUser", UpdateUser);
        app.MapDelete(pattern: "/DeleteUser", DeleteUser);
    }

    private static async Task<IResult> GetUsers(IUserData userData)
    {
        try
        {
            return Results.Ok(await userData.GetUsers());
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> GetUser(int id, IUserData userData)
    {
        try
        {
            var user = await userData.GetUser(id);
            if (user == null)
            return Results.Ok(user);
            return Results.NotFound(user);
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }
    private static async Task<IResult> InsertUser(UserModel userModel,IUserData userData)
    {
        try
        {
            await userData.Insert(userModel);
            return Results.Ok(userModel);
        }
        catch (Exception exp)
        {

            return Results.Problem(exp.Message);
        }
    }
    private static async Task<IResult> UpdateUser(UserModel userModel, IUserData userData)
    {
        try
        {
            await userData.Update(userModel);
            return Results.Ok(userModel);
        }
        catch (Exception exp)
        {

            return Results.Problem(exp.Message);
        }
    }

    private static async Task<IResult> DeleteUser(int id, IUserData userData)
    {
        try
        {
            await userData.DeleteUser(id);
           
                return Results.Ok("User has been deleted");
           
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }
}

