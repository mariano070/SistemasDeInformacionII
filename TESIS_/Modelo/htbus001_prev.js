gx.evt.autoSkip=false;function htbus001_prev(){this.ServerClass="HTBUS001_prev";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=false;this.autoRefresh=true;this.SetStandaloneVars=function(){this.AV5SISTEMA=gx.fn.getControlValue("vSISTEMA");this.AV6USUARIO=gx.fn.getControlValue("vUSUARIO")};this.e130b2_client=function(){this.executeServerEvent("ENTER",true)};this.e140b2_client=function(){this.executeServerEvent("CANCEL",true)};this.GXValidFnc=[];this.GXLastCtrlId=0;
this.AV5SISTEMA="";this.AV6USUARIO="";this.ServerEvents=["e130b2_client","e140b2_client"];this.VarControlMap.AV5SISTEMA={id:"vSISTEMA",grid:0,type:"char"};this.VarControlMap.AV6USUARIO={id:"vUSUARIO",grid:0,type:"char"};this.SetStandaloneVars()}htbus001_prev.prototype=new gx.GxObject;gx.setParentObj(new htbus001_prev());