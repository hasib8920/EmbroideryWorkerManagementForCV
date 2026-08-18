using EmbroideryWorkerManagement.Interfaces;
using EmbroideryWorkerManagement.Models;
using EmbroideryWorkerManagement.Repositories;
using EmbroideryWorkerManagement.Services.Interfaces;
using EmbroideryWorkerManagement.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// PostgreSQL connection: UseNpgsql & connection string "DefaultConnection"
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<IWorkerService, WorkerService>();
builder.Services.AddScoped<IAttendanceService, AttendanceService>();
builder.Services.AddScoped<IAdvanceSalaryService, AdvanceSalaryService>();
builder.Services.AddScoped<IHolidayService, HolidayService>();
builder.Services.AddScoped<IMachineWorkService, MachineWorkService>();
builder.Services.AddScoped<IMonthlyTargetService, MonthlyTargetService>();


builder.Services.AddScoped<PaymentSlipPdfService>();
builder.Services.AddScoped<MonthlyPaymentService>();
builder.Services.AddScoped<AutoSalaryGenerator>();
builder.Services.AddScoped<ISalaryCalculationService, SalaryCalculationService>();

var app = builder.Build();

// Apply migrations automatically on startup (Optional, but useful)
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    db.Database.Migrate();
}

// Configure middleware pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Dashboard}/{action=Index}/{id?}");

app.Run();
