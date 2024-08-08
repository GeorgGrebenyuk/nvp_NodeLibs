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
        /// <summary>
        /// Типы расчетных свойств для всех категория объектов
        /// </summary>
        /// <returns></returns>
        public static Dictionary<string, Guid> QuantityIdentifiers_Objects()
        {
            return new Dictionary<string, Guid>
                {
                    {"NominalThickness",Renga.QuantityIds.NominalThickness},
                    {"NominalLength",Renga.QuantityIds.NominalLength},
                    {"NominalWidth",Renga.QuantityIds.NominalWidth},
                    {"NominalHeight",Renga.QuantityIds.NominalHeight},
                    {"Perimeter",Renga.QuantityIds.Perimeter},
                    {"OverallWidth",Renga.QuantityIds.OverallWidth},
                    {"OverallHeight",Renga.QuantityIds.OverallHeight},
                    {"OverallDepth",Renga.QuantityIds.OverallDepth},
                    {"OverallLength",Renga.QuantityIds.OverallLength},
                    {"Volume",Renga.QuantityIds.Volume},
                    {"NetVolume",Renga.QuantityIds.NetVolume},
                    {"NetMass",Renga.QuantityIds.NetMass},
                    {"OuterSurfaceArea",Renga.QuantityIds.OuterSurfaceArea},
                    {"CrossSectionOverallWidth",Renga.QuantityIds.CrossSectionOverallWidth},
                    {"CrossSectionOverallHeight",Renga.QuantityIds.CrossSectionOverallHeight},
                    {"NetCrossSectionArea",Renga.QuantityIds.NetCrossSectionArea},
                    {"GrossCrossSectionArea",Renga.QuantityIds.GrossCrossSectionArea},
                    {"GrossWallArea",Renga.QuantityIds.GrossWallArea},
                    {"GrossCeilingArea",Renga.QuantityIds.GrossCeilingArea},
                    {"Area",Renga.QuantityIds.Area},
                    {"NominalArea",Renga.QuantityIds.NominalArea},
                    {"NetArea",Renga.QuantityIds.NetArea},
                    {"NetFootprintArea",Renga.QuantityIds.NetFootprintArea},
                    {"NetFloorArea",Renga.QuantityIds.NetFloorArea},
                    {"NetSideArea",Renga.QuantityIds.NetSideArea},
                    {"NetPerimeter",Renga.QuantityIds.NetPerimeter},
                    {"NetWallArea",Renga.QuantityIds.NetWallArea},
                    {"NetCeilingArea",Renga.QuantityIds.NetCeilingArea},
                    {"InnerSurfaceArea",Renga.QuantityIds.InnerSurfaceArea},
                    {"InnerSurfaceInternalArea",Renga.QuantityIds.InnerSurfaceInternalArea},
                    {"InnerSurfaceExternalArea",Renga.QuantityIds.InnerSurfaceExternalArea},
                    {"GlazingArea",Renga.QuantityIds.GlazingArea},
                    {"TotalSurfaceArea",Renga.QuantityIds.TotalSurfaceArea},
                    {"GrossArea",Renga.QuantityIds.GrossArea},
                    {"GrossPerimeter",Renga.QuantityIds.GrossPerimeter},
                    {"GrossFloorArea",Renga.QuantityIds.GrossFloorArea},
                    {"GrossVolume",Renga.QuantityIds.GrossVolume},
                    {"NumberOfRiser",Renga.QuantityIds.NumberOfRiser},
                    {"NumberOfTreads",Renga.QuantityIds.NumberOfTreads},
                    {"RiserHeight",Renga.QuantityIds.RiserHeight},
                    {"TreadLength",Renga.QuantityIds.TreadLength},
                    {"TotalRebarLength",Renga.QuantityIds.TotalRebarLength},
                    {"TotalRebarMass",Renga.QuantityIds.TotalRebarMass},
                    {"RelativeObjectBottomElevation",Renga.QuantityIds.RelativeObjectBottomElevation},
                    {"RelativeObjectTopElevation",Renga.QuantityIds.RelativeObjectTopElevation},
                    {"RelativeObjectBaselineBottomElevation",Renga.QuantityIds.RelativeObjectBaselineBottomElevation},
                    {"RelativeObjectBaselineTopElevation",Renga.QuantityIds.RelativeObjectBaselineTopElevation},
                    {"SlopeAngle",Renga.QuantityIds.SlopeAngle}
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
        Text = "Возвращает все расчетные свойства",
        ViewType = "Data")]
    [NodeInput("GuidCollection", typeof(object))]

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
    [NodeInput("GuidCollection", typeof(object))]

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
