gx.evt.autoSkip=false;function gx00v0(){this.ServerClass="Gx00V0";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=true;this.autoRefresh=true;this.SetStandaloneVars=function(){this.AV9pW53POS=gx.fn.getIntegerValue("vPW53POS",".")};this.e134o2_client=function(){this.executeServerEvent("ENTER",true,arguments[0])};this.e144o2_client=function(){this.executeServerEvent("CANCEL",true,arguments[0])};this.GXValidFnc=[];this.GXCtrlIds=[2,8,9,14,19,22,23,27,28,29,32];this.GXLastCtrlId=32;
this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",26,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx00v0",[],false,1,false,true,10,true,false,false,"",0,"px","Nueva fila",true,false,false,null,null,false,"");this.Grid1Container.addBitmap("&Linkselection","vLINKSELECTION",27,0,"px",17,"px",null,"","");this.Grid1Container.addSingleLineEdit(31,28,"W53POS","Id. Posición","","W53POS","int",0,"px",3,3,"right",null,[],31,"W53POS",true,0,false,false);this.Grid1Container.addSingleLineEdit(32,29,"W53DES","Descripción","Seleccionar","W53DES","char",0,"px",50,50,"left",null,[],32,"W53DES",true,0,false,false);
this.setGrid(this.Grid1Container);this.GXValidFnc[2]={fld:"TABLE1",grid:0};this.GXValidFnc[8]={fld:"GROUP1",grid:0};this.GXValidFnc[9]={fld:"TABLE2",grid:0};this.GXValidFnc[12]={fld:"TEXTBLOCKW53POS",format:0,grid:0};this.GXValidFnc[14]={lvl:0,type:"int",len:3,dec:0,sign:false,pic:"ZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCW53POS",gxz:"ZV6cW53POS",gxold:"OV6cW53POS",gxvar:"AV6cW53POS",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV6cW53POS=gx.num.intval(a)
},v2z:function(a){gx.O.ZV6cW53POS=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("vCW53POS",gx.O.AV6cW53POS,0)},c2v:function(){gx.O.AV6cW53POS=this.val()},val:function(){return gx.fn.getIntegerValue("vCW53POS",".")},nac:function(){return false}};this.GXValidFnc[17]={fld:"TEXTBLOCKW53DES",format:0,grid:0};this.GXValidFnc[19]={lvl:0,type:"char",len:50,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vCW53DES",gxz:"ZV7cW53DES",gxold:"OV7cW53DES",gxvar:"AV7cW53DES",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV7cW53DES=a
},v2z:function(a){gx.O.ZV7cW53DES=a},v2c:function(){gx.fn.setControlValue("vCW53DES",gx.O.AV7cW53DES,0)},c2v:function(){gx.O.AV7cW53DES=this.val()},val:function(){return gx.fn.getControlValue("vCW53DES")},nac:function(){return false}};this.GXValidFnc[22]={fld:"GROUP2",grid:0};this.GXValidFnc[23]={fld:"TABLE3",grid:0};this.GXValidFnc[27]={lvl:2,type:"bits",len:4,dec:0,sign:false,ro:1,grid:26,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV5LinkSelection=a
},v2z:function(a){gx.O.ZV5LinkSelection=a},v2c:function(){},c2v:function(){gx.O.AV5LinkSelection=this.val()},val:function(){return gx.fn.getGridControlValue("vLINKSELECTION",gx.fn.currentGridRowImpl(26))},nac:function(){return false}};this.GXValidFnc[28]={lvl:2,type:"int",len:3,dec:0,sign:false,pic:"ZZ9",ro:1,grid:26,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"W53POS",gxz:"Z31W53POS",gxold:"O31W53POS",gxvar:"A31W53POS",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A31W53POS=gx.num.intval(a)
},v2z:function(a){gx.O.Z31W53POS=gx.num.intval(a)},v2c:function(){gx.fn.setGridControlValue("W53POS",gx.fn.currentGridRowImpl(26),gx.O.A31W53POS,0)},c2v:function(){gx.O.A31W53POS=this.val()},val:function(){return gx.fn.getGridIntegerValue("W53POS",gx.fn.currentGridRowImpl(26),".")},nac:function(){return false}};this.GXValidFnc[29]={lvl:2,type:"char",len:50,dec:0,sign:false,ro:1,grid:26,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"W53DES",gxz:"Z32W53DES",gxold:"O32W53DES",gxvar:"A32W53DES",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A32W53DES=a
},v2z:function(a){gx.O.Z32W53DES=a},v2c:function(){gx.fn.setGridControlValue("W53DES",gx.fn.currentGridRowImpl(26),gx.O.A32W53DES,0)},c2v:function(){gx.O.A32W53DES=this.val()},val:function(){return gx.fn.getGridControlValue("W53DES",gx.fn.currentGridRowImpl(26))},nac:function(){return false}};this.GXValidFnc[32]={fld:"TABLE4",grid:0};this.AV6cW53POS=0;this.ZV6cW53POS=0;this.OV6cW53POS=0;this.AV7cW53DES="";this.ZV7cW53DES="";this.OV7cW53DES="";this.ZV5LinkSelection="";this.OV5LinkSelection="";this.Z31W53POS=0;
this.O31W53POS=0;this.Z32W53DES="";this.O32W53DES="";this.AV9pW53POS=0;this.AV5LinkSelection="";this.A31W53POS=0;this.A32W53DES="";this.ServerEvents=["e134o2_client","e144o2_client"];this.VarControlMap.AV9pW53POS={id:"vPW53POS",grid:0,type:"int"};this.Grid1Container.addRefreshingVar(this.GXValidFnc[14]);this.Grid1Container.addRefreshingVar(this.GXValidFnc[19]);this.SetStandaloneVars()}gx00v0.prototype=new gx.GxObject;gx.setParentObj(new gx00v0());