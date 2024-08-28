using NVP.API.Nodes;
using System;
using System.Linq;
using System.Collections.Generic;
using NVP_Manifest_Creator;
using System.Collections;


namespace NVP_Common.Task.Kvartirografiya
{
    [NVP_Manifest(
            Text = "Возвращает список ЖИЛЫХ помещений по умолчанию",
            ViewType = "Data")]
    public class Kvartirografiya_Rooms_Living : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            string[] rooms = new string[] { "Спальня", "Гостиная", "Зал", "Детская", "Столовая", "Кабинет" };
            return new NodeResult(rooms);
        }
    }

    [NVP_Manifest(
            Text = "Возвращает список НЕЖИЛЫХ помещений по умолчанию",
            ViewType = "Data")]
    public class Kvartirografiya_Rooms_NonLiving : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            //ванная, кладовые, кухня, коридоры, прихожая, подвалы, котельные, прачечные
            string[] rooms = new string[] { "Туалет", "Санузел", "Кухня", "Ванная", "Кладовая", "Коридор", "Холл", "Прихожая", "Котельная", "Гардероб", "Гардеробная", "Прачечная", "Передняя", "Чердак", "Подвал", "Гараж", "Чулан", "Горница", "Сени" };
            return new NodeResult(rooms);
        }
    }

    [NVP_Manifest(
            Text = "Возвращает список ЛЕТНИХ (и прочих) помещений по умолчанию",
            ViewType = "Data")]
    public class Kvartirografiya_Rooms_Other : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            string[] rooms = new string[] { "Балкон", "Лоджия", "Терраса", "Веранда", "Крыльцо", "Беседка" };
            return new NodeResult(rooms);
        }
    }

    [NVP_Manifest(
            Text = "Возвращает список помещений без отделки",
            ViewType = "Data")]
    public class Kvartirografiya_Rooms_WithoutOtd : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            string[] rooms = new string[] { "Санузел", "Туалет" };
            return new NodeResult(rooms);
        }
    }

    [NVP_Manifest(
            Text = "Возвращает сопоставление названий помещений с коэффициентами к площадям",
            ViewType = "Data")]
    public class Kvartirografiya_Rooms_Coefficients2Areas : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            Dictionary<string, double> coefficients = new Dictionary<string, double>()
            {
                { "Балкон", 0.3},
                { "Лоджия",0.5},
            };
            return new NodeResult(coefficients);
        }
    }

    [NVP_Manifest(
            Text = "Расчитывает параметры квартирографии для заданных условий (см. справку)",
            ViewType = "Modifier")]
    /*0*/[NodeInput("Свойства помещений", typeof(IList))] //List<Dictionary>
    /*1*/[NodeInput("Уровень2Помещения", typeof(IDictionary))] //Dictionary<string, string[]> 
    /*2*/[NodeInput("Свойство Идентификатор", typeof(string))]
    /*3*/[NodeInput("Свойство Имя", typeof(string))]
    /*4*/[NodeInput("Свойство Квартира", typeof(string))]
    /*5*/[NodeInput("Свойство Площадь", typeof(string))]
    /*6*/[NodeInput("Свойство Площадь с отделкой", typeof(string))]
    /*7*/[NodeInput("Итог.Площадь Жилая", typeof(string))]
    /*8*/[NodeInput("Итог.Площадь Общая", typeof(string))]
    /*9*/[NodeInput("Итог.Площадь Квартиры", typeof(string))]
    /*10*/[NodeInput("Итог.Число помещений", typeof(string))]
    /*11*/[NodeInput("Жилые помещения", typeof(IList))]
    /*12*/[NodeInput("Нежилые помещения", typeof(IList))]
    /*13*/[NodeInput("Летние помещения", typeof(IList))]
    /*14*/[NodeInput("Помещения без отделки", typeof(IList))]
    /*15*/[NodeInput("Коэффициенты площади", typeof(IDictionary))]
    /*16*/[NodeInput("Точность округления", typeof(int))]
    /*17*/[NodeInput("Игнорировать", typeof(int))]
    public class Kvartirografiya_Calculate : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            //Шаг 1 -- инициация исходных данных
            IList input_0_props = (IList)inputs[0].Value;
            IDictionary input_1_level2rooms = (IDictionary)inputs[1].Value;

            string input_2_prop_Name_Id = (string)inputs[2].Value;
            string input_3_prop_Name_RoomName = (string)inputs[3].Value;
            string input_4_prop_Name_FlatId = (string)inputs[4].Value;
            string input_5_prop_Name_Area = (string)inputs[5].Value;
            string input_6_prop_Name_AreaOtd = (string)inputs[6].Value;
            string input_7_prop_Name_FinishLiving_Area = (string)inputs[7].Value;
            string input_8_prop_Name_FinishNonLiving_Area = (string)inputs[8].Value;
            string input_9_prop_Name_FinishSummer_Area = (string)inputs[9].Value;
            string input_10_prop_Name_FinishRooms_Area = (string)inputs[10].Value;

            IList input_11_WhatLivings = (IList)inputs[11].Value;
            IList input_12_WhatNonLivings = (IList)inputs[12].Value;
            IList input_13_WhatSummer = (IList)inputs[13].Value;
            IList input_14_WhatWithoutOtd= (IList)inputs[14].Value;

            IDictionary input_15_AreasKoefs = (IDictionary)inputs[15].Value;

            int input_16_Accuracy = Convert.ToInt32(inputs[16].Value);

            string input_17_ignore_Rule = (string)inputs[17].Value;
            string input_17_PropName = "";
            string input_17_PropValue = "";
            bool input_17 = false;
            if (input_17_ignore_Rule != null && input_17_ignore_Rule.Contains(":"))
            {
                input_17 = true;
                input_17_PropName = input_17_ignore_Rule.Split(':')[0];
                input_17_PropValue = input_17_ignore_Rule.Split(':')[1];
            }
            //Шаг 2 -- Первичный расчет метрик
            //Если есть данные по уровням, то в качестве номера квадртира использовать префикс в виде уровня
            Dictionary<int, string> roomIndex2prefix = new Dictionary<int, string>();
            if (input_1_level2rooms != null)
            {
                int counter = 0;
                for (int room_counter = 0; room_counter < input_0_props.Count; room_counter++)
                {
                    IDictionary RoomProps = (IDictionary)input_0_props[room_counter];
                    object roomId = RoomProps[input_2_prop_Name_Id];

                    var need_delevel = "";
                    foreach (DictionaryEntry level2rooms_raw in input_1_level2rooms)
                    {
                        //KeyValuePair<string, IList>
                        if (((IList)level2rooms_raw.Value).Contains(roomId))
                        {
                            need_delevel = (string)level2rooms_raw.Key;
                            break;
                        }
                    }
                    roomIndex2prefix.Add(counter, need_delevel);
                    counter++;
                }
            }

            //Шаг 3 -- Подсчет параметров для каждого помещения
            Dictionary<string, double[]> TempRoomData = new Dictionary<string, double[]>();
            string[] room2flat = new string[input_0_props.Count];
            for (int room_counter = 0; room_counter < input_0_props.Count; room_counter++)
            {
                IDictionary RoomProps = (IDictionary)input_0_props[room_counter];
                string RoomName = (string)RoomProps[input_3_prop_Name_RoomName];
                double RoomArea = (double)RoomProps[input_5_prop_Name_Area];
                double RoomAreaOtd = (double)RoomProps[input_6_prop_Name_AreaOtd];

                string FlatNum = RoomProps[input_4_prop_Name_FlatId].ToString();
                string FlatPrefix = "";
                if (roomIndex2prefix.TryGetValue(room_counter, out FlatPrefix)) FlatNum = FlatPrefix + FlatNum;
                room2flat[room_counter] = FlatNum;
                //Определяем тип помещения для получения коэффициента к площади
                string RoomType = "";
                if (input_11_WhatLivings.Contains(RoomName)) RoomType = "Жилое";
                else if (input_12_WhatNonLivings.Contains(RoomName)) RoomType = "Нежилое";
                else if (input_13_WhatSummer.Contains(RoomName)) RoomType = "Летние";
                else
                {
                    throw new Exception("Неопределенное наименование помещения " + RoomName);
                }
                double Room_AreaK = 1.0; 
                if (input_15_AreasKoefs.Contains(RoomName)) Room_AreaK = (double)input_15_AreasKoefs[RoomName];
                //Определение ЖИЛОЙ площади
                double RoomArea_Living = 0.0;
                if (RoomType == "Жилое") RoomArea_Living = RoomAreaOtd * Room_AreaK; //TODO: верно для случая коэффициента?

                //Определение НЕЖИЛОЙ площади
                double RoomArea_NonResidential = 0.0;
                if (RoomType == "Нежилое")
                {
                    //TODO: верно для случая коэффициента?
                    if (input_14_WhatWithoutOtd.Contains(RoomName)) RoomArea_NonResidential = RoomArea * Room_AreaK;
                    else RoomArea_NonResidential = RoomAreaOtd * Room_AreaK;
                }
                //Определение площади летних помещений
                double RoomArea_SummerRooms = 0.0;
                if (RoomType == "Летние") RoomArea_SummerRooms = RoomAreaOtd * Room_AreaK * 1.0;

                //Занесение в память
                //Если настроено игнорирование площади, то её не считаем
                if (input_17 && (string)RoomProps[input_17_PropName] == input_17_PropValue)
                {
                    RoomArea_Living = 0.0;
                    RoomArea_NonResidential = 0.0;
                    RoomArea_SummerRooms = 0.0;
                }
                double[] temp_existed_values = new double[4];
                if (!TempRoomData.TryGetValue(FlatNum, out temp_existed_values))
                    TempRoomData[FlatNum] = new double[4] { RoomArea_Living, RoomArea_NonResidential, RoomArea_SummerRooms, 1.0 };
                else
                {
                    temp_existed_values[0] += RoomArea_Living;
                    temp_existed_values[1] += RoomArea_NonResidential;
                    temp_existed_values[2] += RoomArea_SummerRooms;
                    temp_existed_values[3] += 1.0;
                    TempRoomData[FlatNum] = temp_existed_values;
                }
            }

            //Этап 2: Заполнение общей площади для каждой комнаты:
            List<string[]> OutData_Areas_Names = new List<string[]>();
            List<object[]> OutData_Areas_Values = new List<object[]>();
            List<string[]> OutData_Areas_Spec = new List<string[]>();
            OutData_Areas_Spec.Add(new string[] { "Наименование кв с уровнем", "Площадь жилая", "Площадь общая", "Площадь квартиры", "Число помещений" });

            for (int room_counter = 0; room_counter < input_0_props.Count; room_counter++)
            {
                string FlatNum = room2flat[room_counter];
                double[] FlatData = TempRoomData[FlatNum];
                double FlatArea_Living = Math.Round(FlatData[0], input_16_Accuracy);
                double FlatArea_NonResidential = Math.Round(FlatData[1], input_16_Accuracy);
                double FlatArea_SummerRooms = Math.Round(FlatData[2], input_16_Accuracy);
                int RoomsCount = Convert.ToInt32(FlatData[3]);
                //Заполнение свойств на выход
                double temp_total_Common = FlatArea_Living + FlatArea_NonResidential;
                double temp_total_All = temp_total_Common + FlatArea_SummerRooms;

                OutData_Areas_Names.Add(new string[4] { input_7_prop_Name_FinishLiving_Area , input_8_prop_Name_FinishNonLiving_Area,
                    input_9_prop_Name_FinishSummer_Area, input_10_prop_Name_FinishRooms_Area});
                OutData_Areas_Values.Add(new object[4] { FlatArea_Living, temp_total_Common, temp_total_All, RoomsCount });
                OutData_Areas_Spec.Add(new string[4] { FlatArea_Living.ToString(), temp_total_Common.ToString(), temp_total_All.ToString(), RoomsCount.ToString() });
            }

            return new NodeResult(new object[3] { OutData_Areas_Names, OutData_Areas_Values, OutData_Areas_Spec });
        }
    }
}
