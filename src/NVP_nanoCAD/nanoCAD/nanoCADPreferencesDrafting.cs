using NVP.API.Nodes;

namespace nanoCAD.nanoCADPreferencesDrafting 
{
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADPreferencesDrafting_Constructor : INode 
	{
		public nanoCAD.InanoCADPreferencesDrafting _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as nanoCAD.InanoCADPreferencesDrafting;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADPreferencesDrafting_ConstructorCast : INode 
	{
		public nanoCAD.InanoCADPreferencesDrafting _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as nanoCAD.InanoCADPreferencesDrafting;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	///<summary>
	///Returns the Application object.
	///</summary>
	[NodeInput("nanoCADPreferencesDrafting", typeof(object))]
	public class Application : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Application);

		}
	}


	///<summary>
	///Specifies or returns whether the snap marker displays for snap locations.
	///</summary>
	[NodeInput("nanoCADPreferencesDrafting", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]
	public class Set_AutoSnapMarker : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AutoSnapMarker = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns whether the snap marker displays for snap locations.
	///</summary>
	[NodeInput("nanoCADPreferencesDrafting", typeof(object))]
	public class AutoSnapMarker : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AutoSnapMarker);

		}
	}


	///<summary>
	///Specifies or returns whether the snap magnet is turned on.
	///</summary>
	[NodeInput("nanoCADPreferencesDrafting", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]
	public class Set_AutoSnapMagnet : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AutoSnapMagnet = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns whether the snap magnet is turned on.
	///</summary>
	[NodeInput("nanoCADPreferencesDrafting", typeof(object))]
	public class AutoSnapMagnet : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AutoSnapMagnet);

		}
	}


	///<summary>
	///Specifies or returns whether snap tooltips are turned on.
	///</summary>
	[NodeInput("nanoCADPreferencesDrafting", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]
	public class Set_AutoSnapTooltip : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AutoSnapTooltip = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns whether snap tooltips are turned on.
	///</summary>
	[NodeInput("nanoCADPreferencesDrafting", typeof(object))]
	public class AutoSnapTooltip : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AutoSnapTooltip);

		}
	}


	///<summary>
	///Specifies or returns whether the aperture cursor displays.
	///</summary>
	[NodeInput("nanoCADPreferencesDrafting", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]
	public class Set_AutoSnapAperture : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AutoSnapAperture = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns whether the aperture cursor displays.
	///</summary>
	[NodeInput("nanoCADPreferencesDrafting", typeof(object))]
	public class AutoSnapAperture : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AutoSnapAperture);

		}
	}


	///<summary>
	///Specifies or returns the aperture cursor size.
	///</summary>
	[NodeInput("nanoCADPreferencesDrafting", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]
	public class Set_AutoSnapApertureSize : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AutoSnapApertureSize = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the aperture cursor size.
	///</summary>
	[NodeInput("nanoCADPreferencesDrafting", typeof(object))]
	public class AutoSnapApertureSize : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AutoSnapApertureSize);

		}
	}


	///<summary>
	///Specifies or returns the snap marker color.
	///</summary>
	[NodeInput("nanoCADPreferencesDrafting", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]
	public class Set_AutoSnapMarkerColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AutoSnapMarkerColor = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the snap marker color.
	///</summary>
	[NodeInput("nanoCADPreferencesDrafting", typeof(object))]
	public class AutoSnapMarkerColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AutoSnapMarkerColor);

		}
	}


	///<summary>
	///Specifies or returns the snap marker size in pixels.
	///</summary>
	[NodeInput("nanoCADPreferencesDrafting", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]
	public class Set_AutoSnapMarkerSize : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AutoSnapMarkerSize = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns the snap marker size in pixels.
	///</summary>
	[NodeInput("nanoCADPreferencesDrafting", typeof(object))]
	public class AutoSnapMarkerSize : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AutoSnapMarkerSize);

		}
	}


	///<summary>
	///Specifies or returns whether polar tracking is turned on.
	///</summary>
	[NodeInput("nanoCADPreferencesDrafting", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]
	public class Set_PolarTrackingVector : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PolarTrackingVector = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns whether polar tracking is turned on.
	///</summary>
	[NodeInput("nanoCADPreferencesDrafting", typeof(object))]
	public class PolarTrackingVector : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.PolarTrackingVector);

		}
	}


	///<summary>
	///Specifies or returns whether full-screen tracking is turned on.
	///</summary>
	[NodeInput("nanoCADPreferencesDrafting", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]
	public class Set_FullScreenTrackingVector : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.FullScreenTrackingVector = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns whether full-screen tracking is turned on.
	///</summary>
	[NodeInput("nanoCADPreferencesDrafting", typeof(object))]
	public class FullScreenTrackingVector : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FullScreenTrackingVector);

		}
	}


	///<summary>
	///Specifies or returns whether AutoTrack tooltips are turned on.
	///</summary>
	[NodeInput("nanoCADPreferencesDrafting", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]
	public class Set_AutoTrackTooltip : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AutoTrackTooltip = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns whether AutoTrack tooltips are turned on.
	///</summary>
	[NodeInput("nanoCADPreferencesDrafting", typeof(object))]
	public class AutoTrackTooltip : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AutoTrackTooltip);

		}
	}


	///<summary>
	///Specifies or returns how AutoAlignment points are obtained.
	///</summary>
	[NodeInput("nanoCADPreferencesDrafting", typeof(object))]
	[NodeInput("Path", typeof(System.Object))]
	public class Set_AlignmentPointAcquisition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AlignmentPointAcquisition = inputs[1];
			return null;
		}
	}


	///<summary>
	///Specifies or returns how AutoAlignment points are obtained.
	///</summary>
	[NodeInput("nanoCADPreferencesDrafting", typeof(object))]
	public class AlignmentPointAcquisition : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AlignmentPointAcquisition);

		}
	}
}
