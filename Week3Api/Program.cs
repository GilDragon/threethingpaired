var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();



app.MapGet("/add", () => getNum());
app.MapGet("/add/{lowernumb}/{uppernumb}", (int lowernumb, int uppernumb) => getNum2(lowernumb, uppernumb));




    
int getNum(){
    Random numb = new Random();
    int num = numb.Next(1,100);
    return num;
}

int getNum2(int lowernumb, int uppernumb){
    Random numb = new Random();
    int num = numb.Next(lowernumb, uppernumb);
    return num;
}
app.Run();