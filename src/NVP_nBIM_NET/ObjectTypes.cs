using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;
using Teigha.DatabaseServices;

using BIMStructureMgd.DatabaseObjects;
using static BIMStructureMgd.DatabaseObjects.Reinforcement;
using BIMStructureMgd.ObjectProperties;

namespace NVP_nBIM_NET.Common
{
    [NVP_Manifest(
        Text = "Возвращает тип ArcBuildingWall",
        CADType = "Nanocad",
        ViewType = "Data")]
    public class Type_ArcBuildingWall : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(typeof(ArcBuildingWall));
        }
    }

    [NVP_Manifest(
        Text = "Возвращает тип BuildingOpening",
        CADType = "Nanocad",
        ViewType = "Data")]
    public class Type_BuildingOpening : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(typeof(BuildingOpening));
        }
    }

    [NVP_Manifest(
        Text = "Возвращает тип BuildingSlab",
        CADType = "Nanocad",
        ViewType = "Data")]
    public class Type_BuildingSlab : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(typeof(BuildingSlab));
        }
    }

    [NVP_Manifest(
        Text = "Возвращает тип BuildingWallBase",
        CADType = "Nanocad",
        ViewType = "Data")]
    public class Type_BuildingWallBase : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(typeof(BuildingWallBase));
        }
    }

    [NVP_Manifest(
        Text = "Возвращает тип ConcreteBeam",
        CADType = "Nanocad",
        ViewType = "Data")]
    public class Type_ConcreteBeam : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(typeof(ConcreteBeam));
        }
    }

    [NVP_Manifest(
            Text = "Возвращает тип ConcreteColumn",
            CADType = "Nanocad",
            ViewType = "Data")]
    public class Type_ConcreteColumn : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(typeof(ConcreteColumn));
        }
    }

    [NVP_Manifest(
        Text = "Возвращает тип ConcreteElement",
        CADType = "Nanocad",
        ViewType = "Data")]
    public class Type_ConcreteElement : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(typeof(ConcreteElement));
        }
    }

    [NVP_Manifest(
        Text = "Возвращает тип ConstructionAssemblyRef",
        CADType = "Nanocad",
        ViewType = "Data")]
    public class Type_ConstructionAssemblyRef : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(typeof(ConstructionAssemblyRef));
        }
    }

    [NVP_Manifest(
        Text = "Возвращает тип ConstructionBlockRef",
        CADType = "Nanocad",
        ViewType = "Data")]
    public class Type_ConstructionBlockRef : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(typeof(ConstructionBlockRef));
        }
    }

    [NVP_Manifest(
        Text = "Возвращает тип CoordinateGrid",
        CADType = "Nanocad",
        ViewType = "Data")]
    public class Type_CoordinateGrid : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(typeof(CoordinateGrid));
        }
    }

    [NVP_Manifest(
        Text = "Возвращает тип ContinuousConcreteElement",
        CADType = "Nanocad",
        ViewType = "Data")]
    public class Type_ContinuousConcreteElement : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(typeof(ContinuousConcreteElement));
        }
    }

    [NVP_Manifest(
        Text = "Возвращает тип CoordinateGridRef",
        CADType = "Nanocad",
        ViewType = "Data")]
    public class Type_CoordinateGridRef : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(typeof(CoordinateGridRef));
        }
    }

    [NVP_Manifest(
        Text = "Возвращает тип LinearBuildingWall",
        CADType = "Nanocad",
        ViewType = "Data")]
    public class Type_LinearBuildingWall : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(typeof(LinearBuildingWall));
        }
    }

    [NVP_Manifest(
        Text = "Возвращает тип MetalAxisEntity",
        CADType = "Nanocad",
        ViewType = "Data")]
    public class Type_MetalAxisEntity : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(typeof(MetalAxisEntity));
        }
    }

    [NVP_Manifest(
        Text = "Возвращает тип MetalConstructionNode",
        CADType = "Nanocad",
        ViewType = "Data")]
    public class Type_MetalConstructionNode : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(typeof(MetalConstructionNode));
        }
    }

    [NVP_Manifest(
            Text = "Возвращает тип MetalEntityBase",
            CADType = "Nanocad",
            ViewType = "Data")]
    public class Type_MetalEntityBase : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(typeof(MetalEntityBase));
        }
    }

    [NVP_Manifest(
        Text = "Возвращает тип MetalPlate",
        CADType = "Nanocad",
        ViewType = "Data")]
    public class Type_MetalPlate : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(typeof(MetalPlate));
        }
    }

    [NVP_Manifest(
        Text = "Возвращает тип ParametricEntBase",
        CADType = "Nanocad",
        ViewType = "Data")]
    public class Type_ParametricEntBase : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(typeof(ParametricEntBase));
        }
    }

    [NVP_Manifest(
        Text = "Возвращает тип ParametricEntity",
        CADType = "Nanocad",
        ViewType = "Data")]
    public class Type_ParametricEntity : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(typeof(ParametricEntity));
        }
    }

    [NVP_Manifest(
        Text = "Возвращает тип Reinforcement",
        CADType = "Nanocad",
        ViewType = "Data")]
    public class Type_Reinforcement : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(typeof(Reinforcement));
        }
    }

    [NVP_Manifest(
        Text = "Возвращает тип Hook",
        CADType = "Nanocad",
        ViewType = "Data")]
    public class Type_Hook : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(typeof(Hook));
        }
    }

    [NVP_Manifest(
        Text = "Возвращает тип ReinforcementBinder",
        CADType = "Nanocad",
        ViewType = "Data")]
    public class Type_ReinforcementBinder : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(typeof(ReinforcementBinder));
        }
    }

    [NVP_Manifest(
        Text = "Возвращает тип ReinforcementDetail",
        CADType = "Nanocad",
        ViewType = "Data")]
    public class Type_ReinforcementDetail : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(typeof(ReinforcementDetail));
        }
    }

    [NVP_Manifest(
        Text = "Возвращает тип ReinforcementSpiral",
        CADType = "Nanocad",
        ViewType = "Data")]
    public class Type_ReinforcementSpiral : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(typeof(ReinforcementSpiral));
        }
    }

    [NVP_Manifest(
        Text = "Возвращает тип SpaceEntity",
        CADType = "Nanocad",
        ViewType = "Data")]
    public class Type_SpaceEntity : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(typeof(SpaceEntity));
        }
    }

    [NVP_Manifest(
            Text = "Возвращает тип StructuralArcSurface",
            CADType = "Nanocad",
            ViewType = "Data")]
    public class Type_StructuralArcSurface : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(typeof(StructuralArcSurface));
        }
    }

    [NVP_Manifest(
        Text = "Возвращает тип StructuralPart",
        CADType = "Nanocad",
        ViewType = "Data")]
    public class Type_StructuralPart : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(typeof(StructuralPart));
        }
    }

    [NVP_Manifest(
        Text = "Возвращает тип StructuralPlate",
        CADType = "Nanocad",
        ViewType = "Data")]
    public class Type_StructuralPlate : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(typeof(StructuralPlate));
        }
    }

    [NVP_Manifest(
        Text = "Возвращает тип StructuralSurface",
        CADType = "Nanocad",
        ViewType = "Data")]
    public class Type_StructuralSurface : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(typeof(StructuralSurface));
        }
    }

    [NVP_Manifest(
        Text = "Возвращает тип IParametricObject",
        CADType = "Nanocad",
        ViewType = "Data")]
    public class Type_IParametricObject : INode
    {
        public NodeResult Execute(INVPData context, List<NodeResult> inputs)
        {
            return new NodeResult(typeof(IParametricObject));
        }
    }

}
