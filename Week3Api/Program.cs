var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/add", () => getNum()); 

app.Run();


app.MapGet("/add{lowernumb}}/{uppernumb}", (int 0, int 100) => getNum(0, 100));
    
// int getNum(){
//     Random numb = new Random();
//     int num = numb.Next(1,100);
//     return num;
// }

int getNum(){
    Random numb = new Random();
    int num = numb.Next(lowernumb,uppernumb);
    return num;
}