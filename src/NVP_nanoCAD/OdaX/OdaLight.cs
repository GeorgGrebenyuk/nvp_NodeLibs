using NVP.API.Nodes;

namespace OdaX.OdaLight 
{
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


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		public class Name : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Name);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		[NodeInput("pVal", typeof(System.String))]
		public class Set_Name : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Name = inputs[1];
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		public class LightType : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.LightType);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		[NodeInput("pVal", typeof(System.String))]
		public class Set_LightType : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.LightType = inputs[1];
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		public class Status : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Status);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		[NodeInput("pVal", typeof(System.Object))]
		public class Set_Status : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Status = inputs[1];
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		public class Shadows : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Shadows);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		[NodeInput("pVal", typeof(System.Object))]
		public class Set_Shadows : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Shadows = inputs[1];
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		public class HotSpot : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.HotSpot);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		[NodeInput("pVal", typeof(System.Object))]
		public class Set_HotSpot : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.HotSpot = inputs[1];
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		public class FallOff : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.FallOff);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		[NodeInput("pVal", typeof(System.Object))]
		public class Set_FallOff : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.FallOff = inputs[1];
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		public class Intensity : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Intensity);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		[NodeInput("pVal", typeof(System.Object))]
		public class Set_Intensity : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Intensity = inputs[1];
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		public class LightColor : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.LightColor);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		[NodeInput("ppColor", typeof(System.Object))]
		public class Set_LightColor : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.LightColor = inputs[1];
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		public class PlotGlyph : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.PlotGlyph);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		[NodeInput("pVal", typeof(System.Object))]
		public class Set_PlotGlyph : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.PlotGlyph = inputs[1];
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		public class Position : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Position);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		[NodeInput("pVal", typeof(System.Object))]
		public class Set_Position : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Position = inputs[1];
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		public class Target : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Target);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		[NodeInput("pVal", typeof(System.Object))]
		public class Set_Target : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Target = inputs[1];
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		public class AttenuationType : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.AttenuationType);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		[NodeInput("pVal", typeof(System.String))]
		public class Set_AttenuationType : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.AttenuationType = inputs[1];
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		public class UseLimits : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.UseLimits);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		[NodeInput("pVal", typeof(System.Object))]
		public class Set_UseLimits : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.UseLimits = inputs[1];
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		public class StartLimit : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.StartLimit);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		[NodeInput("pVal", typeof(System.Double))]
		public class Set_StartLimit : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.StartLimit = inputs[1];
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		public class EndLimit : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.EndLimit);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		[NodeInput("pVal", typeof(System.Double))]
		public class Set_EndLimit : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.EndLimit = inputs[1];
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		public class ShadowType : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ShadowType);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		[NodeInput("pVal", typeof(System.String))]
		public class Set_ShadowType : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ShadowType = inputs[1];
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		public class MapSize : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.MapSize);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		[NodeInput("pVal", typeof(System.String))]
		public class Set_MapSize : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.MapSize = inputs[1];
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		public class Softness : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Softness);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		[NodeInput("pVal", typeof(System.Int32))]
		public class Set_Softness : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Softness = inputs[1];
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		public class FromVector : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.FromVector);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		[NodeInput("pVal", typeof(System.Object))]
		public class Set_FromVector : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.FromVector = inputs[1];
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		public class ToVector : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ToVector);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		[NodeInput("pVal", typeof(System.Object))]
		public class Set_ToVector : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ToVector = inputs[1];
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		public class SourceVectorX : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.SourceVectorX);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		[NodeInput("pVal", typeof(System.Double))]
		public class Set_SourceVectorX : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.SourceVectorX = inputs[1];
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		public class SourceVectorY : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.SourceVectorY);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		[NodeInput("pVal", typeof(System.Double))]
		public class Set_SourceVectorY : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.SourceVectorY = inputs[1];
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		public class SourceVectorZ : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.SourceVectorZ);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		[NodeInput("pVal", typeof(System.Double))]
		public class Set_SourceVectorZ : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.SourceVectorZ = inputs[1];
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		public class LampIntensity : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.LampIntensity);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		[NodeInput("pVal", typeof(System.Object))]
		public class Set_LampIntensity : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.LampIntensity = inputs[1];
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		public class ResultIntensity : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ResultIntensity);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		[NodeInput("pVal", typeof(System.String))]
		public class Set_ResultIntensity : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ResultIntensity = inputs[1];
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		public class LampColor : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.LampColor);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		[NodeInput("pVal", typeof(System.Object))]
		public class Set_LampColor : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.LampColor = inputs[1];
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		public class ResultColor : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ResultColor);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		[NodeInput("ppColor", typeof(System.Object))]
		public class Set_ResultColor : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ResultColor = inputs[1];
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		public class WebFile : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.WebFile);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		[NodeInput("pVal", typeof(System.String))]
		public class Set_WebFile : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.WebFile = inputs[1];
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		public class WebPreview : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.WebPreview);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		[NodeInput("pVal", typeof(System.Object))]
		public class Set_WebPreview : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.WebPreview = inputs[1];
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		public class WebRotateX : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.WebRotateX);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		[NodeInput("pVal", typeof(System.Object))]
		public class Set_WebRotateX : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.WebRotateX = inputs[1];
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		public class WebRotateY : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.WebRotateY);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		[NodeInput("pVal", typeof(System.Object))]
		public class Set_WebRotateY : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.WebRotateY = inputs[1];
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		public class WebRotateZ : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.WebRotateZ);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		[NodeInput("pVal", typeof(System.Object))]
		public class Set_WebRotateZ : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.WebRotateZ = inputs[1];
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		public class HasTarget : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.HasTarget);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		[NodeInput("pVal", typeof(System.Object))]
		public class Set_HasTarget : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.HasTarget = inputs[1];
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		public class ShadowSamples : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ShadowSamples);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		[NodeInput("pVal", typeof(System.Object))]
		public class Set_ShadowSamples : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ShadowSamples = inputs[1];
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		public class ShadowVisible : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ShadowVisible);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		[NodeInput("pVal", typeof(System.Object))]
		public class Set_ShadowVisible : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ShadowVisible = inputs[1];
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		public class ShadowShape : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ShadowShape);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		[NodeInput("pVal", typeof(System.String))]
		public class Set_ShadowShape : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ShadowShape = inputs[1];
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		public class ShadowRadius : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ShadowRadius);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		[NodeInput("pVal", typeof(System.Double))]
		public class Set_ShadowRadius : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ShadowRadius = inputs[1];
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		public class IlluminanceDistance : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.IlluminanceDistance);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		[NodeInput("pVal", typeof(System.Double))]
		public class Set_IlluminanceDistance : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.IlluminanceDistance = inputs[1];
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		public class ShadowLength : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ShadowLength);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		[NodeInput("pVal", typeof(System.Double))]
		public class Set_ShadowLength : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ShadowLength = inputs[1];
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		public class ShadowWidth : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ShadowWidth);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		[NodeInput("pVal", typeof(System.Double))]
		public class Set_ShadowWidth : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ShadowWidth = inputs[1];
				return null;
			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		public class GlyphDisplay : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.GlyphDisplay);

			}
		}


		///<summary>
		///
		///</summary>
		[NodeInput("OdaLight", typeof(object))]
		[NodeInput("pVal", typeof(System.String))]
		public class Set_GlyphDisplay : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.GlyphDisplay = inputs[1];
				return null;
			}
		}
}
