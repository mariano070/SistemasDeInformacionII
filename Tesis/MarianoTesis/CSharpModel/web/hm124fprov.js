gx.evt.autoSkip=false;function hm124fprov(){this.ServerClass="HM124FPROV";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=false;this.autoRefresh=true;this.SetStandaloneVars=function(){this.AV8SISTEMA=gx.fn.getControlValue("vSISTEMA");this.AV9USUARIO=gx.fn.getControlValue("vUSUARIO")};this.e125h2_client=function(){this.executeServerEvent("'ALTA'",true,arguments[0])};this.e155h2_client=function(){this.executeServerEvent("'BAJA'",true,arguments[0])};this.e165h2_client=function(){this.executeServerEvent("'EDICIóN'",true,arguments[0])
};this.e175h2_client=function(){this.executeServerEvent("'VISUALIZACIóN'",true,arguments[0])};this.e115h2_client=function(){this.executeServerEvent("'BUSCAR'",false,arguments[0])};this.e185h2_client=function(){this.executeServerEvent("ENTER",true,arguments[0])};this.e195h2_client=function(){this.executeServerEvent("CANCEL",true,arguments[0])};this.GXValidFnc=[];this.GXCtrlIds=[2,8,13,18,25,29,30,31,32,33];this.GXLastCtrlId=33;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",28,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"hm124fprov",[],false,1,false,true,10,true,false,false,"",0,"px","Nueva fila",true,false,false,null,null,false,"");
this.Grid1Container.addBitmap("&Baja","vBAJA",29,0,"px",17,"px","e155h2_client","","");this.Grid1Container.addBitmap("&Edicion","vEDICION",30,0,"px",17,"px","e165h2_client","","");this.Grid1Container.addBitmap("&Visualizacion","vVISUALIZACION",31,0,"px",17,"px","e175h2_client","","");this.Grid1Container.addSingleLineEdit(28,32,"PV_NPRO","Código Proveedor","","PV_NPRO","int",0,"px",8,8,"right",null,[],28,"PV_NPRO",true,0,false,false);this.Grid1Container.addSingleLineEdit(5,33,"PV_DESC","Descripción","","PV_DESC","char",250,"px",30,30,"left",null,[],5,"PV_DESC",true,0,false,false);
this.setGrid(this.Grid1Container);this.GXValidFnc[2]={fld:"TABLE1",grid:0};this.GXValidFnc[8]={fld:"TABLE2",grid:0};this.GXValidFnc[11]={fld:"TEXTBLOCK1",format:0,grid:0};this.GXValidFnc[13]={lvl:0,type:"int",len:8,dec:0,sign:false,pic:"ZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vFPV_NPRO",gxz:"ZV10fPV_NPRO",gxold:"OV10fPV_NPRO",gxvar:"AV10fPV_NPRO",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV10fPV_NPRO=gx.num.intval(a)},v2z:function(a){gx.O.ZV10fPV_NPRO=gx.num.intval(a)
},v2c:function(){gx.fn.setControlValue("vFPV_NPRO",gx.O.AV10fPV_NPRO,0)},c2v:function(){gx.O.AV10fPV_NPRO=this.val()},val:function(){return gx.fn.getIntegerValue("vFPV_NPRO",".")},nac:function(){return false}};this.GXValidFnc[16]={fld:"TEXTBLOCK2",format:0,grid:0};this.GXValidFnc[18]={lvl:0,type:"char",len:30,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vFPV_DESC",gxz:"ZV11fPV_DESC",gxold:"OV11fPV_DESC",gxvar:"AV11fPV_DESC",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV11fPV_DESC=a
},v2z:function(a){gx.O.ZV11fPV_DESC=a},v2c:function(){gx.fn.setControlValue("vFPV_DESC",gx.O.AV11fPV_DESC,0)},c2v:function(){gx.O.AV11fPV_DESC=this.val()},val:function(){return gx.fn.getControlValue("vFPV_DESC")},nac:function(){return false}};this.GXValidFnc[25]={fld:"IMG_ALTA",grid:0};this.GXValidFnc[29]={lvl:2,type:"bits",len:4,dec:0,sign:false,ro:1,grid:28,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"vBAJA",gxz:"ZV5baja",gxold:"OV5baja",gxvar:"AV5baja",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV5baja=a
},v2z:function(a){gx.O.ZV5baja=a},v2c:function(){},c2v:function(){gx.O.AV5baja=this.val()},val:function(){return gx.fn.getGridControlValue("vBAJA",gx.fn.currentGridRowImpl(28))},nac:function(){return false}};this.GXValidFnc[30]={lvl:2,type:"bits",len:4,dec:0,sign:false,ro:1,grid:28,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"vEDICION",gxz:"ZV6edicion",gxold:"OV6edicion",gxvar:"AV6edicion",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV6edicion=a},v2z:function(a){gx.O.ZV6edicion=a
},v2c:function(){},c2v:function(){gx.O.AV6edicion=this.val()},val:function(){return gx.fn.getGridControlValue("vEDICION",gx.fn.currentGridRowImpl(28))},nac:function(){return false}};this.GXValidFnc[31]={lvl:2,type:"bits",len:4,dec:0,sign:false,ro:1,grid:28,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"vVISUALIZACION",gxz:"ZV7visualizacion",gxold:"OV7visualizacion",gxvar:"AV7visualizacion",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV7visualizacion=a},v2z:function(a){gx.O.ZV7visualizacion=a
},v2c:function(){},c2v:function(){gx.O.AV7visualizacion=this.val()},val:function(){return gx.fn.getGridControlValue("vVISUALIZACION",gx.fn.currentGridRowImpl(28))},nac:function(){return false}};this.GXValidFnc[32]={lvl:2,type:"int",len:8,dec:0,sign:false,pic:"ZZZZZ9",ro:1,grid:28,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"PV_NPRO",gxz:"Z28PV_NPRO",gxold:"O28PV_NPRO",gxvar:"A28PV_NPRO",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A28PV_NPRO=gx.num.intval(a)
},v2z:function(a){gx.O.Z28PV_NPRO=gx.num.intval(a)},v2c:function(){gx.fn.setGridControlValue("PV_NPRO",gx.fn.currentGridRowImpl(28),gx.O.A28PV_NPRO,0)},c2v:function(){gx.O.A28PV_NPRO=this.val()},val:function(){return gx.fn.getGridIntegerValue("PV_NPRO",gx.fn.currentGridRowImpl(28),".")},nac:function(){return false}};this.GXValidFnc[33]={lvl:2,type:"char",len:30,dec:0,sign:false,ro:1,grid:28,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"PV_DESC",gxz:"Z5PV_DESC",gxold:"O5PV_DESC",gxvar:"A5PV_DESC",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A5PV_DESC=a
},v2z:function(a){gx.O.Z5PV_DESC=a},v2c:function(){gx.fn.setGridControlValue("PV_DESC",gx.fn.currentGridRowImpl(28),gx.O.A5PV_DESC,0)},c2v:function(){gx.O.A5PV_DESC=this.val()},val:function(){return gx.fn.getGridControlValue("PV_DESC",gx.fn.currentGridRowImpl(28))},nac:function(){return false}};this.AV10fPV_NPRO=0;this.ZV10fPV_NPRO=0;this.OV10fPV_NPRO=0;this.AV11fPV_DESC="";this.ZV11fPV_DESC="";this.OV11fPV_DESC="";this.ZV5baja="";this.OV5baja="";this.ZV6edicion="";this.OV6edicion="";this.ZV7visualizacion="";
this.OV7visualizacion="";this.Z28PV_NPRO=0;this.O28PV_NPRO=0;this.Z5PV_DESC="";this.O5PV_DESC="";this.AV8SISTEMA="";this.AV9USUARIO="";this.AV5baja="";this.AV6edicion="";this.AV7visualizacion="";this.A28PV_NPRO=0;this.A5PV_DESC="";this.A40TTBUS8_CodUsuario="";this.ServerEvents=["e125h2_client","e155h2_client","e165h2_client","e175h2_client","e115h2_client","e185h2_client","e195h2_client"];this.VarControlMap.AV8SISTEMA={id:"vSISTEMA",grid:0,type:"char"};this.VarControlMap.AV9USUARIO={id:"vUSUARIO",grid:0,type:"char"};
this.Grid1Container.addRefreshingVar(this.GXValidFnc[13]);this.Grid1Container.addRefreshingVar(this.GXValidFnc[18]);this.Grid1Container.addRefreshingVar({rfrVar:"AV6edicion",rfrProp:"Visible"});this.Grid1Container.addRefreshingVar({rfrVar:"AV5baja",rfrProp:"Visible"});this.SetStandaloneVars()}hm124fprov.prototype=new gx.GxObject;gx.setParentObj(new hm124fprov());