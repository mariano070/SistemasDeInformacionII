gx.evt.autoSkip=false;function ttbus008(){this.ServerClass="TTBUS008";this.PackageName="GeneXus.Programs";this.setObjectType("trn");this.hasEnterEvent=true;this.SetStandaloneVars=function(){this.AV9TTBUS8_CodUsuario=gx.fn.getControlValue("vTTBUS8_CODUSUARIO");this.Gx_mode=gx.fn.getControlValue("vMODE");this.AV7SISTEMA=gx.fn.getControlValue("vSISTEMA");this.AV8USUARIO=gx.fn.getControlValue("vUSUARIO")};this.Valid_Ttbus8_codusuario=function(){gx.ajax.validSrvEvt("dyncall","Valid_Ttbus8_codusuario",["gx.O.A40TTBUS8_CodUsuario","gx.O.A200TTBUS8_DesUsuario"],["A200TTBUS8_DesUsuario"]);
return true};this.e11089_client=function(){this.executeServerEvent("ENTER",true)};this.e12089_client=function(){this.executeServerEvent("CANCEL",true)};this.GXValidFnc=[];this.GXCtrlIds=[2,5,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,26,27,33,38,43,49];this.GXLastCtrlId=49;this.GXValidFnc[2]={fld:"TABLEMAIN",grid:0};this.GXValidFnc[5]={fld:"TABLETOOLBAR",grid:0};this.GXValidFnc[8]={fld:"BTN_FIRST",grid:0};this.GXValidFnc[9]={fld:"BTN_FIRST_SEPARATOR",grid:0};this.GXValidFnc[10]={fld:"BTN_PREVIOUS",grid:0};
this.GXValidFnc[11]={fld:"BTN_PREVIOUS_SEPARATOR",grid:0};this.GXValidFnc[12]={fld:"BTN_NEXT",grid:0};this.GXValidFnc[13]={fld:"BTN_NEXT_SEPARATOR",grid:0};this.GXValidFnc[14]={fld:"BTN_LAST",grid:0};this.GXValidFnc[15]={fld:"BTN_LAST_SEPARATOR",grid:0};this.GXValidFnc[16]={fld:"BTN_SELECT",grid:0};this.GXValidFnc[17]={fld:"BTN_SELECT_SEPARATOR",grid:0};this.GXValidFnc[18]={fld:"BTN_ENTER2",grid:0};this.GXValidFnc[19]={fld:"BTN_ENTER2_SEPARATOR",grid:0};this.GXValidFnc[20]={fld:"BTN_CANCEL2",grid:0};
this.GXValidFnc[21]={fld:"BTN_CANCEL2_SEPARATOR",grid:0};this.GXValidFnc[22]={fld:"BTN_DELETE2",grid:0};this.GXValidFnc[23]={fld:"BTN_DELETE2_SEPARATOR",grid:0};this.GXValidFnc[26]={fld:"GROUPDATA",grid:0};this.GXValidFnc[27]={fld:"TABLE1",grid:0};this.GXValidFnc[33]={fld:"TABLE2",grid:0};this.GXValidFnc[36]={fld:"TEXTBLOCKTTBUS8_CODUSUARIO",format:0,grid:0};this.GXValidFnc[38]={lvl:0,type:"char",len:16,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Ttbus8_codusuario,isvalid:null,fld:"TTBUS8_CODUSUARIO",gxz:"Z40TTBUS8_CodUsuario",gxold:"O40TTBUS8_CodUsuario",gxvar:"A40TTBUS8_CodUsuario",ucs:[],op:[43],ip:[43,38],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A40TTBUS8_CodUsuario=a
},v2z:function(a){gx.O.Z40TTBUS8_CodUsuario=a},v2c:function(){gx.fn.setControlValue("TTBUS8_CODUSUARIO",gx.O.A40TTBUS8_CodUsuario,0)},c2v:function(){gx.O.A40TTBUS8_CodUsuario=this.val()},val:function(){return gx.fn.getControlValue("TTBUS8_CODUSUARIO")},nac:function(){return this.Gx_mode!="INS"}};this.GXValidFnc[41]={fld:"TEXTBLOCKTTBUS8_DESUSUARIO",format:0,grid:0};this.GXValidFnc[43]={lvl:0,type:"char",len:50,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"TTBUS8_DESUSUARIO",gxz:"Z200TTBUS8_DesUsuario",gxold:"O200TTBUS8_DesUsuario",gxvar:"A200TTBUS8_DesUsuario",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A200TTBUS8_DesUsuario=a
},v2z:function(a){gx.O.Z200TTBUS8_DesUsuario=a},v2c:function(){gx.fn.setControlValue("TTBUS8_DESUSUARIO",gx.O.A200TTBUS8_DesUsuario,0)},c2v:function(){gx.O.A200TTBUS8_DesUsuario=this.val()},val:function(){return gx.fn.getControlValue("TTBUS8_DESUSUARIO")},nac:function(){return false}};this.GXValidFnc[49]={fld:"PROMPT_40",grid:9};this.A40TTBUS8_CodUsuario="";this.Z40TTBUS8_CodUsuario="";this.O40TTBUS8_CodUsuario="";this.A200TTBUS8_DesUsuario="";this.Z200TTBUS8_DesUsuario="";this.O200TTBUS8_DesUsuario="";
this.AV9TTBUS8_CodUsuario="";this.AV7SISTEMA="";this.AV8USUARIO="";this.Gx_mode="";this.ServerEvents=["e11089_client","e12089_client"];this.setPrompt("PROMPT_40",[38]);this.EnterCtrl=["BTN_ENTER"];this.VarControlMap.AV9TTBUS8_CodUsuario={id:"vTTBUS8_CODUSUARIO",grid:0,type:"char"};this.VarControlMap.Gx_mode={id:"vMODE",grid:0,type:"char"};this.VarControlMap.AV7SISTEMA={id:"vSISTEMA",grid:0,type:"char"};this.VarControlMap.AV8USUARIO={id:"vUSUARIO",grid:0,type:"char"};this.SetStandaloneVars()}ttbus008.prototype=new gx.GxObject;
gx.setParentObj(new ttbus008());