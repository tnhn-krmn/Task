// See https://aka.ms/new-console-template for more information
using ConsoleApp;

Console.WriteLine("Hello, World!");

var tcNo = new TCKN("11111111111");

var kisi = new GercekKisi(tcNo, "tuna","sada","asdasdas");

var vkn = new VKN("11111111111");



var tuzelKisiListesi = new List<GercekKisi> { kisi };
var tckn = "11111111111";
var tuzelKisi = new TuzelKisi(vkn, "Mühendis", "adasdadas", tuzelKisiListesi);
//var tuzel

Console.WriteLine($"{TuzelKisiFormatter.Format(tuzelKisi)} - yeni kisi");