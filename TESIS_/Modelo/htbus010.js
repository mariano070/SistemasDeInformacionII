gx.evt.autoSkip=false;function htbus010(){this.ServerClass="HTBUS010";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=false;this.autoRefresh=true;this.SetStandaloneVars=function(){this.AV5SISTEMA=gx.fn.getControlValue("vSISTEMA");this.AV6USUARIO=gx.fn.getControlValue("vUSUARIO")};this.e11192_client=function(){this.executeServerEvent("'GENERAR LISTADO'",false)};this.e13192_client=function(){this.executeServerEvent("ENTER",true)};this.e14192_client=function(){this.executeServerEvent("CANCEL",true)
};this.GXValidFnc=[];this.GXCtrlIds=[2];this.GXLastCtrlId=2;this.GXValidFnc[2]={fld:"TABLE1",grid:0};this.AV5SISTEMA="";this.AV6USUARIO="";this.ServerEvents=["e11192_client","e13192_client","e14192_client"];this.VarControlMap.AV5SISTEMA={id:"vSISTEMA",grid:0,type:"char"};this.VarControlMap.AV6USUARIO={id:"vUSUARIO",grid:0,type:"char"};this.SetStandaloneVars()}htbus010.prototype=new gx.GxObject;gx.setParentObj(new htbus010());