gx.evt.autoSkip=false;function gx00t0(){this.ServerClass="Gx00T0";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=true;this.autoRefresh=true;this.SetStandaloneVars=function(){this.AV10pPRG_COD=gx.fn.getIntegerValue("vPPRG_COD",".");this.AV11pMNU_NIV=gx.fn.getIntegerValue("vPMNU_NIV",".");this.AV12pMNU_SNI=gx.fn.getIntegerValue("vPMNU_SNI",".")};this.e134k2_client=function(){this.executeServerEvent("ENTER",true,arguments[0])};this.e144k2_client=function(){this.executeServerEvent("CANCEL",true,arguments[0])
};this.GXValidFnc=[];this.GXCtrlIds=[2,8,9,14,19,24,29,32,33,37,38,39,40,41,44];this.GXLastCtrlId=44;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",36,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx00t0",[],false,1,false,true,10,true,false,false,"",0,"px","Nueva fila",true,false,false,null,null,false,"");this.Grid1Container.addBitmap("&Linkselection","vLINKSELECTION",37,0,"px",17,"px",null,"","");this.Grid1Container.addSingleLineEdit(126,38,"PRG_COD","CODIGO","","PRG_COD","int",0,"px",4,4,"right",null,[],126,"PRG_COD",true,0,false,false);
this.Grid1Container.addSingleLineEdit(361,39,"MNU_NIV","NIVEL","","MNU_NIV","int",0,"px",6,6,"right",null,[],361,"MNU_NIV",true,0,false,false);this.Grid1Container.addSingleLineEdit(130,40,"MNU_SNI","SUB_NIVEL","","MNU_SNI","int",0,"px",5,5,"right",null,[],130,"MNU_SNI",true,0,false,false);this.Grid1Container.addSingleLineEdit(131,41,"MNU_DSN","DESCRIPCION","Seleccionar","MNU_DSN","char",0,"px",100,100,"left",null,[],131,"MNU_DSN",true,0,false,false);this.setGrid(this.Grid1Container);this.GXValidFnc[2]={fld:"TABLE1",grid:0};
this.GXValidFnc[8]={fld:"GROUP1",grid:0};this.GXValidFnc[9]={fld:"TABLE2",grid:0};this.GXValidFnc[12]={fld:"TEXTBLOCKPRG_COD",format:0,grid:0};this.GXValidFnc[14]={lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCPRG_COD",gxz:"ZV6cPRG_COD",gxold:"OV6cPRG_COD",gxvar:"AV6cPRG_COD",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV6cPRG_COD=gx.num.intval(a)},v2z:function(a){gx.O.ZV6cPRG_COD=gx.num.intval(a)
},v2c:function(){gx.fn.setControlValue("vCPRG_COD",gx.O.AV6cPRG_COD,0)},c2v:function(){gx.O.AV6cPRG_COD=this.val()},val:function(){return gx.fn.getIntegerValue("vCPRG_COD",".")},nac:function(){return false}};this.GXValidFnc[17]={fld:"TEXTBLOCKMNU_NIV",format:0,grid:0};this.GXValidFnc[19]={lvl:0,type:"int",len:6,dec:0,sign:true,pic:"ZZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCMNU_NIV",gxz:"ZV7cMNU_NIV",gxold:"OV7cMNU_NIV",gxvar:"AV7cMNU_NIV",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV7cMNU_NIV=gx.num.intval(a)
},v2z:function(a){gx.O.ZV7cMNU_NIV=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("vCMNU_NIV",gx.O.AV7cMNU_NIV,0)},c2v:function(){gx.O.AV7cMNU_NIV=this.val()},val:function(){return gx.fn.getIntegerValue("vCMNU_NIV",".")},nac:function(){return false}};this.GXValidFnc[22]={fld:"TEXTBLOCKMNU_SNI",format:0,grid:0};this.GXValidFnc[24]={lvl:0,type:"int",len:5,dec:0,sign:true,pic:"ZZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCMNU_SNI",gxz:"ZV8cMNU_SNI",gxold:"OV8cMNU_SNI",gxvar:"AV8cMNU_SNI",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV8cMNU_SNI=gx.num.intval(a)
},v2z:function(a){gx.O.ZV8cMNU_SNI=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("vCMNU_SNI",gx.O.AV8cMNU_SNI,0)},c2v:function(){gx.O.AV8cMNU_SNI=this.val()},val:function(){return gx.fn.getIntegerValue("vCMNU_SNI",".")},nac:function(){return false}};this.GXValidFnc[27]={fld:"TEXTBLOCKMNU_DSN",format:0,grid:0};this.GXValidFnc[29]={lvl:0,type:"char",len:100,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vCMNU_DSN",gxz:"ZV9cMNU_DSN",gxold:"OV9cMNU_DSN",gxvar:"AV9cMNU_DSN",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV9cMNU_DSN=a
},v2z:function(a){gx.O.ZV9cMNU_DSN=a},v2c:function(){gx.fn.setControlValue("vCMNU_DSN",gx.O.AV9cMNU_DSN,0)},c2v:function(){gx.O.AV9cMNU_DSN=this.val()},val:function(){return gx.fn.getControlValue("vCMNU_DSN")},nac:function(){return false}};this.GXValidFnc[32]={fld:"GROUP2",grid:0};this.GXValidFnc[33]={fld:"TABLE3",grid:0};this.GXValidFnc[37]={lvl:2,type:"bits",len:4,dec:0,sign:false,ro:1,grid:36,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV5LinkSelection=a
},v2z:function(a){gx.O.ZV5LinkSelection=a},v2c:function(){},c2v:function(){gx.O.AV5LinkSelection=this.val()},val:function(){return gx.fn.getGridControlValue("vLINKSELECTION",gx.fn.currentGridRowImpl(36))},nac:function(){return false}};this.GXValidFnc[38]={lvl:2,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:1,grid:36,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"PRG_COD",gxz:"Z126PRG_COD",gxold:"O126PRG_COD",gxvar:"A126PRG_COD",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A126PRG_COD=gx.num.intval(a)
},v2z:function(a){gx.O.Z126PRG_COD=gx.num.intval(a)},v2c:function(){gx.fn.setGridControlValue("PRG_COD",gx.fn.currentGridRowImpl(36),gx.O.A126PRG_COD,0)},c2v:function(){gx.O.A126PRG_COD=this.val()},val:function(){return gx.fn.getGridIntegerValue("PRG_COD",gx.fn.currentGridRowImpl(36),".")},nac:function(){return false}};this.GXValidFnc[39]={lvl:2,type:"int",len:6,dec:0,sign:true,pic:"ZZZZZ9",ro:1,grid:36,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"MNU_NIV",gxz:"Z361MNU_NIV",gxold:"O361MNU_NIV",gxvar:"A361MNU_NIV",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A361MNU_NIV=gx.num.intval(a)
},v2z:function(a){gx.O.Z361MNU_NIV=gx.num.intval(a)},v2c:function(){gx.fn.setGridControlValue("MNU_NIV",gx.fn.currentGridRowImpl(36),gx.O.A361MNU_NIV,0)},c2v:function(){gx.O.A361MNU_NIV=this.val()},val:function(){return gx.fn.getGridIntegerValue("MNU_NIV",gx.fn.currentGridRowImpl(36),".")},nac:function(){return false}};this.GXValidFnc[40]={lvl:2,type:"int",len:5,dec:0,sign:true,pic:"ZZZZ9",ro:1,grid:36,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"MNU_SNI",gxz:"Z130MNU_SNI",gxold:"O130MNU_SNI",gxvar:"A130MNU_SNI",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A130MNU_SNI=gx.num.intval(a)
},v2z:function(a){gx.O.Z130MNU_SNI=gx.num.intval(a)},v2c:function(){gx.fn.setGridControlValue("MNU_SNI",gx.fn.currentGridRowImpl(36),gx.O.A130MNU_SNI,0)},c2v:function(){gx.O.A130MNU_SNI=this.val()},val:function(){return gx.fn.getGridIntegerValue("MNU_SNI",gx.fn.currentGridRowImpl(36),".")},nac:function(){return false}};this.GXValidFnc[41]={lvl:2,type:"char",len:100,dec:0,sign:false,ro:1,grid:36,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"MNU_DSN",gxz:"Z131MNU_DSN",gxold:"O131MNU_DSN",gxvar:"A131MNU_DSN",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A131MNU_DSN=a
},v2z:function(a){gx.O.Z131MNU_DSN=a},v2c:function(){gx.fn.setGridControlValue("MNU_DSN",gx.fn.currentGridRowImpl(36),gx.O.A131MNU_DSN,0)},c2v:function(){gx.O.A131MNU_DSN=this.val()},val:function(){return gx.fn.getGridControlValue("MNU_DSN",gx.fn.currentGridRowImpl(36))},nac:function(){return false}};this.GXValidFnc[44]={fld:"TABLE4",grid:0};this.AV6cPRG_COD=0;this.ZV6cPRG_COD=0;this.OV6cPRG_COD=0;this.AV7cMNU_NIV=0;this.ZV7cMNU_NIV=0;this.OV7cMNU_NIV=0;this.AV8cMNU_SNI=0;this.ZV8cMNU_SNI=0;this.OV8cMNU_SNI=0;
this.AV9cMNU_DSN="";this.ZV9cMNU_DSN="";this.OV9cMNU_DSN="";this.ZV5LinkSelection="";this.OV5LinkSelection="";this.Z126PRG_COD=0;this.O126PRG_COD=0;this.Z361MNU_NIV=0;this.O361MNU_NIV=0;this.Z130MNU_SNI=0;this.O130MNU_SNI=0;this.Z131MNU_DSN="";this.O131MNU_DSN="";this.AV10pPRG_COD=0;this.AV11pMNU_NIV=0;this.AV12pMNU_SNI=0;this.AV5LinkSelection="";this.A126PRG_COD=0;this.A361MNU_NIV=0;this.A130MNU_SNI=0;this.A131MNU_DSN="";this.ServerEvents=["e134k2_client","e144k2_client"];this.VarControlMap.AV10pPRG_COD={id:"vPPRG_COD",grid:0,type:"int"};
this.VarControlMap.AV11pMNU_NIV={id:"vPMNU_NIV",grid:0,type:"int"};this.VarControlMap.AV12pMNU_SNI={id:"vPMNU_SNI",grid:0,type:"int"};this.Grid1Container.addRefreshingVar(this.GXValidFnc[14]);this.Grid1Container.addRefreshingVar(this.GXValidFnc[19]);this.Grid1Container.addRefreshingVar(this.GXValidFnc[24]);this.Grid1Container.addRefreshingVar(this.GXValidFnc[29]);this.SetStandaloneVars()}gx00t0.prototype=new gx.GxObject;gx.setParentObj(new gx00t0());