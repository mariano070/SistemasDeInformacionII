gx.evt.autoSkip=false;function seg008seg008l1wc(a){this.ServerClass="SEG008SEG008L1WC";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.setCmpContext(a);this.ReadonlyForm=true;this.hasEnterEvent=false;this.autoRefresh=true;this.SetStandaloneVars=function(){};this.e11402_client=function(){this.executeServerEvent("'DOINSERT'",true,arguments[0])};this.e14402_client=function(){this.executeServerEvent("ENTER",true,arguments[0])};this.e15402_client=function(){this.executeServerEvent("CANCEL",true,arguments[0])
};this.GXValidFnc=[];this.GXCtrlIds=[2,5,9,13,14,15,16,17,20,21];this.GXLastCtrlId=21;this.GridContainer=new gx.grid.grid(this,2,"WbpLvl2",12,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"seg008seg008l1wc",[],false,1,false,true,0,true,false,false,"",0,"px","Nueva fila",true,false,false,null,null,false,"");this.GridContainer.addBitmap("&Update","vUPDATE",13,0,"px",17,"px",null,"","");this.GridContainer.addBitmap("&Delete","vDELETE",14,0,"px",17,"px",null,"","");this.GridContainer.addSingleLineEdit(130,15,"MNU_SNI","SUB_NIVEL","","MNU_SNI","int",0,"px",5,5,"right",null,[],130,"MNU_SNI",true,0,false,false);
this.GridContainer.addSingleLineEdit(131,16,"MNU_DSN","DESCRIPCION","","MNU_DSN","char",0,"px",100,100,"left",null,[],131,"MNU_DSN",true,0,false,false);this.GridContainer.addSingleLineEdit(132,17,"MNU_SLINK","LINK","","MNU_SLINK","svchar",0,"px",256,256,"left",null,[],132,"MNU_SLINK",true,0,false,false);this.setGrid(this.GridContainer);this.GXValidFnc[2]={fld:"TABLE",grid:0};this.GXValidFnc[5]={fld:"TABLEGRIDCONTAINER",grid:0};this.GXValidFnc[9]={fld:"INSERT",grid:0};this.GXValidFnc[13]={lvl:2,type:"bits",len:4,dec:0,sign:false,ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"vUPDATE",gxz:"ZV13Update",gxold:"OV13Update",gxvar:"AV13Update",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(b){gx.O.AV13Update=b
},v2z:function(b){gx.O.ZV13Update=b},v2c:function(){},c2v:function(){gx.O.AV13Update=this.val()},val:function(){return gx.fn.getGridControlValue("vUPDATE",gx.fn.currentGridRowImpl(12))},nac:function(){return false}};this.GXValidFnc[14]={lvl:2,type:"bits",len:4,dec:0,sign:false,ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"vDELETE",gxz:"ZV14Delete",gxold:"OV14Delete",gxvar:"AV14Delete",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(b){gx.O.AV14Delete=b},v2z:function(b){gx.O.ZV14Delete=b
},v2c:function(){},c2v:function(){gx.O.AV14Delete=this.val()},val:function(){return gx.fn.getGridControlValue("vDELETE",gx.fn.currentGridRowImpl(12))},nac:function(){return false}};this.GXValidFnc[15]={lvl:2,type:"int",len:5,dec:0,sign:true,pic:"ZZZZ9",ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,rgrid:[],fld:"MNU_SNI",gxz:"Z130MNU_SNI",gxold:"O130MNU_SNI",gxvar:"A130MNU_SNI",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(b){gx.O.A130MNU_SNI=gx.num.intval(b)},v2z:function(b){gx.O.Z130MNU_SNI=gx.num.intval(b)
},v2c:function(){gx.fn.setGridControlValue("MNU_SNI",gx.fn.currentGridRowImpl(12),gx.O.A130MNU_SNI,0)},c2v:function(){gx.O.A130MNU_SNI=this.val()},val:function(){return gx.fn.getGridIntegerValue("MNU_SNI",gx.fn.currentGridRowImpl(12),".")},nac:function(){return false}};this.GXValidFnc[16]={lvl:2,type:"char",len:100,dec:0,sign:false,ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"MNU_DSN",gxz:"Z131MNU_DSN",gxold:"O131MNU_DSN",gxvar:"A131MNU_DSN",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(b){gx.O.A131MNU_DSN=b
},v2z:function(b){gx.O.Z131MNU_DSN=b},v2c:function(){gx.fn.setGridControlValue("MNU_DSN",gx.fn.currentGridRowImpl(12),gx.O.A131MNU_DSN,0)},c2v:function(){gx.O.A131MNU_DSN=this.val()},val:function(){return gx.fn.getGridControlValue("MNU_DSN",gx.fn.currentGridRowImpl(12))},nac:function(){return false}};this.GXValidFnc[17]={lvl:2,type:"svchar",len:256,dec:0,sign:false,ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"MNU_SLINK",gxz:"Z132MNU_SLINK",gxold:"O132MNU_SLINK",gxvar:"A132MNU_SLINK",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(b){gx.O.A132MNU_SLINK=b
},v2z:function(b){gx.O.Z132MNU_SLINK=b},v2c:function(){gx.fn.setGridControlValue("MNU_SLINK",gx.fn.currentGridRowImpl(12),gx.O.A132MNU_SLINK,0)},c2v:function(){gx.O.A132MNU_SLINK=this.val()},val:function(){return gx.fn.getGridControlValue("MNU_SLINK",gx.fn.currentGridRowImpl(12))},nac:function(){return false}};this.GXValidFnc[20]={lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"PRG_COD",gxz:"Z126PRG_COD",gxold:"O126PRG_COD",gxvar:"A126PRG_COD",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(b){gx.O.A126PRG_COD=gx.num.intval(b)
},v2z:function(b){gx.O.Z126PRG_COD=gx.num.intval(b)},v2c:function(){gx.fn.setControlValue("PRG_COD",gx.O.A126PRG_COD,0)},c2v:function(){gx.O.A126PRG_COD=this.val()},val:function(){return gx.fn.getIntegerValue("PRG_COD",".")},nac:function(){return false}};this.GXValidFnc[21]={lvl:0,type:"int",len:6,dec:0,sign:true,pic:"ZZZZZ9",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"MNU_NIV",gxz:"Z361MNU_NIV",gxold:"O361MNU_NIV",gxvar:"A361MNU_NIV",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(b){gx.O.A361MNU_NIV=gx.num.intval(b)
},v2z:function(b){gx.O.Z361MNU_NIV=gx.num.intval(b)},v2c:function(){gx.fn.setControlValue("MNU_NIV",gx.O.A361MNU_NIV,0)},c2v:function(){gx.O.A361MNU_NIV=this.val()},val:function(){return gx.fn.getIntegerValue("MNU_NIV",".")},nac:function(){return false}};this.ZV13Update="";this.OV13Update="";this.ZV14Delete="";this.OV14Delete="";this.Z130MNU_SNI=0;this.O130MNU_SNI=0;this.Z131MNU_DSN="";this.O131MNU_DSN="";this.Z132MNU_SLINK="";this.O132MNU_SLINK="";this.A126PRG_COD=0;this.Z126PRG_COD=0;this.O126PRG_COD=0;
this.A361MNU_NIV=0;this.Z361MNU_NIV=0;this.O361MNU_NIV=0;this.AV7PRG_COD=0;this.AV8MNU_NIV=0;this.AV13Update="";this.AV14Delete="";this.A130MNU_SNI=0;this.A131MNU_DSN="";this.A132MNU_SLINK="";this.ServerEvents=["e11402_client","e14402_client","e15402_client"];this.VarControlMap.AV7PRG_COD={id:"vPRG_COD",grid:0,type:"int"};this.VarControlMap.AV8MNU_NIV={id:"vMNU_NIV",grid:0,type:"int"};this.GridContainer.addRefreshingVar({rfrVar:"AV7PRG_COD"});this.GridContainer.addRefreshingVar({rfrVar:"AV8MNU_NIV"});
this.GridContainer.addRefreshingVar({rfrVar:"AV14Delete",rfrProp:"Tooltiptext"});this.GridContainer.addRefreshingVar({rfrVar:"AV14Delete",rfrProp:"Value"});this.GridContainer.addRefreshingVar({rfrVar:"AV13Update",rfrProp:"Tooltiptext"});this.GridContainer.addRefreshingVar({rfrVar:"AV13Update",rfrProp:"Value"});this.GridContainer.addRefreshingVar(this.GXValidFnc[21]);this.GridContainer.addRefreshingVar(this.GXValidFnc[20]);this.SetStandaloneVars()};