gx.evt.autoSkip=false;function gx00l2(){this.ServerClass="Gx00L2";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=true;this.autoRefresh=true;this.SetStandaloneVars=function(){this.AV8pUSU_COD=gx.fn.getControlValue("vPUSU_COD");this.AV9pSIS_COD=gx.fn.getIntegerValue("vPSIS_COD",".");this.AV10pPRG_COD=gx.fn.getIntegerValue("vPPRG_COD",".")};this.e134c2_client=function(){this.executeServerEvent("ENTER",true,arguments[0])};this.e144c2_client=function(){this.executeServerEvent("CANCEL",true,arguments[0])
};this.GXValidFnc=[];this.GXCtrlIds=[2,8,9,14,17,18,22,23,24,25,28];this.GXLastCtrlId=28;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",21,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx00l2",[],false,1,false,true,10,true,false,false,"",0,"px","Nueva fila",true,false,false,null,null,false,"");this.Grid1Container.addBitmap("&Linkselection","vLINKSELECTION",22,0,"px",17,"px",null,"","");this.Grid1Container.addSingleLineEdit(126,23,"PRG_COD","CODIGO","Seleccionar","PRG_COD","int",0,"px",4,4,"right",null,[],126,"PRG_COD",true,0,false,false);
this.Grid1Container.addSingleLineEdit(6,24,"USU_COD","CODIGO","","USU_COD","char",0,"px",16,16,"left",null,[],6,"USU_COD",false,0,false,false);this.Grid1Container.addSingleLineEdit(116,25,"SIS_COD","CODIGO","","SIS_COD","int",0,"px",3,3,"right",null,[],116,"SIS_COD",false,0,false,false);this.setGrid(this.Grid1Container);this.GXValidFnc[2]={fld:"TABLE1",grid:0};this.GXValidFnc[8]={fld:"GROUP1",grid:0};this.GXValidFnc[9]={fld:"TABLE2",grid:0};this.GXValidFnc[12]={fld:"TEXTBLOCKPRG_COD",format:0,grid:0};
this.GXValidFnc[14]={lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCPRG_COD",gxz:"ZV6cPRG_COD",gxold:"OV6cPRG_COD",gxvar:"AV6cPRG_COD",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV6cPRG_COD=gx.num.intval(a)},v2z:function(a){gx.O.ZV6cPRG_COD=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("vCPRG_COD",gx.O.AV6cPRG_COD,0)},c2v:function(){gx.O.AV6cPRG_COD=this.val()},val:function(){return gx.fn.getIntegerValue("vCPRG_COD",".")
},nac:function(){return false}};this.GXValidFnc[17]={fld:"GROUP2",grid:0};this.GXValidFnc[18]={fld:"TABLE3",grid:0};this.GXValidFnc[22]={lvl:2,type:"bits",len:4,dec:0,sign:false,ro:1,grid:21,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV5LinkSelection=a},v2z:function(a){gx.O.ZV5LinkSelection=a},v2c:function(){},c2v:function(){gx.O.AV5LinkSelection=this.val()
},val:function(){return gx.fn.getGridControlValue("vLINKSELECTION",gx.fn.currentGridRowImpl(21))},nac:function(){return false}};this.GXValidFnc[23]={lvl:2,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:1,grid:21,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"PRG_COD",gxz:"Z126PRG_COD",gxold:"O126PRG_COD",gxvar:"A126PRG_COD",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A126PRG_COD=gx.num.intval(a)},v2z:function(a){gx.O.Z126PRG_COD=gx.num.intval(a)},v2c:function(){gx.fn.setGridControlValue("PRG_COD",gx.fn.currentGridRowImpl(21),gx.O.A126PRG_COD,0)
},c2v:function(){gx.O.A126PRG_COD=this.val()},val:function(){return gx.fn.getGridIntegerValue("PRG_COD",gx.fn.currentGridRowImpl(21),".")},nac:function(){return false}};this.GXValidFnc[24]={lvl:2,type:"char",len:16,dec:0,sign:false,ro:1,grid:21,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"USU_COD",gxz:"Z6USU_COD",gxold:"O6USU_COD",gxvar:"A6USU_COD",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A6USU_COD=a},v2z:function(a){gx.O.Z6USU_COD=a},v2c:function(){gx.fn.setGridControlValue("USU_COD",gx.fn.currentGridRowImpl(21),gx.O.A6USU_COD,0)
},c2v:function(){gx.O.A6USU_COD=this.val()},val:function(){return gx.fn.getGridControlValue("USU_COD",gx.fn.currentGridRowImpl(21))},nac:function(){return false}};this.GXValidFnc[25]={lvl:2,type:"int",len:3,dec:0,sign:false,pic:"ZZ9",ro:1,grid:21,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"SIS_COD",gxz:"Z116SIS_COD",gxold:"O116SIS_COD",gxvar:"A116SIS_COD",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A116SIS_COD=gx.num.intval(a)},v2z:function(a){gx.O.Z116SIS_COD=gx.num.intval(a)
},v2c:function(){gx.fn.setGridControlValue("SIS_COD",gx.fn.currentGridRowImpl(21),gx.O.A116SIS_COD,0)},c2v:function(){gx.O.A116SIS_COD=this.val()},val:function(){return gx.fn.getGridIntegerValue("SIS_COD",gx.fn.currentGridRowImpl(21),".")},nac:function(){return false}};this.GXValidFnc[28]={fld:"TABLE4",grid:0};this.AV6cPRG_COD=0;this.ZV6cPRG_COD=0;this.OV6cPRG_COD=0;this.ZV5LinkSelection="";this.OV5LinkSelection="";this.Z126PRG_COD=0;this.O126PRG_COD=0;this.Z6USU_COD="";this.O6USU_COD="";this.Z116SIS_COD=0;
this.O116SIS_COD=0;this.AV8pUSU_COD="";this.AV9pSIS_COD=0;this.AV10pPRG_COD=0;this.AV5LinkSelection="";this.A126PRG_COD=0;this.A6USU_COD="";this.A116SIS_COD=0;this.ServerEvents=["e134c2_client","e144c2_client"];this.VarControlMap.AV8pUSU_COD={id:"vPUSU_COD",grid:0,type:"char"};this.VarControlMap.AV9pSIS_COD={id:"vPSIS_COD",grid:0,type:"int"};this.VarControlMap.AV10pPRG_COD={id:"vPPRG_COD",grid:0,type:"int"};this.VarControlMap.AV8pUSU_COD={id:"vPUSU_COD",grid:0,type:"char"};this.VarControlMap.AV9pSIS_COD={id:"vPSIS_COD",grid:0,type:"int"};
this.Grid1Container.addRefreshingVar(this.GXValidFnc[14]);this.Grid1Container.addRefreshingVar({rfrVar:"AV8pUSU_COD"});this.Grid1Container.addRefreshingVar({rfrVar:"AV9pSIS_COD"});this.SetStandaloneVars()}gx00l2.prototype=new gx.GxObject;gx.setParentObj(new gx00l2());