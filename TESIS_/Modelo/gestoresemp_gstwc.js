gx.evt.autoSkip=false;function gestoresemp_gstwc(a){this.ServerClass="GESTORESEMP_GSTWC";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.setCmpContext(a);this.ReadonlyForm=true;this.hasEnterEvent=false;this.autoRefresh=true;this.SetStandaloneVars=function(){};this.e110y2_client=function(){this.executeServerEvent("'DOINSERT'",true,arguments[0])};this.e140y2_client=function(){this.executeServerEvent("ENTER",true,arguments[0])};this.e150y2_client=function(){this.executeServerEvent("CANCEL",true,arguments[0])
};this.GXValidFnc=[];this.GXCtrlIds=[2,5,9,13,14,15,16,17,20];this.GXLastCtrlId=20;this.GridContainer=new gx.grid.grid(this,2,"WbpLvl2",12,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"gestoresemp_gstwc",[],false,1,false,true,0,true,false,false,"",0,"px","Nueva fila",true,false,false,null,null,false,"");this.GridContainer.addBitmap("&Update","vUPDATE",13,0,"px",17,"px",null,"","");this.GridContainer.addBitmap("&Delete","vDELETE",14,0,"px",17,"px",null,"","");this.GridContainer.addSingleLineEdit(291,15,"EMPGSTCOD","Gst Cod","","EmpGstCod","int",0,"px",8,8,"right",null,[],291,"EmpGstCod",true,0,false,false);
this.GridContainer.addSingleLineEdit(293,16,"EMPGSTDES","Gst Des","","EmpGstDes","int",0,"px",4,4,"right",null,[],293,"EmpGstDes",true,0,false,false);this.GridContainer.addSingleLineEdit(295,17,"EMPGSTGPOCOD","Gpo Cod","","EmpGstGpoCod","int",0,"px",4,4,"right",null,[],295,"EmpGstGpoCod",true,0,false,false);this.setGrid(this.GridContainer);this.GXValidFnc[2]={fld:"TABLE",grid:0};this.GXValidFnc[5]={fld:"TABLEGRIDCONTAINER",grid:0};this.GXValidFnc[9]={fld:"INSERT",grid:0};this.GXValidFnc[13]={lvl:2,type:"bits",len:4,dec:0,sign:false,ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"vUPDATE",gxz:"ZV12Update",gxold:"OV12Update",gxvar:"AV12Update",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(b){gx.O.AV12Update=b
},v2z:function(b){gx.O.ZV12Update=b},v2c:function(){},c2v:function(){gx.O.AV12Update=this.val()},val:function(){return gx.fn.getGridControlValue("vUPDATE",gx.fn.currentGridRowImpl(12))},nac:function(){return false}};this.GXValidFnc[14]={lvl:2,type:"bits",len:4,dec:0,sign:false,ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,fld:"vDELETE",gxz:"ZV13Delete",gxold:"OV13Delete",gxvar:"AV13Delete",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(b){gx.O.AV13Delete=b},v2z:function(b){gx.O.ZV13Delete=b
},v2c:function(){},c2v:function(){gx.O.AV13Delete=this.val()},val:function(){return gx.fn.getGridControlValue("vDELETE",gx.fn.currentGridRowImpl(12))},nac:function(){return false}};this.GXValidFnc[15]={lvl:2,type:"int",len:8,dec:0,sign:true,pic:"ZZZZZZZ9",ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,rgrid:[],fld:"EMPGSTCOD",gxz:"Z291EmpGstCod",gxold:"O291EmpGstCod",gxvar:"A291EmpGstCod",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(b){gx.O.A291EmpGstCod=gx.num.intval(b)
},v2z:function(b){gx.O.Z291EmpGstCod=gx.num.intval(b)},v2c:function(){gx.fn.setGridControlValue("EMPGSTCOD",gx.fn.currentGridRowImpl(12),gx.O.A291EmpGstCod,0)},c2v:function(){gx.O.A291EmpGstCod=this.val()},val:function(){return gx.fn.getGridIntegerValue("EMPGSTCOD",gx.fn.currentGridRowImpl(12),".")},nac:function(){return false}};this.GXValidFnc[16]={lvl:2,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,rgrid:[],fld:"EMPGSTDES",gxz:"Z293EmpGstDes",gxold:"O293EmpGstDes",gxvar:"A293EmpGstDes",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(b){gx.O.A293EmpGstDes=gx.num.intval(b)
},v2z:function(b){gx.O.Z293EmpGstDes=gx.num.intval(b)},v2c:function(){gx.fn.setGridControlValue("EMPGSTDES",gx.fn.currentGridRowImpl(12),gx.O.A293EmpGstDes,0)},c2v:function(){gx.O.A293EmpGstDes=this.val()},val:function(){return gx.fn.getGridIntegerValue("EMPGSTDES",gx.fn.currentGridRowImpl(12),".")},nac:function(){return false}};this.GXValidFnc[17]={lvl:2,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:1,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,rgrid:[],fld:"EMPGSTGPOCOD",gxz:"Z295EmpGstGpoCod",gxold:"O295EmpGstGpoCod",gxvar:"A295EmpGstGpoCod",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(b){gx.O.A295EmpGstGpoCod=gx.num.intval(b)
},v2z:function(b){gx.O.Z295EmpGstGpoCod=gx.num.intval(b)},v2c:function(){gx.fn.setGridControlValue("EMPGSTGPOCOD",gx.fn.currentGridRowImpl(12),gx.O.A295EmpGstGpoCod,0)},c2v:function(){gx.O.A295EmpGstGpoCod=this.val()},val:function(){return gx.fn.getGridIntegerValue("EMPGSTGPOCOD",gx.fn.currentGridRowImpl(12),".")},nac:function(){return false}};this.GXValidFnc[20]={lvl:0,type:"char",len:15,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"GSTEMPCOD",gxz:"Z297GstEmpCod",gxold:"O297GstEmpCod",gxvar:"A297GstEmpCod",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(b){gx.O.A297GstEmpCod=b
},v2z:function(b){gx.O.Z297GstEmpCod=b},v2c:function(){gx.fn.setControlValue("GSTEMPCOD",gx.O.A297GstEmpCod,0)},c2v:function(){gx.O.A297GstEmpCod=this.val()},val:function(){return gx.fn.getControlValue("GSTEMPCOD")},nac:function(){return false}};this.ZV12Update="";this.OV12Update="";this.ZV13Delete="";this.OV13Delete="";this.Z291EmpGstCod=0;this.O291EmpGstCod=0;this.Z293EmpGstDes=0;this.O293EmpGstDes=0;this.Z295EmpGstGpoCod=0;this.O295EmpGstGpoCod=0;this.A297GstEmpCod="";this.Z297GstEmpCod="";this.O297GstEmpCod="";
this.AV7GstEmpCod="";this.AV12Update="";this.AV13Delete="";this.A291EmpGstCod=0;this.A293EmpGstDes=0;this.A295EmpGstGpoCod=0;this.ServerEvents=["e110y2_client","e140y2_client","e150y2_client"];this.VarControlMap.AV7GstEmpCod={id:"vGSTEMPCOD",grid:0,type:"char"};this.GridContainer.addRefreshingVar({rfrVar:"AV7GstEmpCod"});this.GridContainer.addRefreshingVar({rfrVar:"AV13Delete",rfrProp:"Tooltiptext"});this.GridContainer.addRefreshingVar({rfrVar:"AV13Delete",rfrProp:"Value"});this.GridContainer.addRefreshingVar({rfrVar:"AV12Update",rfrProp:"Tooltiptext"});
this.GridContainer.addRefreshingVar({rfrVar:"AV12Update",rfrProp:"Value"});this.SetStandaloneVars()};