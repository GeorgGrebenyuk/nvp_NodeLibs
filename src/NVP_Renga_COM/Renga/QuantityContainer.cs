using NVP.API.Nodes;
using System;
using System.Linq;
using System.Collections.Generic;

using NVP_Manifest_Creator;
using Renga.Quantity;

///<summary>
///
///</summary>
namespace Renga.QuantityContainer 
{
    [NVP_Manifest(
		Text = "Идентификаторы всех расчетных свойств (Dictionary: string, Guid)",
		ViewType = "Default")]
    public class QuantityIds : INode
	{
        public static Guid Area { get; } = new Guid(39800047, 31597, 17881, 153, 230, 44, 216, 81, 48, 110, 3);
        public static Guid Count { get; } = new Guid(3398899140U, 24849, 20407, 161, 89, 36, 5, 245, 160, 187, 146);
        public static Guid CrossSectionOverallHeight { get; } = new Guid(3253098413U, 40446, 19223, 132, 220, 90, 8, 2, 73, 133, 54);
        public static Guid CrossSectionOverallWidth { get; } = new Guid(693295390U, 48216, 19092, 131, 43, 245, 131, 194, 46, 251, 68);
        public static Guid GlazingArea { get; } = new Guid(300015282, 8240, 20279, 182, 51, 58, 122, 225, 98, 67, 122);
        public static Guid GrossArea { get; } = new Guid(1773562932U, 54289, 16941, 189, 74, 202, 195, 246, 132, 111, 216);
        public static Guid GrossCeilingArea { get; } = new Guid(1045665218, 24427, 19800, 131, 73, 20, 25, 162, 154, 71, 185);
        public static Guid GrossCrossSectionArea { get; } = new Guid(3012510262U, 5722, 17835, 139, 150, 236, 1, 117, 52, 52, 4);
        public static Guid GrossFloorArea { get; } = new Guid(2309725015U, 37297, 20298, 154, 69, 156, 147, 88, 130, 35, 29);
        public static Guid GrossMass { get; } = new Guid(3765756555U, 1335, 20023, 132, 90, 199, 49, 88, 67, 238, 115);
        public static Guid GrossPerimeter { get; } = new Guid(3948664644U, 15488, 18082, 180, 145, 44, 164, 241, 29, 209, 61);
        public static Guid GrossSideArea { get; } = new Guid(256394U, 41719, 17527, 137, 201, 62, 158, 246, 83, 59, 227);
        public static Guid GrossSideAreaLeft { get; } = new Guid(647920449, 15833, 17105, 176, 208, 7, 78, 137, 163, 162, 131);
        public static Guid GrossSideAreaRight { get; } = new Guid(2620712894U, 10231, 18768, 165, 29, 220, 45, 93, 168, 243, 232);
        public static Guid GrossVolume { get; } = new Guid(3661754522U, 3586, 16583, 149, 71, 42, 15, 85, 182, 0, 120);
        public static Guid GrossWallArea { get; } = new Guid(1095014205U, 50359, 20241, 171, 72, 135, 148, 201, 190, 174, 67);
        public static Guid InnerSurfaceArea { get; } = new Guid(2781515259U, 5062, 16524, 161, 192, 97, 230, 112, 38, 179, 107);
        public static Guid InnerSurfaceExternalArea { get; } = new Guid(2053389762, 21796, 18589, 151, 179, 112, 17, 220, 191, byte.MaxValue, 72);
        public static Guid InnerSurfaceInternalArea { get; } = new Guid(302097120U, 49079, 19240, 136, 246, 146, 53, 113, 151, 40, 144);
        public static Guid NetArea { get; } = new Guid(178998192, 17989, 18646, 157, 203, 42, 202, 72, 87, 126, 71);
        public static Guid NetCeilingArea { get; } = new Guid(3861273692U, 30354, 18877, 183, 161, 10, 95, 69, 47, 238, 221);
        public static Guid NetCrossSectionArea { get; } = new Guid(1595866743, 24110, 17674, 164, 38, 239, 239, 91, 52, 110, 204);
        public static Guid NetFloorArea { get; } = new Guid(3932214566U, 46375, 18582, 142, 76, 200, 74, 132, 98, 179, 204);
        public static Guid NetFootprintArea { get; } = new Guid(1707028630U, 46608, 20400, 182, 3, 158, 31, 213, 194, 16, 149);
        public static Guid NetMass { get; } = new Guid(4179823954U, 15757, 17136, 180, 152, 95, 128, 55, 97, 12, 1);
        public static Guid NetPerimeter { get; } = new Guid(895522956U, 51718, 16424, 168, 33, 114, 107, 171, 3, 133, 54);
        public static Guid NetSideArea { get; } = new Guid(1835608902U, 64626, 18070, 165, 94, 29, 52, 105, 170, 157, 142);
        public static Guid NetSideAreaLeft { get; } = new Guid(22050505, 16448, 17824, 135, 190, 250, 65, 36, 246, 205, 78);
        public static Guid NetSideAreaRight { get; } = new Guid(602395427U, 64553, 19206, 140, 231, 27, 205, 42, 32, 240, 41);
        public static Guid NetVolume { get; } = new Guid(70517235, 2863, 16426, 172, 160, 130, 100, 54, 130, 36, 5);
        public static Guid NetWallArea { get; } = new Guid(3264699934U, 12947, 19153, 129, 54, 49, 109, 25, 27, 117, 204);
        public static Guid NominalArea { get; } = new Guid(4214559128U, 6735, 18453, 149, 62, 23, 124, 23, 231, 100, 28);
        public static Guid NominalHeight { get; } = new Guid(3908150805U, 15116, 16412, 173, 31, 117, 38, 242, 240, 115, 226);
        public static Guid NominalLength { get; } = new Guid(1160713699, 20704, 19878, 145, 85, 86, 122, 0, 210, 213, 183);
        public static Guid NominalThickness { get; } = new Guid(3611768744U, 57294, 18790, 176, 68, 44, 32, 174, 159, 82, 251);
        public static Guid NominalWidth { get; } = new Guid(397447280U, 40958, 19231, 188, 201, 108, 178, 63, 177, 214, 236);
        public static Guid NumberOfRiser { get; } = new Guid(3775213256U, 48126, 18976, 176, 147, 194, 117, 38, 19, 174, 128);
        public static Guid NumberOfTreads { get; } = new Guid(1555579998U, 34115, 18506, 180, 186, 15, 51, 67, 170, 31, 58);
        public static Guid OuterSurfaceArea { get; } = new Guid(3726320167U, 12557, 18002, 167, 147, 199, 153, 197, 190, 112, 54);
        public static Guid OverallDepth { get; } = new Guid(2450563857U, 41720, 18241, 170, 81, 191, 4, 174, 77, 132, 37);
        public static Guid OverallHeight { get; } = new Guid(4284344833U, 31386, 17531, 149, 66, 20, 182, 81, 221, 132, 132);
        public static Guid OverallLength { get; } = new Guid(863916344U, 38809, 17871, 148, 243, 95, 182, 180, 174, 61, 229);
        public static Guid OverallWidth { get; } = new Guid(3310361245U, 12137, 18832, 187, 242, 191, 218, 175, 110, 22, 218);
        public static Guid Perimeter { get; } = new Guid(738665092, 4910, 17472, 129, 120, 224, 79, 100, 183, 51, 32);
        public static Guid ReinforcementUnitCount { get; } = new Guid(2444019173U, 50808, 16932, 170, 29, 245, 105, 169, 229, 236, 191);
        public static Guid RelativeObjectBaselineBottomElevation { get; } = new Guid(2269492940U, 64413, 16753, 132, 193, 63, 240, 216, 142, 174, 22);
        public static Guid RelativeObjectBaselineTopElevation { get; } = new Guid(1016979623U, 48745, 17399, 158, 180, 114, 178, 49, 53, 2, 244);
        public static Guid RelativeObjectBottomElevation { get; } = new Guid(3783098459U, 356, 18442, 132, 155, 100, 253, 2, 46, 193, 122);
        public static Guid RelativeObjectTopElevation { get; } = new Guid(1017741880U, 41653, 16970, 165, 121, 106, 13, 102, 239, 7, 90);
        public static Guid RiserHeight { get; } = new Guid(2265076431U, 59333, 19351, 164, 116, 190, 31, 204, 223, 221, 70);
        public static Guid SheetCount { get; } = new Guid(3963183412U, 21186, 17703, 144, 234, 70, 41, 153, 240, 47, 28);
        public static Guid SheetNumber { get; } = new Guid(1276769563U, 38706, 19786, 149, 109, 206, 10, 186, 18, 133, 157);
        public static Guid SlopeAngle { get; } = new Guid(1698659686, 22672, 17005, 168, 157, 19, 171, 13, 122, 28, 193);
        public static Guid SumConductorsLengths { get; } = new Guid(1720099672U, 39249, 19810, 164, 79, 154, 16, 250, 24, 98, 142);
        public static Guid TotalRebarLength { get; } = new Guid(428864160, 7182, 18440, 137, 69, 115, 79, 111, 131, 220, 231);
        public static Guid TotalRebarMass { get; } = new Guid(4059194287U, 14863, 18700, 137, 70, 126, 31, 206, 50, 129, 121);
        public static Guid TotalSurfaceArea { get; } = new Guid(1672454322, 15812, 17664, 156, 165, 244, 111, 192, 174, 147, 90);
        public static Guid TreadLength { get; } = new Guid(97028042U, 46030, 17714, 129, 48, 131, 109, 8, 28, 146, 191);
        public static Guid Volume { get; } = new Guid(1851983245, 2739, 19133, 169, 186, 87, 78, 23, 70, 197, 173);
        /// <summary>
        /// Типы расчетных свойств для всех категория объектов
        /// </summary>
        /// <returns></returns>
        public static Dictionary<string, Guid> QuantityIdentifiers_Objects()
        {
            return new Dictionary<string, Guid>
                {
                    {"NominalThickness",NominalThickness},
                    {"NominalLength",NominalLength},
                    {"NominalWidth",NominalWidth},
                    {"NominalHeight",NominalHeight},
                    {"Perimeter",Perimeter},
                    {"OverallWidth",OverallWidth},
                    {"OverallHeight",OverallHeight},
                    {"OverallDepth",OverallDepth},
                    {"OverallLength",OverallLength},
                    {"Volume",Volume},
                    {"NetVolume",NetVolume},
                    {"NetMass",NetMass},
                    {"OuterSurfaceArea",OuterSurfaceArea},
                    {"CrossSectionOverallWidth",CrossSectionOverallWidth},
                    {"CrossSectionOverallHeight",CrossSectionOverallHeight},
                    {"NetCrossSectionArea",NetCrossSectionArea},
                    {"GrossCrossSectionArea",GrossCrossSectionArea},
                    {"GrossWallArea",GrossWallArea},
                    {"GrossCeilingArea",GrossCeilingArea},
                    {"Area",Area},
                    {"NominalArea",NominalArea},
                    {"NetArea",NetArea},
                    {"NetFootprintArea",NetFootprintArea},
                    {"NetFloorArea",NetFloorArea},
                    {"NetSideArea",NetSideArea},
                    {"NetPerimeter",NetPerimeter},
                    {"NetWallArea",NetWallArea},
                    {"NetCeilingArea",NetCeilingArea},
                    {"InnerSurfaceArea",InnerSurfaceArea},
                    {"InnerSurfaceInternalArea",InnerSurfaceInternalArea},
                    {"InnerSurfaceExternalArea",InnerSurfaceExternalArea},
                    {"GlazingArea",GlazingArea},
                    {"TotalSurfaceArea",TotalSurfaceArea},
                    {"GrossArea",GrossArea},
                    {"GrossPerimeter",GrossPerimeter},
                    {"GrossFloorArea",GrossFloorArea},
                    {"GrossVolume",GrossVolume},
                    {"NumberOfRiser",NumberOfRiser},
                    {"NumberOfTreads",NumberOfTreads},
                    {"RiserHeight",RiserHeight},
                    {"TreadLength",TreadLength},
                    {"TotalRebarLength",TotalRebarLength},
                    {"TotalRebarMass",TotalRebarMass},
                    {"RelativeObjectBottomElevation",RelativeObjectBottomElevation},
                    {"RelativeObjectTopElevation",RelativeObjectTopElevation},
                    {"RelativeObjectBaselineBottomElevation",RelativeObjectBaselineBottomElevation},
                    {"RelativeObjectBaselineTopElevation",RelativeObjectBaselineTopElevation},
                    {"SlopeAngle",SlopeAngle}
                };
        }

        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(QuantityIdentifiers_Objects());
        }
    }

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class QuantityContainer_Constructor : INode 
	{
		public Renga.IQuantityContainer _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as Renga.IQuantityContainer;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class QuantityContainer_ConstructorCast : INode 
	{
		public Renga.IQuantityContainer _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as Renga.IQuantityContainer;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("QuantityContainer", typeof(object))]
	[NodeInput("Id", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Contains : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Contains(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("QuantityContainer", typeof(object))]
	[NodeInput("Id", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Get : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Get(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("QuantityContainer", typeof(object))]
	[NodeInput("Id", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class ContainsS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ContainsS(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("QuantityContainer", typeof(object))]
	[NodeInput("Id", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class GetS : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GetS(inputs[1].Value));

		}
	}

    [NVP_Manifest(
        Text = "Возвращает все расчетные свойства в виде Renga.Quantity",
        ViewType = "Data")]
    [NodeInput("QuantityContainer", typeof(object))]

    public class GetAll_Quantities : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            var _input0 = ((dynamic)inputs[0].Value)._i as Renga.IQuantityContainer;
            List<Quantity_Constructor> items = new List<Quantity_Constructor>();
            foreach (KeyValuePair<string, Guid> prop2id in QuantityIds.QuantityIdentifiers_Objects())
            {
                if (_input0.Contains(prop2id.Value))
                {
					Quantity_Constructor item = new Quantity_Constructor();
					item._i = _input0.Get(prop2id.Value);
                    items.Add(item);
                }
            }
            return new NodeResult(items);
        }
    }

    [NVP_Manifest(
        Text = "Возвращает все расчетные свойства в виде словаря",
        ViewType = "Data")]
    [NodeInput("QuantityContainer", typeof(object))]

    public class GetAll_Quantities2 : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            var _input0 = ((dynamic)inputs[0].Value)._i as Renga.IQuantityContainer;
            Dictionary<string, double> items = new Dictionary<string, double>();
            foreach (KeyValuePair<string, Guid> prop2id in QuantityIds.QuantityIdentifiers_Objects())
            {
                if (_input0.Contains(prop2id.Value))
                {
                    Renga.IQuantity quantity = _input0.Get(prop2id.Value);

                    string quantity_name = QuantityIds.QuantityIdentifiers_Objects().
						Where(a => a.Value.Equals(prop2id.Value)).First().Key;
                    double quantity_value = -1.0;
					switch (quantity.Type)
					{
                        case QuantityType.QuantityType_Area:
                            quantity_value = quantity.AsArea(AreaUnit.AreaUnit_Meters2); break;
                        case QuantityType.QuantityType_Count:
                            quantity_value = quantity.AsCount(); break;
                        case QuantityType.QuantityType_Length:
                            quantity_value = quantity.AsLength(LengthUnit.LengthUnit_Meters); break;
                        case QuantityType.QuantityType_Mass:
                            quantity_value = quantity.AsMass(MassUnit.MassUnit_Kilograms); break;
                        case QuantityType.QuantityType_Volume:
                            quantity_value = quantity.AsVolume(VolumeUnit.VolumeUnit_Meters3); break;

                    }

					items.Add(quantity_name, quantity_value);
					//Повторяющихся быть не может в прицнипе
                }
            }
            return new NodeResult(items);
        }
    }



}
