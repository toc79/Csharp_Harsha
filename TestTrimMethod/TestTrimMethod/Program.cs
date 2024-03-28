using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using static System.Collections.Specialized.BitVector32;

namespace TestTrimMethod
{
	public class Test
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Reg_stev { get; set; }
	}
	
	[Serializable]
	public class Pair <T1, T2> 
	{
		public T1 First { get; set; }
		public T2 Second { get; set; }
	}

	
	class Program
	{
		static void Main()
		{
			List<Test> test2; 

			
			Test test = new Test() {Id = 1, Name = "Štef   ", Reg_stev = "ZG1111" };

			Console.WriteLine("ispis: " +test.Name.ToString().Trim() + ", ID: " + test.Id );
			
			FillMapping();

			var sifre_polica = (from t in test2
								where t.Id == 22
								select t).FirstOrDefault();
			Console.WriteLine("testiranje from t in test2 where ...: " + sifre_polica.Id);

			Ispis();

			//ovaj type cast javlja grešku
			//var sifre_polica2 = (List<Test>)(from t in test2
			//					//where t.Id == 22
			//					select t).Select(x => x.Id).Distinct() ;

			var sifre_polica2 = (from t in test2
									//where t.Id == 22
								select t).Select(x => x.Id).Distinct();

			foreach (var item in sifre_polica2 )
			{
				Console.WriteLine("Sifre_polica 2 Distinct = " + item);// + ": " + item.Name);
			}

			void FillMapping()
			{
				test2 = new List<Test> { new Test() { Id = 21, Name = "Joža", Reg_stev = "ZG-21" }
				, new Test() { Id = 22, Name = "Bara", Reg_stev = "ZG-22" }
				, new Test() { Id = 22, Name = "Bara2", Reg_stev = "ZG-22-2" }
				, new Test() { Id = 23, Name = "Bara3", Reg_stev = "ZG-23" }
				} ;
			}


			void Ispis() {

				foreach (Test item in test2)
				{
					Console.WriteLine("ispis 2: " + item.Name + ", ID: " + item.Id + ", Reg_stev: " +item.Reg_stev);
				}
			}


			int id_cont = 22;

			string id_zapo, reg_stev;
			GetId_zapo(id_cont, out id_zapo, out reg_stev);
			Console.WriteLine("Id_zapo: " +id_zapo);
			Console.WriteLine("Reg_stev: " + reg_stev);

			
			// ovo radi  s dva out parametra i objekt dodijeljen string varijablama 
			void GetId_zapo(int id_cont2, out string id_zapo2, out string reg_stev2 )
			{
				var zapisniki = (from t in test2
								 where t.Id == id_cont2
								 select t).FirstOrDefault();
				id_zapo2 = zapisniki.Name;
				reg_stev2 = zapisniki.Reg_stev;
			}

			//Pair<string, string> GetId_zapo2 (int id_cont2)
			//{
			//	var zapisniki = (from t in test2
			//					 where t.Id == id_cont2
			//					 select t).FirstOrDefault();
			//	string nesto = (string)zapisniki.Name;
			//	string nesto2 = zapisniki.Reg_stev;

			//	//Pair<string, string> zapisnik = new Pair<string, string>() { zapisniki.Name, zapisniki.Reg_stev }; ne može

			//	//idDavSt = Tab_VrstTer.CreateQuery().IsEqual(Tab_VrstTer.Columns.id_terj, "31").GetList(session).FirstOrDefault()?.id_dav_st.Trim() ?? string.Empty;
			//	string name = (from t in test2
			//					 where t.Id == id_cont2
			//					 select t).FirstOrDefault().Name;
				




			//	return zapisnik;
			//}

			Console.ReadKey();
		}
	}
}
