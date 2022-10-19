var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();



app.MapGet("/add", () => getNum());
app.MapGet("/add/{lowernumb}/{uppernumb}", (int lowernumb, int uppernumb) => getNum2(lowernumb, uppernumb));
app.MapGet("/exp/{base1}/{exp}", (int base1, int exp) => getNum3(base1, exp));


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

int getNum3(int base1, int exp) {

    var totalnum = 1;

    for 
        (int i= 0; i < exp; i++) {

    totalnum = totalnum* base1;
    }

    return totalnum;
}
app.Run();