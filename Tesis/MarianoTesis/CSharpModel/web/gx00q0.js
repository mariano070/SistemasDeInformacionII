gx.evt.autoSkip=false;function gx00q0(){this.ServerClass="Gx00Q0";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=true;this.autoRefresh=true;this.SetStandaloneVars=function(){this.AV8pTHDW_UBI_COD_=gx.fn.getIntegerValue("vPTHDW_UBI_COD_",".")};this.e134m2_client=function(){this.executeServerEvent("ENTER",true,arguments[0])};this.e144m2_client=function(){this.executeServerEvent("CANCEL",true,arguments[0])};this.GXValidFnc=[];this.GXCtrlIds=[2,8,9,14,19,22,23,27,28,29,32];
this.GXLastCtrlId=32;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",26,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx00q0",[],false,1,false,true,10,true,false,false,"",0,"px","Nueva fila",true,false,false,null,null,false,"");this.Grid1Container.addBitmap("&Linkselection","vLINKSELECTION",27,0,"px",17,"px",null,"","");this.Grid1Container.addSingleLineEdit(306,28,"THDW_UBI_COD_","Cod.Ubicación","","THDW_UBI_COD_","int",0,"px",10,10,"right",null,[],306,"THDW_UBI_COD_",true,0,false,false);
this.Grid1Container.addSingleLineEdit(307,29,"THDW_UBI_DESC_","Desc. Ubicación","Seleccionar","THDW_UBI_DESC_","char",0,"px",30,30,"left",null,[],307,"THDW_UBI_DESC_",true,0,false,false);this.setGrid(this.Grid1Container);this.GXValidFnc[2]={fld:"TABLE1",grid:0};this.GXValidFnc[8]={fld:"GROUP1",grid:0};this.GXValidFnc[9]={fld:"TABLE2",grid:0};this.GXValidFnc[12]={fld:"TEXTBLOCKTHDW_UBI_COD_",format:0,grid:0};this.GXValidFnc[14]={lvl:0,type:"int",len:10,dec:0,sign:false,pic:"ZZZZZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCTHDW_UBI_COD_",gxz:"ZV6cTHDW_UBI_COD_",gxold:"OV6cTHDW_UBI_COD_",gxvar:"AV6cTHDW_UBI_COD_",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV6cTHDW_UBI_COD_=gx.num.intval(a)
},v2z:function(a){gx.O.ZV6cTHDW_UBI_COD_=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("vCTHDW_UBI_COD_",gx.O.AV6cTHDW_UBI_COD_,0)},c2v:function(){gx.O.AV6cTHDW_UBI_COD_=this.val()},val:function(){return gx.fn.getIntegerValue("vCTHDW_UBI_COD_",".")},nac:function(){return false}};this.GXValidFnc[17]={fld:"TEXTBLOCKTHDW_UBI_DESC_",format:0,grid:0};this.GXValidFnc[19]={lvl:0,type:"char",len:30,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vCTHDW_UBI_DESC_",gxz:"ZV7cTHDW_UBI_DESC_",gxold:"OV7cTHDW_UBI_DESC_",gxvar:"AV7cTHDW_UBI_DESC_",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV7cTHDW_UBI_DESC_=a
},v2z:function(a){gx.O.ZV7cTHDW_UBI_DESC_=a},v2c:function(){gx.fn.setControlValue("vCTHDW_UBI_DESC_",gx.O.AV7cTHDW_UBI_DESC_,0)},c2v:function(){gx.O.AV7cTHDW_UBI_DESC_=this.val()},val:function(){return gx.fn.getControlValue("vCTHDW_UBI_DESC_")},nac:function(){return false}};this.GXValidFnc[22]={fld:"GROUP2",grid:0};this.GXValidFnc[23]={fld:"TABLE3",grid:0};this.GXValidFnc[27]={lvl:2,type:"bits",len:4,dec:0,sign:false,ro:1,grid:26,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV5LinkSelection=a
},v2z:function(a){gx.O.ZV5LinkSelection=a},v2c:function(){},c2v:function(){gx.O.AV5LinkSelection=this.val()},val:function(){return gx.fn.getGridControlValue("vLINKSELECTION",gx.fn.currentGridRowImpl(26))},nac:function(){return false}};this.GXValidFnc[28]={lvl:2,type:"int",len:10,dec:0,sign:false,pic:"ZZZZZZZZZ9",ro:1,grid:26,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"THDW_UBI_COD_",gxz:"Z306THDW_UBI_COD_",gxold:"O306THDW_UBI_COD_",gxvar:"A306THDW_UBI_COD_",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A306THDW_UBI_COD_=gx.num.intval(a)
},v2z:function(a){gx.O.Z306THDW_UBI_COD_=gx.num.intval(a)},v2c:function(){gx.fn.setGridControlValue("THDW_UBI_COD_",gx.fn.currentGridRowImpl(26),gx.O.A306THDW_UBI_COD_,0)},c2v:function(){gx.O.A306THDW_UBI_COD_=this.val()},val:function(){return gx.fn.getGridIntegerValue("THDW_UBI_COD_",gx.fn.currentGridRowImpl(26),".")},nac:function(){return false}};this.GXValidFnc[29]={lvl:2,type:"char",len:30,dec:0,sign:false,ro:1,grid:26,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"THDW_UBI_DESC_",gxz:"Z307THDW_UBI_DESC_",gxold:"O307THDW_UBI_DESC_",gxvar:"A307THDW_UBI_DESC_",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A307THDW_UBI_DESC_=a
},v2z:function(a){gx.O.Z307THDW_UBI_DESC_=a},v2c:function(){gx.fn.setGridControlValue("THDW_UBI_DESC_",gx.fn.currentGridRowImpl(26),gx.O.A307THDW_UBI_DESC_,0)},c2v:function(){gx.O.A307THDW_UBI_DESC_=this.val()},val:function(){return gx.fn.getGridControlValue("THDW_UBI_DESC_",gx.fn.currentGridRowImpl(26))},nac:function(){return false}};this.GXValidFnc[32]={fld:"TABLE4",grid:0};this.AV6cTHDW_UBI_COD_=0;this.ZV6cTHDW_UBI_COD_=0;this.OV6cTHDW_UBI_COD_=0;this.AV7cTHDW_UBI_DESC_="";this.ZV7cTHDW_UBI_DESC_="";
this.OV7cTHDW_UBI_DESC_="";this.ZV5LinkSelection="";this.OV5LinkSelection="";this.Z306THDW_UBI_COD_=0;this.O306THDW_UBI_COD_=0;this.Z307THDW_UBI_DESC_="";this.O307THDW_UBI_DESC_="";this.AV8pTHDW_UBI_COD_=0;this.AV5LinkSelection="";this.A306THDW_UBI_COD_=0;this.A307THDW_UBI_DESC_="";this.ServerEvents=["e134m2_client","e144m2_client"];this.VarControlMap.AV8pTHDW_UBI_COD_={id:"vPTHDW_UBI_COD_",grid:0,type:"int"};this.Grid1Container.addRefreshingVar(this.GXValidFnc[14]);this.Grid1Container.addRefreshingVar(this.GXValidFnc[19]);
this.SetStandaloneVars()}gx00q0.prototype=new gx.GxObject;gx.setParentObj(new gx00q0());