gx.evt.autoSkip=false;function htbusseg0(){this.ServerClass="HTBUSSEG0";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=true;this.autoRefresh=true;this.SetStandaloneVars=function(){this.AV21pUSU_COD=gx.fn.getControlValue("vPUSU_COD");this.AV20Modo=gx.fn.getControlValue("vMODO");this.AV18SISTEMA=gx.fn.getControlValue("vSISTEMA");this.AV19USUARIO=gx.fn.getControlValue("vUSUARIO")};this.Validv_Usu_cod=function(){try{var a=gx.util.balloon.getNew("vUSU_COD");this.AnyError=0
}catch(b){}try{if(a==null){return true}return a.show()}catch(b){}return true};this.Validv_W53pos=function(){try{var a=gx.util.balloon.getNew("vW53POS");this.AnyError=0}catch(b){}try{if(a==null){return true}return a.show()}catch(b){}return true};this.e115b2_client=function(){this.executeServerEvent("ENTER",true,arguments[0])};this.e125b2_client=function(){this.executeServerEvent("'CANCELAR'",false,arguments[0])};this.e155b2_client=function(){this.executeServerEvent("CANCEL",true,arguments[0])};this.GXValidFnc=[];
this.GXCtrlIds=[2,5,13,14,19,24,29,34,39,44,49,51,52,53,54,55,56,57];this.GXLastCtrlId=57;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",50,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"htbusseg0",[],false,1,false,true,0,false,false,false,"",0,"px","Nueva fila",false,false,true,null,null,false,"");this.Grid1Container.addSingleLineEdit("W53pos",51,"vW53POS","Cód. Pos.","","W53POS","int",0,"px",3,3,"right",null,[],"W53pos","W53POS",true,0,false,false);this.Grid1Container.addSingleLineEdit("W53des",52,"vW53DES","Posición","","W53DES","char",0,"px",50,50,"left",null,[],"W53des","W53DES",true,0,false,false);
this.Grid1Container.addSingleLineEdit("Usu_resp_cod",53,"vUSU_RESP_COD","Usu_resp_cod","","Usu_resp_cod","char",0,"px",16,16,"left",null,[],"Usu_resp_cod","Usu_resp_cod",false,0,false,false);this.Grid1Container.addSingleLineEdit("Usu_resp",54,"vUSU_RESP","Usuario Responsable","","Usu_Resp","char",0,"px",50,50,"left",null,[],"Usu_resp","Usu_Resp",true,0,false,false);this.Grid1Container.addCheckBox("Responsable",55,"vRESPONSABLE","Responsable","","Responsable","int",1,0,null,true,false,0,"px");this.Grid1Container.addCheckBox("Permiso",56,"vPERMISO","Permiso","","Permiso","int",1,0,null,true,false,0,"px");
this.Grid1Container.addCheckBox("Respaux",57,"vRESPAUX","Responsable Auxiliar","","RespAux","int",1,0,null,true,false,0,"px");this.setGrid(this.Grid1Container);this.GXValidFnc[2]={fld:"TABLE1",grid:0};this.GXValidFnc[5]={fld:"TABLETOOLBAR",grid:0};this.GXValidFnc[13]={fld:"GROUPDATA",grid:0};this.GXValidFnc[14]={fld:"TABLE2",grid:0};this.GXValidFnc[17]={fld:"TEXTBLOCK1",format:0,grid:0};this.GXValidFnc[19]={lvl:0,type:"char",len:16,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Validv_Usu_cod,isvalid:null,fld:"vUSU_COD",gxz:"ZV5USU_COD",gxold:"OV5USU_COD",gxvar:"AV5USU_COD",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV5USU_COD=a
},v2z:function(a){gx.O.ZV5USU_COD=a},v2c:function(){gx.fn.setControlValue("vUSU_COD",gx.O.AV5USU_COD,0)},c2v:function(){gx.O.AV5USU_COD=this.val()},val:function(){return gx.fn.getControlValue("vUSU_COD")},nac:function(){return false}};this.GXValidFnc[22]={fld:"TEXTBLOCK2",format:0,grid:0};this.GXValidFnc[24]={lvl:0,type:"char",len:50,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vUSU_DES",gxz:"ZV6USU_DES",gxold:"OV6USU_DES",gxvar:"AV6USU_DES",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV6USU_DES=a
},v2z:function(a){gx.O.ZV6USU_DES=a},v2c:function(){gx.fn.setControlValue("vUSU_DES",gx.O.AV6USU_DES,0)},c2v:function(){gx.O.AV6USU_DES=this.val()},val:function(){return gx.fn.getControlValue("vUSU_DES")},nac:function(){return false}};this.GXValidFnc[27]={fld:"TEXTBLOCK3",format:0,grid:0};this.GXValidFnc[29]={lvl:0,type:"char",len:20,dec:0,sign:false,isPwd:true,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vUSU_CLA",gxz:"ZV7USU_CLA",gxold:"OV7USU_CLA",gxvar:"AV7USU_CLA",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV7USU_CLA=a
},v2z:function(a){gx.O.ZV7USU_CLA=a},v2c:function(){gx.fn.setControlValue("vUSU_CLA",gx.O.AV7USU_CLA,0)},c2v:function(){gx.O.AV7USU_CLA=this.val()},val:function(){return gx.fn.getControlValue("vUSU_CLA")},nac:function(){return false}};this.GXValidFnc[32]={fld:"TEXTBLOCK7",format:0,grid:0};this.GXValidFnc[34]={lvl:0,type:"char",len:10,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vUSU_INT",gxz:"ZV29USU_INT",gxold:"OV29USU_INT",gxvar:"AV29USU_INT",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV29USU_INT=a
},v2z:function(a){gx.O.ZV29USU_INT=a},v2c:function(){gx.fn.setControlValue("vUSU_INT",gx.O.AV29USU_INT,0)},c2v:function(){gx.O.AV29USU_INT=this.val()},val:function(){return gx.fn.getControlValue("vUSU_INT")},nac:function(){return false}};this.GXValidFnc[37]={fld:"TEXTBLOCK8",format:0,grid:0};this.GXValidFnc[39]={lvl:0,type:"svchar",len:256,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vUSU_MAIW",gxz:"ZV30USU_MAIW",gxold:"OV30USU_MAIW",gxvar:"AV30USU_MAIW",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV30USU_MAIW=a
},v2z:function(a){gx.O.ZV30USU_MAIW=a},v2c:function(){gx.fn.setControlValue("vUSU_MAIW",gx.O.AV30USU_MAIW,0)},c2v:function(){gx.O.AV30USU_MAIW=this.val()},val:function(){return gx.fn.getControlValue("vUSU_MAIW")},nac:function(){return false}};this.GXValidFnc[42]={fld:"TEXTBLOCK4",format:0,grid:0};this.GXValidFnc[44]={lvl:0,type:"int",len:1,dec:0,sign:false,pic:"9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[],fld:"vADMINISTRADOR",gxz:"ZV8Administrador",gxold:"OV8Administrador",gxvar:"AV8Administrador",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"checkbox",v2v:function(a){gx.O.AV8Administrador=gx.num.intval(a)
},v2z:function(a){gx.O.ZV8Administrador=gx.num.intval(a)},v2c:function(){gx.fn.setCheckBoxValue("vADMINISTRADOR",gx.O.AV8Administrador,"1")},c2v:function(){gx.O.AV8Administrador=this.val()},val:function(){return gx.fn.getCheckBoxValue("vADMINISTRADOR","1","0")},nac:function(){return false}};this.GXValidFnc[49]={fld:"GROUPDATA2",grid:0};this.GXValidFnc[51]={lvl:2,type:"int",len:3,dec:0,sign:false,pic:"ZZ9",ro:0,grid:50,gxgrid:this.Grid1Container,fnc:this.Validv_W53pos,isvalid:null,rgrid:[],fld:"vW53POS",gxz:"ZV11W53POS",gxold:"OV11W53POS",gxvar:"AV11W53POS",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV11W53POS=gx.num.intval(a)
},v2z:function(a){gx.O.ZV11W53POS=gx.num.intval(a)},v2c:function(){gx.fn.setGridControlValue("vW53POS",gx.fn.currentGridRowImpl(50),gx.O.AV11W53POS,0)},c2v:function(){gx.O.AV11W53POS=this.val()},val:function(){return gx.fn.getGridIntegerValue("vW53POS",gx.fn.currentGridRowImpl(50),".")},nac:function(){return false}};this.GXValidFnc[52]={lvl:2,type:"char",len:50,dec:0,sign:false,ro:0,grid:50,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"vW53DES",gxz:"ZV12W53DES",gxold:"OV12W53DES",gxvar:"AV12W53DES",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV12W53DES=a
},v2z:function(a){gx.O.ZV12W53DES=a},v2c:function(){gx.fn.setGridControlValue("vW53DES",gx.fn.currentGridRowImpl(50),gx.O.AV12W53DES,0)},c2v:function(){gx.O.AV12W53DES=this.val()},val:function(){return gx.fn.getGridControlValue("vW53DES",gx.fn.currentGridRowImpl(50))},nac:function(){return false}};this.GXValidFnc[53]={lvl:2,type:"char",len:16,dec:0,sign:false,ro:0,grid:50,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"vUSU_RESP_COD",gxz:"ZV28Usu_resp_cod",gxold:"OV28Usu_resp_cod",gxvar:"AV28Usu_resp_cod",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV28Usu_resp_cod=a
},v2z:function(a){gx.O.ZV28Usu_resp_cod=a},v2c:function(){gx.fn.setGridControlValue("vUSU_RESP_COD",gx.fn.currentGridRowImpl(50),gx.O.AV28Usu_resp_cod,0)},c2v:function(){gx.O.AV28Usu_resp_cod=this.val()},val:function(){return gx.fn.getGridControlValue("vUSU_RESP_COD",gx.fn.currentGridRowImpl(50))},nac:function(){return false}};this.GXValidFnc[54]={lvl:2,type:"char",len:50,dec:0,sign:false,ro:0,grid:50,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"vUSU_RESP",gxz:"ZV27Usu_Resp",gxold:"OV27Usu_Resp",gxvar:"AV27Usu_Resp",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV27Usu_Resp=a
},v2z:function(a){gx.O.ZV27Usu_Resp=a},v2c:function(){gx.fn.setGridControlValue("vUSU_RESP",gx.fn.currentGridRowImpl(50),gx.O.AV27Usu_Resp,0)},c2v:function(){gx.O.AV27Usu_Resp=this.val()},val:function(){return gx.fn.getGridControlValue("vUSU_RESP",gx.fn.currentGridRowImpl(50))},nac:function(){return false}};this.GXValidFnc[55]={lvl:2,type:"int",len:1,dec:0,sign:false,pic:"9",ro:0,grid:50,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"vRESPONSABLE",gxz:"ZV9Responsable",gxold:"OV9Responsable",gxvar:"AV9Responsable",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"checkbox",v2v:function(a){gx.O.AV9Responsable=gx.num.intval(a)
},v2z:function(a){gx.O.ZV9Responsable=gx.num.intval(a)},v2c:function(){gx.fn.setGridCheckBoxValue("vRESPONSABLE",gx.fn.currentGridRowImpl(50),gx.O.AV9Responsable,"1")},c2v:function(){gx.O.AV9Responsable=this.val()},val:function(){return gx.fn.getGridCheckBoxValue("vRESPONSABLE",gx.fn.currentGridRowImpl(50),"1","0")},nac:function(){return false}};this.GXValidFnc[56]={lvl:2,type:"int",len:1,dec:0,sign:false,pic:"9",ro:0,grid:50,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"vPERMISO",gxz:"ZV14Permiso",gxold:"OV14Permiso",gxvar:"AV14Permiso",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"checkbox",v2v:function(a){gx.O.AV14Permiso=gx.num.intval(a)
},v2z:function(a){gx.O.ZV14Permiso=gx.num.intval(a)},v2c:function(){gx.fn.setGridCheckBoxValue("vPERMISO",gx.fn.currentGridRowImpl(50),gx.O.AV14Permiso,"1")},c2v:function(){gx.O.AV14Permiso=this.val()},val:function(){return gx.fn.getGridCheckBoxValue("vPERMISO",gx.fn.currentGridRowImpl(50),"1","0")},nac:function(){return false}};this.GXValidFnc[57]={lvl:2,type:"int",len:1,dec:0,sign:false,pic:"9",ro:0,grid:50,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"vRESPAUX",gxz:"ZV15RespAux",gxold:"OV15RespAux",gxvar:"AV15RespAux",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"checkbox",v2v:function(a){gx.O.AV15RespAux=gx.num.intval(a)
},v2z:function(a){gx.O.ZV15RespAux=gx.num.intval(a)},v2c:function(){gx.fn.setGridCheckBoxValue("vRESPAUX",gx.fn.currentGridRowImpl(50),gx.O.AV15RespAux,"1")},c2v:function(){gx.O.AV15RespAux=this.val()},val:function(){return gx.fn.getGridCheckBoxValue("vRESPAUX",gx.fn.currentGridRowImpl(50),"1","0")},nac:function(){return false}};this.AV5USU_COD="";this.ZV5USU_COD="";this.OV5USU_COD="";this.AV6USU_DES="";this.ZV6USU_DES="";this.OV6USU_DES="";this.AV7USU_CLA="";this.ZV7USU_CLA="";this.OV7USU_CLA="";
this.AV29USU_INT="";this.ZV29USU_INT="";this.OV29USU_INT="";this.AV30USU_MAIW="";this.ZV30USU_MAIW="";this.OV30USU_MAIW="";this.AV8Administrador=0;this.ZV8Administrador=0;this.OV8Administrador=0;this.ZV11W53POS=0;this.OV11W53POS=0;this.ZV12W53DES="";this.OV12W53DES="";this.ZV28Usu_resp_cod="";this.OV28Usu_resp_cod="";this.ZV27Usu_Resp="";this.OV27Usu_Resp="";this.ZV9Responsable=0;this.OV9Responsable=0;this.ZV14Permiso=0;this.OV14Permiso=0;this.ZV15RespAux=0;this.OV15RespAux=0;this.AV21pUSU_COD="";
this.AV20Modo="";this.AV18SISTEMA="";this.AV19USUARIO="";this.AV11W53POS=0;this.AV12W53DES="";this.AV28Usu_resp_cod="";this.AV27Usu_Resp="";this.AV9Responsable=0;this.AV14Permiso=0;this.AV15RespAux=0;this.A39TTBUS7_CodUsuario="";this.A33TTBUS7_Pos=0;this.A51TTBUS7_RespAux=0;this.A35TTBUS7_CodResp="";this.A40TTBUS8_CodUsuario="";this.A6USU_COD="";this.A7USU_DES="";this.A155USU_CLA="";this.A180USU_INT="";this.A249USU_MAIW="";this.A199TTBUS7_DesUsuario="";this.A31W53POS=0;this.A32W53DES="";this.A36TTBUS7_DesResp="";
this.ServerEvents=["e115b2_client","e125b2_client","e155b2_client"];this.EnterCtrl=["BUTTON1"];this.VarControlMap.AV21pUSU_COD={id:"vPUSU_COD",grid:0,type:"char"};this.VarControlMap.AV20Modo={id:"vMODO",grid:0,type:"char"};this.VarControlMap.AV18SISTEMA={id:"vSISTEMA",grid:0,type:"char"};this.VarControlMap.AV19USUARIO={id:"vUSUARIO",grid:0,type:"char"};this.VarControlMap.A51TTBUS7_RespAux={id:"TTBUS7_RESPAUX",grid:0,type:"int"};this.VarControlMap.A39TTBUS7_CodUsuario={id:"TTBUS7_CODUSUARIO",grid:0,type:"char"};
this.VarControlMap.A33TTBUS7_Pos={id:"TTBUS7_POS",grid:0,type:"int"};this.VarControlMap.AV20Modo={id:"vMODO",grid:0,type:"char"};this.VarControlMap.A36TTBUS7_DesResp={id:"TTBUS7_DESRESP",grid:0,type:"char"};this.VarControlMap.A35TTBUS7_CodResp={id:"TTBUS7_CODRESP",grid:0,type:"char"};this.VarControlMap.A31W53POS={id:"W53POS",grid:0,type:"int"};this.VarControlMap.A32W53DES={id:"W53DES",grid:0,type:"char"};this.Grid1Container.addRefreshingVar({rfrVar:"AV15RespAux",rfrProp:"Enabled"});this.Grid1Container.addRefreshingVar({rfrVar:"AV14Permiso",rfrProp:"Enabled"});
this.Grid1Container.addRefreshingVar({rfrVar:"AV9Responsable",rfrProp:"Enabled"});this.Grid1Container.addRefreshingVar({rfrVar:"A51TTBUS7_RespAux"});this.Grid1Container.addRefreshingVar({rfrVar:"A39TTBUS7_CodUsuario"});this.Grid1Container.addRefreshingVar({rfrVar:"A33TTBUS7_Pos"});this.Grid1Container.addRefreshingVar({rfrVar:"AV20Modo"});this.Grid1Container.addRefreshingVar({rfrVar:"A36TTBUS7_DesResp"});this.Grid1Container.addRefreshingVar({rfrVar:"A35TTBUS7_CodResp"});this.Grid1Container.addRefreshingVar({rfrVar:"A31W53POS"});
this.Grid1Container.addRefreshingVar({rfrVar:"A32W53DES"});this.SetStandaloneVars()}htbusseg0.prototype=new gx.GxObject;gx.setParentObj(new htbusseg0());