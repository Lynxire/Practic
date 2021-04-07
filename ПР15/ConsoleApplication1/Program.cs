using System; 
using System.Collections.Generic; 
using System.Linq; 
class Rates 
{ 
public string Titel { get; set; } 
public int Calls { get; set; } 
public Rates(string t, int c) 
{ 
Titel = t; 
Calls = c; 
} 
} 
class ATC 
{ 
List<Rates> lstCL = new List<Rates>(); 
List<Customer> lstCustomer = new List<Customer>(); 
Customer currentCust; 
public void AddRates(string t, int c) 
{ 
lstCL.Add(new Rates(t, c)); 
} 
public void AddCustomer(String f, CustomerType ct) 
{ 
lstCustomer.Add(new Customer(f, ct)); 
} 
Customer GetCustByFio(string f) 
{ 
foreach (Customer item in lstCustomer) 
{ 
if (item.Fio == f) return item; 
} 
return null; 
} 
Rates GetCLByTitle(string t) 
{ 
foreach (Rates item in lstCL) 
{ if (item.Titel == t) return item; } 
return null; 
} 
public void LogIn(string f) 
{ 
if (currentCust == null) 
currentCust = GetCustByFio(f); 
} 
public void LogOut() 
{ 
currentCust = null; 
} 

public void BuyRates(string Rates) 
{ 
Rates c = GetCLByTitle(Rates); 
currentCust.BuyRates(c); 
} 

public int GetTotalSum() 
{ 
int sum = 0; 
foreach (Customer cust in lstCustomer) 
{ 
foreach (Rates c in cust.LstCallsOfCust) 
{ 
sum += c.Calls; 
} 
} 
return sum; 
} 

public string GetRatesByName(string Fio) 
{ 
Customer cust = GetCustByFio(Fio); 
string s = "Пациент: " + cust.Fio + "\n"; 
foreach (Rates c in cust.LstCallsOfCust) 
{ 
s += c.Titel + ": " + c.Calls + "\n"; 
} 
return s; 
} 
} 

enum CustomerType { VIP, usual }; 
class Customer 
{ 
List<Rates> lstCLOfCust = new List<Rates>(); 
public List<Rates> LstCallsOfCust 
{ 
get { return lstCLOfCust; } 
} 

public String Fio { get; set; } 
public CustomerType cType { get; set; } 
public Customer(String f, CustomerType ct) 
{ 
Fio = f; 
cType = ct; 
} 

public void BuyRates(Rates c) 
{ 
lstCLOfCust.Add(c); 
} 

public int GetSum() 
{ 
int s = 0; 
foreach (Rates item in lstCLOfCust) 
{ 
s += item.Calls; 
} 
return s; 
} 
} 

class Program 
{ 
static void Main() 
{ 
ATC a = new ATC(); 
a.AddRates("Укол", 10); 
a.AddRates("Таблетка", 5); 
a.AddRates("Пластырь", 3); 
a.AddCustomer("Владислав", CustomerType.VIP); 
a.AddCustomer("Руслан", CustomerType.usual); 
a.LogIn("Владислав"); 
a.BuyRates("Укол"); 
a.BuyRates("Пластырь"); 
a.LogOut(); 
a.LogIn("Руслан"); 
a.BuyRates("Пластырь"); 
a.BuyRates("Таблетка"); 
a.LogOut(); 
Console.WriteLine("Общая стоимость дигностики: " + a.GetTotalSum()); 
Console.WriteLine(a.GetRatesByName("Владислав")); 
Console.WriteLine(a.GetRatesByName("Руслан")); 
Console.ReadKey(); 
} 
}