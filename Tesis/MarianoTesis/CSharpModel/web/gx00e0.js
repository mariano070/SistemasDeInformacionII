gx.evt.autoSkip=false;function gx00e0(){this.ServerClass="Gx00E0";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=true;this.autoRefresh=true;this.SetStandaloneVars=function(){this.AV9pTTBUS75_Orden=gx.fn.getIntegerValue("vPTTBUS75_ORDEN",".")};this.e132z2_client=function(){this.executeServerEvent("ENTER",true,arguments[0])};this.e142z2_client=function(){this.executeServerEvent("CANCEL",true,arguments[0])};this.GXValidFnc=[];this.GXCtrlIds=[2,8,9,14,19,24,27,28,32,33,34,35,38];
this.GXLastCtrlId=38;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",31,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx00e0",[],false,1,false,true,10,true,false,false,"",0,"px","Nueva fila",true,false,false,null,null,false,"");this.Grid1Container.addBitmap("&Linkselection","vLINKSELECTION",32,0,"px",17,"px",null,"","");this.Grid1Container.addSingleLineEdit(243,33,"TTBUS75_ORDEN","del cambio","","TTBUS75_Orden","int",0,"px",4,4,"right",null,[],243,"TTBUS75_Orden",true,0,false,false);
this.Grid1Container.addSingleLineEdit(244,34,"TTBUS75_POSANTERIOR","Anterior","Seleccionar","TTBUS75_PosAnterior","int",0,"px",3,3,"right",null,[],244,"TTBUS75_PosAnterior",true,0,false,false);this.Grid1Container.addSingleLineEdit(245,35,"TTBUS75_POSNUEVA","Nueva","","TTBUS75_PosNueva","int",0,"px",3,3,"right",null,[],245,"TTBUS75_PosNueva",true,0,false,false);this.setGrid(this.Grid1Container);this.GXValidFnc[2]={fld:"TABLE1",grid:0};this.GXValidFnc[8]={fld:"GROUP1",grid:0};this.GXValidFnc[9]={fld:"TABLE2",grid:0};
this.GXValidFnc[12]={fld:"TEXTBLOCKTTBUS75_ORDEN",format:0,grid:0};this.GXValidFnc[14]={lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCTTBUS75_ORDEN",gxz:"ZV6cTTBUS75_Orden",gxold:"OV6cTTBUS75_Orden",gxvar:"AV6cTTBUS75_Orden",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV6cTTBUS75_Orden=gx.num.intval(a)},v2z:function(a){gx.O.ZV6cTTBUS75_Orden=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("vCTTBUS75_ORDEN",gx.O.AV6cTTBUS75_Orden,0)
},c2v:function(){gx.O.AV6cTTBUS75_Orden=this.val()},val:function(){return gx.fn.getIntegerValue("vCTTBUS75_ORDEN",".")},nac:function(){return false}};this.GXValidFnc[17]={fld:"TEXTBLOCKTTBUS75_POSANTERIOR",format:0,grid:0};this.GXValidFnc[19]={lvl:0,type:"int",len:3,dec:0,sign:false,pic:"ZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCTTBUS75_POSANTERIOR",gxz:"ZV7cTTBUS75_PosAnterior",gxold:"OV7cTTBUS75_PosAnterior",gxvar:"AV7cTTBUS75_PosAnterior",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV7cTTBUS75_PosAnterior=gx.num.intval(a)
},v2z:function(a){gx.O.ZV7cTTBUS75_PosAnterior=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("vCTTBUS75_POSANTERIOR",gx.O.AV7cTTBUS75_PosAnterior,0)},c2v:function(){gx.O.AV7cTTBUS75_PosAnterior=this.val()},val:function(){return gx.fn.getIntegerValue("vCTTBUS75_POSANTERIOR",".")},nac:function(){return false}};this.GXValidFnc[22]={fld:"TEXTBLOCKTTBUS75_POSNUEVA",format:0,grid:0};this.GXValidFnc[24]={lvl:0,type:"int",len:3,dec:0,sign:false,pic:"ZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCTTBUS75_POSNUEVA",gxz:"ZV8cTTBUS75_PosNueva",gxold:"OV8cTTBUS75_PosNueva",gxvar:"AV8cTTBUS75_PosNueva",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV8cTTBUS75_PosNueva=gx.num.intval(a)
},v2z:function(a){gx.O.ZV8cTTBUS75_PosNueva=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("vCTTBUS75_POSNUEVA",gx.O.AV8cTTBUS75_PosNueva,0)},c2v:function(){gx.O.AV8cTTBUS75_PosNueva=this.val()},val:function(){return gx.fn.getIntegerValue("vCTTBUS75_POSNUEVA",".")},nac:function(){return false}};this.GXValidFnc[27]={fld:"GROUP2",grid:0};this.GXValidFnc[28]={fld:"TABLE3",grid:0};this.GXValidFnc[32]={lvl:2,type:"bits",len:4,dec:0,sign:false,ro:1,grid:31,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV5LinkSelection=a
},v2z:function(a){gx.O.ZV5LinkSelection=a},v2c:function(){},c2v:function(){gx.O.AV5LinkSelection=this.val()},val:function(){return gx.fn.getGridControlValue("vLINKSELECTION",gx.fn.currentGridRowImpl(31))},nac:function(){return false}};this.GXValidFnc[33]={lvl:2,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:1,grid:31,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"TTBUS75_ORDEN",gxz:"Z243TTBUS75_Orden",gxold:"O243TTBUS75_Orden",gxvar:"A243TTBUS75_Orden",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A243TTBUS75_Orden=gx.num.intval(a)
},v2z:function(a){gx.O.Z243TTBUS75_Orden=gx.num.intval(a)},v2c:function(){gx.fn.setGridControlValue("TTBUS75_ORDEN",gx.fn.currentGridRowImpl(31),gx.O.A243TTBUS75_Orden,0)},c2v:function(){gx.O.A243TTBUS75_Orden=this.val()},val:function(){return gx.fn.getGridIntegerValue("TTBUS75_ORDEN",gx.fn.currentGridRowImpl(31),".")},nac:function(){return false}};this.GXValidFnc[34]={lvl:2,type:"int",len:3,dec:0,sign:false,pic:"ZZ9",ro:1,grid:31,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"TTBUS75_POSANTERIOR",gxz:"Z244TTBUS75_PosAnterior",gxold:"O244TTBUS75_PosAnterior",gxvar:"A244TTBUS75_PosAnterior",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A244TTBUS75_PosAnterior=gx.num.intval(a)
},v2z:function(a){gx.O.Z244TTBUS75_PosAnterior=gx.num.intval(a)},v2c:function(){gx.fn.setGridControlValue("TTBUS75_POSANTERIOR",gx.fn.currentGridRowImpl(31),gx.O.A244TTBUS75_PosAnterior,0)},c2v:function(){gx.O.A244TTBUS75_PosAnterior=this.val()},val:function(){return gx.fn.getGridIntegerValue("TTBUS75_POSANTERIOR",gx.fn.currentGridRowImpl(31),".")},nac:function(){return false}};this.GXValidFnc[35]={lvl:2,type:"int",len:3,dec:0,sign:false,pic:"ZZ9",ro:1,grid:31,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"TTBUS75_POSNUEVA",gxz:"Z245TTBUS75_PosNueva",gxold:"O245TTBUS75_PosNueva",gxvar:"A245TTBUS75_PosNueva",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A245TTBUS75_PosNueva=gx.num.intval(a)
},v2z:function(a){gx.O.Z245TTBUS75_PosNueva=gx.num.intval(a)},v2c:function(){gx.fn.setGridControlValue("TTBUS75_POSNUEVA",gx.fn.currentGridRowImpl(31),gx.O.A245TTBUS75_PosNueva,0)},c2v:function(){gx.O.A245TTBUS75_PosNueva=this.val()},val:function(){return gx.fn.getGridIntegerValue("TTBUS75_POSNUEVA",gx.fn.currentGridRowImpl(31),".")},nac:function(){return false}};this.GXValidFnc[38]={fld:"TABLE4",grid:0};this.AV6cTTBUS75_Orden=0;this.ZV6cTTBUS75_Orden=0;this.OV6cTTBUS75_Orden=0;this.AV7cTTBUS75_PosAnterior=0;
this.ZV7cTTBUS75_PosAnterior=0;this.OV7cTTBUS75_PosAnterior=0;this.AV8cTTBUS75_PosNueva=0;this.ZV8cTTBUS75_PosNueva=0;this.OV8cTTBUS75_PosNueva=0;this.ZV5LinkSelection="";this.OV5LinkSelection="";this.Z243TTBUS75_Orden=0;this.O243TTBUS75_Orden=0;this.Z244TTBUS75_PosAnterior=0;this.O244TTBUS75_PosAnterior=0;this.Z245TTBUS75_PosNueva=0;this.O245TTBUS75_PosNueva=0;this.AV9pTTBUS75_Orden=0;this.AV5LinkSelection="";this.A243TTBUS75_Orden=0;this.A244TTBUS75_PosAnterior=0;this.A245TTBUS75_PosNueva=0;this.ServerEvents=["e132z2_client","e142z2_client"];
this.VarControlMap.AV9pTTBUS75_Orden={id:"vPTTBUS75_ORDEN",grid:0,type:"int"};this.Grid1Container.addRefreshingVar(this.GXValidFnc[14]);this.Grid1Container.addRefreshingVar(this.GXValidFnc[19]);this.Grid1Container.addRefreshingVar(this.GXValidFnc[24]);this.SetStandaloneVars()}gx00e0.prototype=new gx.GxObject;gx.setParentObj(new gx00e0());