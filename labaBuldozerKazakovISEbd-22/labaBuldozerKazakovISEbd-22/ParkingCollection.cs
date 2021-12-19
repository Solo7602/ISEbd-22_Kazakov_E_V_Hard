using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace labaBuldozerKazakovISEbd_22
{
    public class ParkingCollection
    {
        readonly Dictionary<string, Parking<VehicleBuldozer, SimpleWheel>> parkingStages;
        public List<string> Keys => parkingStages.Keys.ToList();
        private readonly int pictureWidth;
        private readonly int pictureHeight;
        public ParkingCollection(int pictureWidth, int pictureHeight)
        {
            parkingStages = new Dictionary<string, Parking<VehicleBuldozer, SimpleWheel>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;                                     
        }
        private readonly char separator = ':';
        public void AddParking(string name)
        {
            if (!parkingStages.ContainsKey(name))
            {
                parkingStages.Add(name, new Parking<VehicleBuldozer, SimpleWheel>(pictureWidth, pictureHeight));
            }
        }
        public void DelParking(string name)
        {
            if (parkingStages.ContainsKey(name))
            {
                parkingStages.Remove(name);
            }
        }
        public Parking<VehicleBuldozer, SimpleWheel> this[string ind]
        {
            get
            {
                    return parkingStages[ind];
            }
        }
        public VehicleBuldozer this[string ind, int ind2]
        {
            get
            {
                return parkingStages[ind][ind2];
            }
        }
		public void SaveData(string filename)
		{
			if (File.Exists(filename))
			{
				File.Delete(filename);
			}
			using (StreamWriter sw = new StreamWriter(filename))
			{
				sw.Write($"ParkingCollection{Environment.NewLine}");
				foreach (var level in parkingStages)
				{
					//Начинаем парковку
					sw.Write($"Parking{separator}{level.Key}{Environment.NewLine}");
					foreach (IBulldozer buldozer in level.Value)
					{
						//Записываем тип машины
						if (buldozer.GetType().Name == "BuldozerBase")
						{
							sw.Write($"BuldozerBase{separator}");
						}
						if (buldozer.GetType().Name == "ModBuldozer")
						{
							sw.Write($"ModBuldozer{separator}");
						}
						//Записываемые параметры
						sw.Write(buldozer + Environment.NewLine);
					}
				}
			}
		}
		public void LoadData(string filename)
		{
			if (!File.Exists(filename))
			{
				throw new FileNotFoundException();
			}
			string bufferTextFromFile = "";
			using (StreamReader sr = new StreamReader(filename))
			{
				bufferTextFromFile = sr.ReadLine();
				if (bufferTextFromFile.Contains("ParkingCollection"))
				{
					//очищаем записи
					parkingStages.Clear();
				}
				else
				{
					throw new FileLoadException("Неверный формат файла");
				}
				VehicleBuldozer buldozer = null;
				string key = string.Empty;
				while(!sr.EndOfStream)
				{
					//идем по считанным записям
					bufferTextFromFile = sr.ReadLine();
					if (bufferTextFromFile.Contains("Parking"))
					{
						key = bufferTextFromFile.Split(separator)[1];
						parkingStages.Add(key, new Parking<VehicleBuldozer, SimpleWheel>(pictureWidth, pictureHeight));
						continue;
					}
					if (string.IsNullOrEmpty(bufferTextFromFile))
					{
						continue;
					}
					if (bufferTextFromFile.Split(separator)[0] == "BuldozerBase")
					{
						buldozer = new BuldozerBase(bufferTextFromFile.Split(separator)[1]);
					}
					else if (bufferTextFromFile.Split(separator)[0] == "ModBuldozer")
					{
						buldozer = new ModBuldozer(bufferTextFromFile.Split(separator)[1]);
					}
					var result = parkingStages[key] + buldozer;
					if (!result)
					{
						throw new FileLoadException("Не удалось загрузить автомобиль на парковку");
					}
				}
			}
		}
		public void SaveDataPark(string filename, string name)
		{
			if (File.Exists(filename))
			{
				File.Delete(filename);
			}
			using (StreamWriter sw = new StreamWriter(filename))
			{
				sw.Write($"Park{Environment.NewLine}");
					//Начинаем парковку
					sw.Write($"Parking{separator}{name}{Environment.NewLine}");
				foreach (IBulldozer buldozer in parkingStages[name])
				{
					if (buldozer != null)
					{
						//если место не пустое
						//Записываем тип машины
						if (buldozer.GetType().Name == "BuldozerBase")
						{
							sw.Write($"BuldozerBase{separator}");
						}
						if (buldozer.GetType().Name == "ModBuldozer")
						{
							sw.Write($"ModBuldozer{separator}");
						}
						//Записываемые параметры
						sw.Write(buldozer + Environment.NewLine);
					}
				}
			}
		}
		public void LoadDataPark(string filename)
		{
			if (!File.Exists(filename))
			{
				throw new FileNotFoundException();
			}
			string bufferTextFromFile = "";
			using (StreamReader sr = new StreamReader(filename))
			{
				bufferTextFromFile = sr.ReadLine();
				if (!bufferTextFromFile.Contains("Park"))
				{
					throw new FileNotFoundException();
				}
				VehicleBuldozer buldozer = null;
				string key = string.Empty;
				for (int i = 1; !sr.EndOfStream; ++i)
				{
					//идем по считанным записям
					bufferTextFromFile = sr.ReadLine();
					if (bufferTextFromFile.Contains("Parking"))
					{
						key = bufferTextFromFile.Split(separator)[1];
                        if (!parkingStages.ContainsKey(key))
                        {
                            parkingStages.Add(key, new Parking<VehicleBuldozer, SimpleWheel>(pictureWidth, pictureHeight));
                        }
                        else
                        {
                            parkingStages[key].Clear();
                        }
                        continue;
					}
					if (string.IsNullOrEmpty(bufferTextFromFile))
					{
						continue;
					}
					if (bufferTextFromFile.Split(separator)[0] == "BuldozerBase")
					{
						buldozer = new BuldozerBase(bufferTextFromFile.Split(separator)[1]);
					}
					else if (bufferTextFromFile.Split(separator)[0] == "ModBuldozer")
					{
						buldozer = new ModBuldozer(bufferTextFromFile.Split(separator)[1]);
					}
					var result = parkingStages[key] + buldozer;
					if (!result)
					{
						throw new FileLoadException("Не удалось загрузить автомобиль на парковку");
					}
				}
			}
		}
	}
}
