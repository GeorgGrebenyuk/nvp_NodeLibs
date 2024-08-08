using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///Interface for a Light entity
///</summary>
namespace OdaX.OdaLight 
{

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class OdaLight_Constructor : INode 
	{
		public OdaX.IOdaLight _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IOdaLight;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class OdaLight_ConstructorCast : INode 
	{
		public OdaX.IOdaLight _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IOdaLight;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Name);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class Set_Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Name = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class LightType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LightType);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class Set_LightType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LightType = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Status : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Status);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_Status : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Status = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Shadows : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Shadows);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_Shadows : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Shadows = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class HotSpot : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HotSpot);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_HotSpot : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.HotSpot = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class FallOff : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FallOff);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_FallOff : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.FallOff = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Intensity : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Intensity);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_Intensity : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Intensity = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class LightColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LightColor);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("ppColor", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_LightColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LightColor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class PlotGlyph : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PlotGlyph);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_PlotGlyph : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PlotGlyph = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Position : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Position);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_Position : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Position = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Target : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Target);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_Target : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Target = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class AttenuationType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AttenuationType);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class Set_AttenuationType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AttenuationType = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class UseLimits : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.UseLimits);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_UseLimits : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.UseLimits = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class StartLimit : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.StartLimit);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///
	///</summary>
	public class Set_StartLimit : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.StartLimit = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class EndLimit : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EndLimit);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///
	///</summary>
	public class Set_EndLimit : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.EndLimit = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class ShadowType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ShadowType);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class Set_ShadowType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ShadowType = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class MapSize : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MapSize);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class Set_MapSize : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.MapSize = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Softness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Softness);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("pVal", typeof(System.Int32))]

	///<summary>
	///
	///</summary>
	public class Set_Softness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Softness = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class FromVector : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FromVector);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_FromVector : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.FromVector = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class ToVector : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ToVector);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_ToVector : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ToVector = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class SourceVectorX : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SourceVectorX);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///
	///</summary>
	public class Set_SourceVectorX : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SourceVectorX = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class SourceVectorY : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SourceVectorY);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///
	///</summary>
	public class Set_SourceVectorY : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SourceVectorY = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class SourceVectorZ : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SourceVectorZ);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///
	///</summary>
	public class Set_SourceVectorZ : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SourceVectorZ = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class LampIntensity : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LampIntensity);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_LampIntensity : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LampIntensity = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class ResultIntensity : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ResultIntensity);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class Set_ResultIntensity : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ResultIntensity = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class LampColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LampColor);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_LampColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LampColor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class ResultColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ResultColor);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("ppColor", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_ResultColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ResultColor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class WebFile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.WebFile);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class Set_WebFile : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.WebFile = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class WebPreview : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.WebPreview);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_WebPreview : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.WebPreview = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class WebRotateX : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.WebRotateX);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_WebRotateX : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.WebRotateX = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class WebRotateY : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.WebRotateY);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_WebRotateY : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.WebRotateY = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class WebRotateZ : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.WebRotateZ);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_WebRotateZ : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.WebRotateZ = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class HasTarget : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HasTarget);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_HasTarget : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.HasTarget = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class ShadowSamples : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ShadowSamples);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_ShadowSamples : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ShadowSamples = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class ShadowVisible : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ShadowVisible);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_ShadowVisible : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ShadowVisible = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class ShadowShape : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ShadowShape);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class Set_ShadowShape : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ShadowShape = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class ShadowRadius : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ShadowRadius);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///
	///</summary>
	public class Set_ShadowRadius : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ShadowRadius = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class IlluminanceDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IlluminanceDistance);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///
	///</summary>
	public class Set_IlluminanceDistance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IlluminanceDistance = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class ShadowLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ShadowLength);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///
	///</summary>
	public class Set_ShadowLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ShadowLength = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class ShadowWidth : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ShadowWidth);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///
	///</summary>
	public class Set_ShadowWidth : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ShadowWidth = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		ViewType = "Data")]
	[NodeInput("OdaLight", typeof(object))]

	///<summary>
	///
	///</summary>
	public class GlyphDisplay : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GlyphDisplay);

		}
	}


	[NVP_Manifest(
		ViewType = "Modifier")]
	[NodeInput("OdaLight", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class Set_GlyphDisplay : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GlyphDisplay = inputs[1].Value;
			return null;
		}
	}
}
