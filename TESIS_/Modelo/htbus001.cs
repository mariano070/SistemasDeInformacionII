/*
               File: HTBUS001
        Description: Actualización de Bienes de Uso (Trazabilidad)
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 3/17/2014 13:22:24.60
       Program type: Callable routine
          Main DBMS: sqlserver
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using System.Data;
using System.Data.SqlClient;
using GeneXus.Data;
using com.genexus;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using System.Runtime.Remoting;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class htbus001 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public htbus001( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public htbus001( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref String aP0_SISTEMA ,
                           ref String aP1_USUARIO )
      {
         this.AV45SISTEMA = aP0_SISTEMA;
         this.AV62USUARIO = aP1_USUARIO;
         executePrivate();
         aP0_SISTEMA=this.AV45SISTEMA;
         aP1_USUARIO=this.AV62USUARIO;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         dynavFididentificador = new GXCombobox();
         cmbavFttbus_estado = new GXCombobox();
         cmbavTtbus7_pos = new GXCombobox();
         chkavGttbus_alquilado = new GXCheckbox();
         cmbavGttbus_estado = new GXCombobox();
      }

      protected void INITWEB( )
      {
         initialize_properties( ) ;
         if ( nGotPars == 0 )
         {
            entryPointCalled = false ;
            gxfirstwebparm = GetNextPar( ) ;
            gxfirstwebparm_bkp = gxfirstwebparm ;
            gxfirstwebparm = DecryptAjaxCall( gxfirstwebparm, "High") ;
            if ( StringUtil.StrCmp(gxfirstwebparm, "dyncall") == 0 )
            {
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               dyncall( GetNextPar( )) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxSuggest"+"_"+"vFTTBUS_DESCRIPCION") == 0 )
            {
               A12TTBUS_Descripcion = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12TTBUS_Descripcion", A12TTBUS_Descripcion);
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               GXSGVvFTTBUS_DESCRIPCION1M0( A12TTBUS_Descripcion) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxSuggest"+"_"+"vGTTBUS_DESCRIPCION") == 0 )
            {
               A12TTBUS_Descripcion = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12TTBUS_Descripcion", A12TTBUS_Descripcion);
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               GXSGVvGTTBUS_DESCRIPCION1M0( A12TTBUS_Descripcion) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxEvt") == 0 )
            {
               setAjaxEventMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxfirstwebparm = GetNextPar( ) ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Grid1") == 0 )
            {
               nRC_Grid1 = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               nGXsfl_61_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               sGXsfl_61_idx = GetNextPar( ) ;
               edtavEdicion_Visible = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavEdicion_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavEdicion_Visible), 5, 0)));
               edtavBaja_Visible = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBaja_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBaja_Visible), 5, 0)));
               edtavSec_dre_Enabled = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSec_dre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavSec_dre_Enabled), 5, 0)));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxnrGrid1_newrow( nRC_Grid1, nGXsfl_61_idx, sGXsfl_61_idx) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid1") == 0 )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0 ;
               edtavGididentificador_Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGididentificador_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGididentificador_Enabled), 5, 0)));
               edtavGnumeroidentificador_Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGnumeroidentificador_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGnumeroidentificador_Enabled), 5, 0)));
               edtavGttbus_id_Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGttbus_id_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGttbus_id_Enabled), 5, 0)));
               edtavGttbus_descripcion_Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGttbus_descripcion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGttbus_descripcion_Enabled), 5, 0)));
               edtavGttbus_fechacarga_Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGttbus_fechacarga_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGttbus_fechacarga_Enabled), 5, 0)));
               edtavGttbus_rubrobien_Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGttbus_rubrobien_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGttbus_rubrobien_Enabled), 5, 0)));
               edtavGttbus_rubrodesc_Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGttbus_rubrodesc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGttbus_rubrodesc_Enabled), 5, 0)));
               edtavGttbus_fechabaja_Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGttbus_fechabaja_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGttbus_fechabaja_Enabled), 5, 0)));
               chkavGttbus_alquilado.Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavGttbus_alquilado_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavGttbus_alquilado.Enabled), 5, 0)));
               edtavGttbus_codproveedor_Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGttbus_codproveedor_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGttbus_codproveedor_Enabled), 5, 0)));
               edtavGttbus_desproveedor_Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGttbus_desproveedor_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGttbus_desproveedor_Enabled), 5, 0)));
               cmbavGttbus_estado.Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavGttbus_estado_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavGttbus_estado.Enabled), 5, 0)));
               edtavGttbus_codposicion_Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGttbus_codposicion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGttbus_codposicion_Enabled), 5, 0)));
               edtavGttbus_desposicion_Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGttbus_desposicion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGttbus_desposicion_Enabled), 5, 0)));
               edtavSec_cre_Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSec_cre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavSec_cre_Enabled), 5, 0)));
               edtavSec_dre_Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSec_dre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavSec_dre_Enabled), 5, 0)));
               dynavFididentificador.Name = "vFIDIDENTIFICADOR" ;
               dynavFididentificador.WebTags = "" ;
               dynavFididentificador.removeAllItems();
               /* Using cursor H001M2 */
               pr_default.execute(0);
               while ( (pr_default.getStatus(0) != 101) )
               {
                  dynavFididentificador.addItem(StringUtil.Str( (decimal)(H001M2_A20TTBUS5_IdIdentificador[0]), 8, 0), H001M2_A21TTBUS5_DescIdentificador[0], 0);
                  pr_default.readNext(0);
               }
               pr_default.close(0);
               if ( ( dynavFididentificador.ItemCount > 0 ) && (0==AV12fIdIdentificador) )
               {
                  AV12fIdIdentificador = 1 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12fIdIdentificador", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12fIdIdentificador), 8, 0)));
               }
               cmbavFttbus_estado.Name = "vFTTBUS_ESTADO" ;
               cmbavFttbus_estado.WebTags = "" ;
               cmbavFttbus_estado.addItem(StringUtil.Str( (decimal)(0), 1, 0), "TODOS", 0);
               cmbavFttbus_estado.addItem("1", "ASIGNADO A UN SECTOR", 0);
               cmbavFttbus_estado.addItem("2", "CAMBIANDO DE SECTOR", 0);
               if ( ( cmbavFttbus_estado.ItemCount > 0 ) && (0==AV15fTTBUS_Estado) )
               {
                  AV15fTTBUS_Estado = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15fTTBUS_Estado", StringUtil.Str( (decimal)(AV15fTTBUS_Estado), 1, 0));
               }
               cmbavTtbus7_pos.Name = "vTTBUS7_POS" ;
               cmbavTtbus7_pos.WebTags = "" ;
               if ( ( cmbavTtbus7_pos.ItemCount > 0 ) && (0==AV60TTBUS7_Pos) )
               {
                  AV60TTBUS7_Pos = (short)(NumberUtil.Val( cmbavTtbus7_pos.getItemValue(1), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV60TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(AV60TTBUS7_Pos), 3, 0)));
               }
               GXCCtl = "vGTTBUS_ALQUILADO_" + sGXsfl_61_idx ;
               chkavGttbus_alquilado.Name = GXCCtl ;
               chkavGttbus_alquilado.WebTags = "" ;
               chkavGttbus_alquilado.Caption = "" ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavGttbus_alquilado_Internalname, "Caption", chkavGttbus_alquilado.Caption);
               chkavGttbus_alquilado.CheckedValue = "0" ;
               GXCCtl = "vGTTBUS_ESTADO_" + sGXsfl_61_idx ;
               cmbavGttbus_estado.Name = GXCCtl ;
               cmbavGttbus_estado.WebTags = "" ;
               cmbavGttbus_estado.addItem("1", "ASIGNADO A UN SECTOR", 0);
               cmbavGttbus_estado.addItem("2", "CAMBIANDO DE SECTOR", 0);
               cmbavGttbus_estado.addItem("3", "BAJA A CONFIRMAR", 0);
               cmbavGttbus_estado.addItem("4", "BAJA", 0);
               if ( ( cmbavGttbus_estado.ItemCount > 0 ) && (0==AV30gTTBUS_Estado) )
               {
                  AV30gTTBUS_Estado = (short)(NumberUtil.Val( cmbavGttbus_estado.getItemValue(1), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30gTTBUS_Estado", StringUtil.Str( (decimal)(AV30gTTBUS_Estado), 1, 0));
               }
               Grid1_PageSize61 = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               edtavEdicion_Visible = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavEdicion_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavEdicion_Visible), 5, 0)));
               edtavBaja_Visible = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBaja_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBaja_Visible), 5, 0)));
               edtavSec_dre_Enabled = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSec_dre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavSec_dre_Enabled), 5, 0)));
               AV8band_2 = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               AV62USUARIO = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV62USUARIO", AV62USUARIO);
               A7USU_DES = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7USU_DES", A7USU_DES);
               A6USU_COD = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
               A25TTBUS2_RespHacia = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25TTBUS2_RespHacia", A25TTBUS2_RespHacia);
               A24TTBUS2_RespDesde = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24TTBUS2_RespDesde", A24TTBUS2_RespDesde);
               A36TTBUS7_DesResp = GetNextPar( ) ;
               n36TTBUS7_DesResp = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36TTBUS7_DesResp", A36TTBUS7_DesResp);
               A35TTBUS7_CodResp = GetNextPar( ) ;
               n35TTBUS7_CodResp = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35TTBUS7_CodResp", A35TTBUS7_CodResp);
               A33TTBUS7_Pos = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
               A14IdIdentificador = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14IdIdentificador", StringUtil.LTrim( StringUtil.Str( (decimal)(A14IdIdentificador), 8, 0)));
               A18TTBUS_RubroDesc = GetNextPar( ) ;
               n18TTBUS_RubroDesc = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18TTBUS_RubroDesc", A18TTBUS_RubroDesc);
               A17TTBUS_RubroBien = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17TTBUS_RubroBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A17TTBUS_RubroBien), 4, 0)));
               A11TTBUS_Id = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
               A13TTBUS_FechaCarga = context.localUtil.ParseDateParm( GetNextPar( )) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13TTBUS_FechaCarga", context.localUtil.Format(A13TTBUS_FechaCarga, "99/99/9999"));
               A16TTBUS_FechaBaja = context.localUtil.ParseDateParm( GetNextPar( )) ;
               n16TTBUS_FechaBaja = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16TTBUS_FechaBaja", context.localUtil.Format(A16TTBUS_FechaBaja, "99/99/9999"));
               A23TTBUS_Estado = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23TTBUS_Estado", StringUtil.Str( (decimal)(A23TTBUS_Estado), 1, 0));
               A30TTBUS_DesProveedor = GetNextPar( ) ;
               n30TTBUS_DesProveedor = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30TTBUS_DesProveedor", A30TTBUS_DesProveedor);
               A38TTBUS_DesPosicion = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A38TTBUS_DesPosicion", A38TTBUS_DesPosicion);
               A12TTBUS_Descripcion = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12TTBUS_Descripcion", A12TTBUS_Descripcion);
               A27TTBUS_CodProveedor = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               n27TTBUS_CodProveedor = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27TTBUS_CodProveedor", StringUtil.LTrim( StringUtil.Str( (decimal)(A27TTBUS_CodProveedor), 8, 0)));
               A37TTBUS_CodPosicion = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37TTBUS_CodPosicion", StringUtil.LTrim( StringUtil.Str( (decimal)(A37TTBUS_CodPosicion), 3, 0)));
               A29TTBUS_Alquilado = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29TTBUS_Alquilado", StringUtil.Str( (decimal)(A29TTBUS_Alquilado), 1, 0));
               A15NumeroIdentificador = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15NumeroIdentificador", A15NumeroIdentificador);
               AV13fNumeroIdentificador = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13fNumeroIdentificador", AV13fNumeroIdentificador);
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxgrGrid1_refresh( Grid1_PageSize61, AV8band_2, AV62USUARIO, A7USU_DES, A6USU_COD, A25TTBUS2_RespHacia, A24TTBUS2_RespDesde, A36TTBUS7_DesResp, A35TTBUS7_CodResp, A33TTBUS7_Pos, A14IdIdentificador, A18TTBUS_RubroDesc, A17TTBUS_RubroBien, A11TTBUS_Id, A13TTBUS_FechaCarga, A16TTBUS_FechaBaja, A23TTBUS_Estado, A30TTBUS_DesProveedor, A38TTBUS_DesPosicion, A12TTBUS_Descripcion, A27TTBUS_CodProveedor, A37TTBUS_CodPosicion, A29TTBUS_Alquilado, A15NumeroIdentificador, AV13fNumeroIdentificador) ;
               return  ;
            }
            else
            {
               if ( ! IsValidAjaxCall( false) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxfirstwebparm = gxfirstwebparm_bkp ;
            }
            if ( ! entryPointCalled )
            {
               AV45SISTEMA = gxfirstwebparm ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV45SISTEMA", AV45SISTEMA);
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV62USUARIO = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV62USUARIO", AV62USUARIO);
               }
            }
         }
         context.SetTheme("Modern");
      }

      public override void webExecute( )
      {
         if ( initialized == 0 )
         {
            createObjects();
            initialize();
         }
         INITWEB( ) ;
         if ( ! isAjaxCallMode( ) )
         {
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("mptrazabilidad", "GeneXus.Programs.mptrazabilidad", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
            MasterPageObj.setDataArea(this,false);
            MasterPageObj.webExecute();
            if ( context.isAjaxRequest( ) )
            {
               enableOutput();
               if ( ! context.isAjaxRequest( ) )
               {
                  context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
               }
               if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) )
               {
                  context.GX_webresponse.AddString((String)(context.getJSONResponse( )));
               }
               else
               {
                  context.Redirect( context.wjLoc );
                  context.DispatchAjaxCommands();
               }
            }
         }
         this.cleanup();
      }

      public override short ExecuteStartEvent( )
      {
         PA1M2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START1M2( ) ;
         }
         return gxajaxcallmode ;
      }

      public override void RenderHtmlHeaders( )
      {
         GxWebStd.gx_html_headers( context, 0, "", "", Form.Meta, Form.Metaequiv, "IE=EmulateIE7");
      }

      public override void RenderHtmlOpenForm( )
      {
         context.WriteHtmlText( "<title>") ;
         context.WriteHtmlText( Form.Caption) ;
         context.WriteHtmlTextNl( "</title>") ;
         if ( StringUtil.Len( sDynURL) > 0 )
         {
            context.WriteHtmlText( "<BASE href=\""+sDynURL+"\" />") ;
         }
         define_styles( ) ;
         if ( nGXWrapped != 1 )
         {
            MasterPageObj.master_styles();
         }
         if ( ! context.isSmartDevice( ) )
         {
            context.AddJavascriptSource("gxgral.js", "?42940");
            context.AddJavascriptSource("gxcfg.js", "?42940");
         }
         else
         {
            context.AddJavascriptSource("gxapiSD.js", "?42940");
            context.AddJavascriptSource("gxfxSD.js", "?42940");
            context.AddJavascriptSource("gxtypesSD.js", "?42940");
            context.AddJavascriptSource("gxpopupSD.js", "?42940");
            context.AddJavascriptSource("gxfrmutlSD.js", "?42940");
            context.AddJavascriptSource("gxgridSD.js", "?42940");
            context.AddJavascriptSource("JavaScripTableSD.js", "?42940");
            context.AddJavascriptSource("rijndaelSD.js", "?42940");
            context.AddJavascriptSource("gxgralSD.js", "?42940");
            context.AddJavascriptSource("gxcfg.js", "?42940");
         }
         context.AddJavascriptSource("calendar.js", "?42940");
         context.AddJavascriptSource("calendar-setup.js", "?42940");
         context.AddJavascriptSource("calendar-es.js", "?42940");
         context.WriteHtmlText( Form.Headerrawhtml) ;
         context.CloseHtmlHeader();
         FormProcess = " onkeyup=\"gx.evt.onkeyup(event)\" onkeypress=\"gx.evt.onkeypress(event,false,false)\" onkeydown=\"gx.evt.onkeypress(null,false,false)\"" ;
         context.WriteHtmlText( "<body") ;
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            context.WriteHtmlText( " background=\""+context.convertURL( Form.Background)+"\"") ;
         }
         context.WriteHtmlText( " "+"class=\"Form\""+" "+" style=\"-moz-opacity:0;opacity:0;"+"background-color:"+context.BuildHTMLColor( Form.Backcolor)+"\""+FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("htbus001.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV45SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV62USUARIO))+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_Grid1", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid1), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vSISTEMA", StringUtil.RTrim( AV45SISTEMA));
         GxWebStd.gx_hidden_field( context, "vUSUARIO", StringUtil.RTrim( AV62USUARIO));
         GxWebStd.gx_hidden_field( context, "vBAND_2", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8band_2), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "USU_DES", StringUtil.RTrim( A7USU_DES));
         GxWebStd.gx_hidden_field( context, "USU_COD", StringUtil.RTrim( A6USU_COD));
         GxWebStd.gx_hidden_field( context, "TTBUS2_RESPHACIA", StringUtil.RTrim( A25TTBUS2_RespHacia));
         GxWebStd.gx_hidden_field( context, "TTBUS2_RESPDESDE", StringUtil.RTrim( A24TTBUS2_RespDesde));
         GxWebStd.gx_hidden_field( context, "TTBUS7_DESRESP", StringUtil.RTrim( A36TTBUS7_DesResp));
         GxWebStd.gx_hidden_field( context, "TTBUS7_CODRESP", StringUtil.RTrim( A35TTBUS7_CodResp));
         GxWebStd.gx_hidden_field( context, "TTBUS7_POS", StringUtil.LTrim( StringUtil.NToC( (decimal)(A33TTBUS7_Pos), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IDIDENTIFICADOR", StringUtil.LTrim( StringUtil.NToC( (decimal)(A14IdIdentificador), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "TTBUS_RUBRODESC", StringUtil.RTrim( A18TTBUS_RubroDesc));
         GxWebStd.gx_hidden_field( context, "TTBUS_RUBROBIEN", StringUtil.LTrim( StringUtil.NToC( (decimal)(A17TTBUS_RubroBien), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "TTBUS_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A11TTBUS_Id), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "TTBUS_FECHACARGA", context.localUtil.DToC( A13TTBUS_FechaCarga, 0, "/"));
         GxWebStd.gx_hidden_field( context, "TTBUS_FECHABAJA", context.localUtil.DToC( A16TTBUS_FechaBaja, 0, "/"));
         GxWebStd.gx_hidden_field( context, "TTBUS_ESTADO", StringUtil.LTrim( StringUtil.NToC( (decimal)(A23TTBUS_Estado), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "TTBUS_DESPROVEEDOR", StringUtil.RTrim( A30TTBUS_DesProveedor));
         GxWebStd.gx_hidden_field( context, "TTBUS_DESPOSICION", StringUtil.RTrim( A38TTBUS_DesPosicion));
         GxWebStd.gx_hidden_field( context, "TTBUS_DESCRIPCION", StringUtil.RTrim( A12TTBUS_Descripcion));
         GxWebStd.gx_hidden_field( context, "TTBUS_CODPROVEEDOR", StringUtil.LTrim( StringUtil.NToC( (decimal)(A27TTBUS_CodProveedor), 8, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "TTBUS_CODPOSICION", StringUtil.LTrim( StringUtil.NToC( (decimal)(A37TTBUS_CodPosicion), 3, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "TTBUS_ALQUILADO", StringUtil.LTrim( StringUtil.NToC( (decimal)(A29TTBUS_Alquilado), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "NUMEROIDENTIFICADOR", StringUtil.RTrim( A15NumeroIdentificador));
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 6, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendComponentObjects();
         SendServerCommands();
         SendState();
         context.WriteHtmlTextNl( "</form>") ;
         include_jscripts( ) ;
         if ( ! ( WebComp_Wc_bienes_a_recibir == null ) )
         {
            WebComp_Wc_bienes_a_recibir.componentjscripts();
         }
         if ( ! ( WebComp_Wc_bienes_enviados == null ) )
         {
            WebComp_Wc_bienes_enviados.componentjscripts();
         }
         if ( ! ( WebComp_Wc_tabs == null ) )
         {
            WebComp_Wc_tabs.componentjscripts();
         }
      }

      public override void RenderHtmlContent( )
      {
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            WE1M2( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT1M2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return false ;
      }

      public override String GetPgmname( )
      {
         return "HTBUS001" ;
      }

      public override String GetPgmdesc( )
      {
         return "Actualización de Bienes de Uso (Trazabilidad)" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("htbus001.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV45SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV62USUARIO)) ;
      }

      protected void WB1M0( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            if ( nGXWrapped == 1 )
            {
               RenderHtmlHeaders( ) ;
               RenderHtmlOpenForm( ) ;
            }
            wb_table1_2_1M2( true) ;
         }
         else
         {
            wb_table1_2_1M2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_1M2e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START1M2( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "Actualización de Bienes de Uso (Trazabilidad)", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            OldWc_bienes_a_recibir = cgiGet( "W0101") ;
            if ( String.IsNullOrEmpty(StringUtil.RTrim( WebComp_Wc_bienes_a_recibir_Component)) && ! String.IsNullOrEmpty(StringUtil.RTrim( OldWc_bienes_a_recibir)) )
            {
               WebComp_Wc_bienes_a_recibir = getWebComponent(GetType(), "GeneXus.Programs", OldWc_bienes_a_recibir, new Object[] {context} );
               WebComp_Wc_bienes_a_recibir.ComponentInit();
               WebComp_Wc_bienes_a_recibir.Name = "OldWc_bienes_a_recibir";
               WebComp_Wc_bienes_a_recibir_Component = OldWc_bienes_a_recibir ;
               WebComp_Wc_bienes_a_recibir.componentrestorestate("W0101", "");
            }
            OldWc_bienes_enviados = cgiGet( "W0103") ;
            if ( String.IsNullOrEmpty(StringUtil.RTrim( WebComp_Wc_bienes_enviados_Component)) && ! String.IsNullOrEmpty(StringUtil.RTrim( OldWc_bienes_enviados)) )
            {
               WebComp_Wc_bienes_enviados = getWebComponent(GetType(), "GeneXus.Programs", OldWc_bienes_enviados, new Object[] {context} );
               WebComp_Wc_bienes_enviados.ComponentInit();
               WebComp_Wc_bienes_enviados.Name = "OldWc_bienes_enviados";
               WebComp_Wc_bienes_enviados_Component = OldWc_bienes_enviados ;
               WebComp_Wc_bienes_enviados.componentrestorestate("W0103", "");
            }
            OldWc_tabs = cgiGet( "W0114") ;
            if ( String.IsNullOrEmpty(StringUtil.RTrim( WebComp_Wc_tabs_Component)) && ! String.IsNullOrEmpty(StringUtil.RTrim( OldWc_tabs)) )
            {
               WebComp_Wc_tabs = getWebComponent(GetType(), "GeneXus.Programs", OldWc_tabs, new Object[] {context} );
               WebComp_Wc_tabs.ComponentInit();
               WebComp_Wc_tabs.Name = "OldWc_tabs";
               WebComp_Wc_tabs_Component = OldWc_tabs ;
               WebComp_Wc_tabs.componentrestorestate("W0114", "");
            }
         }
         wbErr = false ;
         STRUP1M0( ) ;
      }

      protected void WS1M2( )
      {
         START1M2( ) ;
         EVT1M2( ) ;
      }

      protected void EVT1M2( )
      {
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) && ! wbErr )
            {
               /* Read Web Panel buttons. */
               sEvt = cgiGet( "_EventName") ;
               EvtGridId = cgiGet( "_EventGridId") ;
               EvtRowId = cgiGet( "_EventRowId") ;
               if ( StringUtil.Len( sEvt) > 0 )
               {
                  sEvtType = StringUtil.Left( sEvt, 1) ;
                  sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                  /* Check if conditions changed and reset current page numbers */
                  if ( StringUtil.StrCmp(sEvtType, "M") != 0 )
                  {
                     if ( StringUtil.StrCmp(sEvtType, "E") == 0 )
                     {
                        sEvtType = StringUtil.Right( sEvt, 1) ;
                        if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                        {
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                           if ( StringUtil.StrCmp(sEvt, "RFR") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'BUSCAR'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E111M2 */
                              E111M2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'ALTA'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E121M2 */
                              E121M2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'MOVIMIENTOS'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E131M2 */
                              E131M2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'LISTAR MOVIMIENTOS'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E141M2 */
                              E141M2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRID1PAGING") == 0 )
                           {
                              context.wbHandled = 1 ;
                              sEvt = cgiGet( "GRID1PAGING") ;
                              if ( StringUtil.StrCmp(sEvt, "FIRST") == 0 )
                              {
                                 subgrid1_firstpage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "PREV") == 0 )
                              {
                                 subgrid1_previouspage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "NEXT") == 0 )
                              {
                                 subgrid1_nextpage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "LAST") == 0 )
                              {
                                 subgrid1_lastpage( ) ;
                              }
                           }
                        }
                        else
                        {
                           sEvtType = StringUtil.Right( sEvt, 4) ;
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4)) ;
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "'ALTA'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "'BAJA'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 14), "'MODIFICACION'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 15), "'VISUALIZACION'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 10), "GRID1.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 13), "'MOVIMIENTOS'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 20), "'LISTAR MOVIMIENTOS'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 8), "'BUSCAR'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "'BAJA'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 14), "'MODIFICACION'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 15), "'VISUALIZACION'") == 0 ) )
                           {
                              nGXsfl_61_idx = (short)(NumberUtil.Val( sEvtType, ".")) ;
                              sGXsfl_61_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_61_idx), 4, 0)), 4, "0") ;
                              edtavBaja_Internalname = "vBAJA_"+sGXsfl_61_idx ;
                              edtavEdicion_Internalname = "vEDICION_"+sGXsfl_61_idx ;
                              edtavVisualizacion_Internalname = "vVISUALIZACION_"+sGXsfl_61_idx ;
                              edtavGididentificador_Internalname = "vGIDIDENTIFICADOR_"+sGXsfl_61_idx ;
                              edtavGnumeroidentificador_Internalname = "vGNUMEROIDENTIFICADOR_"+sGXsfl_61_idx ;
                              edtavGttbus_id_Internalname = "vGTTBUS_ID_"+sGXsfl_61_idx ;
                              edtavGttbus_descripcion_Internalname = "vGTTBUS_DESCRIPCION_"+sGXsfl_61_idx ;
                              edtavGttbus_fechacarga_Internalname = "vGTTBUS_FECHACARGA_"+sGXsfl_61_idx ;
                              edtavGttbus_rubrobien_Internalname = "vGTTBUS_RUBROBIEN_"+sGXsfl_61_idx ;
                              edtavGttbus_rubrodesc_Internalname = "vGTTBUS_RUBRODESC_"+sGXsfl_61_idx ;
                              edtavGttbus_fechabaja_Internalname = "vGTTBUS_FECHABAJA_"+sGXsfl_61_idx ;
                              chkavGttbus_alquilado_Internalname = "vGTTBUS_ALQUILADO_"+sGXsfl_61_idx ;
                              edtavGttbus_codproveedor_Internalname = "vGTTBUS_CODPROVEEDOR_"+sGXsfl_61_idx ;
                              edtavGttbus_desproveedor_Internalname = "vGTTBUS_DESPROVEEDOR_"+sGXsfl_61_idx ;
                              cmbavGttbus_estado_Internalname = "vGTTBUS_ESTADO_"+sGXsfl_61_idx ;
                              edtavGttbus_codposicion_Internalname = "vGTTBUS_CODPOSICION_"+sGXsfl_61_idx ;
                              edtavGttbus_desposicion_Internalname = "vGTTBUS_DESPOSICION_"+sGXsfl_61_idx ;
                              edtavSec_cre_Internalname = "vSEC_CRE_"+sGXsfl_61_idx ;
                              edtavSec_dre_Internalname = "vSEC_DRE_"+sGXsfl_61_idx ;
                              AV5baja = cgiGet( "GXimg"+edtavBaja_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBaja_Internalname, "Bitmap", context.convertURL( AV5baja));
                              AV11edicion = cgiGet( "GXimg"+edtavEdicion_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavEdicion_Internalname, "Bitmap", context.convertURL( AV11edicion));
                              AV63visualizacion = cgiGet( "GXimg"+edtavVisualizacion_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVisualizacion_Internalname, "Bitmap", context.convertURL( AV63visualizacion));
                              if ( ! context.localUtil.VCNumber( cgiGet( edtavGididentificador_Internalname), "ZZZZZZZ9") || ( context.localUtil.CToN( cgiGet( edtavGididentificador_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavGididentificador_Internalname), ",", ".") > Convert.ToDecimal( 99999999 )) ) )
                              {
                                 GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vGIDIDENTIFICADOR");
                                 GX_FocusControl = edtavGididentificador_Internalname ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                                 wbErr = true ;
                                 AV22gIdIdentificador = 0 ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22gIdIdentificador", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22gIdIdentificador), 8, 0)));
                              }
                              else
                              {
                                 AV22gIdIdentificador = (int)(context.localUtil.CToN( cgiGet( edtavGididentificador_Internalname), ",", ".")) ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22gIdIdentificador", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22gIdIdentificador), 8, 0)));
                              }
                              AV23gNumeroIdentificador = cgiGet( edtavGnumeroidentificador_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23gNumeroIdentificador", AV23gNumeroIdentificador);
                              if ( ! context.localUtil.VCNumber( cgiGet( edtavGttbus_id_Internalname), "ZZZZZZZ9") || ( context.localUtil.CToN( cgiGet( edtavGttbus_id_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavGttbus_id_Internalname), ",", ".") > Convert.ToDecimal( 99999999 )) ) )
                              {
                                 GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vGTTBUS_ID");
                                 GX_FocusControl = edtavGttbus_id_Internalname ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                                 wbErr = true ;
                                 AV33gTTBUS_ID = 0 ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33gTTBUS_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV33gTTBUS_ID), 8, 0)));
                              }
                              else
                              {
                                 AV33gTTBUS_ID = (int)(context.localUtil.CToN( cgiGet( edtavGttbus_id_Internalname), ",", ".")) ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33gTTBUS_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV33gTTBUS_ID), 8, 0)));
                              }
                              AV27gTTBUS_Descripcion = StringUtil.Upper( cgiGet( edtavGttbus_descripcion_Internalname)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27gTTBUS_Descripcion", AV27gTTBUS_Descripcion);
                              if ( context.localUtil.VCDate( cgiGet( edtavGttbus_fechacarga_Internalname), 4) == 0 )
                              {
                                 GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"g TTBUS_ Fecha Carga"}), 1, "vGTTBUS_FECHACARGA");
                                 GX_FocusControl = edtavGttbus_fechacarga_Internalname ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                                 wbErr = true ;
                                 AV32gTTBUS_FechaCarga = DateTime.MinValue ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32gTTBUS_FechaCarga", context.localUtil.Format(AV32gTTBUS_FechaCarga, "99/99/9999"));
                              }
                              else
                              {
                                 AV32gTTBUS_FechaCarga = context.localUtil.CToD( cgiGet( edtavGttbus_fechacarga_Internalname), 4) ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32gTTBUS_FechaCarga", context.localUtil.Format(AV32gTTBUS_FechaCarga, "99/99/9999"));
                              }
                              if ( ! context.localUtil.VCNumber( cgiGet( edtavGttbus_rubrobien_Internalname), "ZZZ9") || ( context.localUtil.CToN( cgiGet( edtavGttbus_rubrobien_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavGttbus_rubrobien_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
                              {
                                 GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vGTTBUS_RUBROBIEN");
                                 GX_FocusControl = edtavGttbus_rubrobien_Internalname ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                                 wbErr = true ;
                                 AV34gTTBUS_RubroBien = 0 ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34gTTBUS_RubroBien", StringUtil.LTrim( StringUtil.Str( (decimal)(AV34gTTBUS_RubroBien), 4, 0)));
                              }
                              else
                              {
                                 AV34gTTBUS_RubroBien = (short)(context.localUtil.CToN( cgiGet( edtavGttbus_rubrobien_Internalname), ",", ".")) ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34gTTBUS_RubroBien", StringUtil.LTrim( StringUtil.Str( (decimal)(AV34gTTBUS_RubroBien), 4, 0)));
                              }
                              AV35gTTBUS_RubroDesc = StringUtil.Upper( cgiGet( edtavGttbus_rubrodesc_Internalname)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35gTTBUS_RubroDesc", AV35gTTBUS_RubroDesc);
                              if ( context.localUtil.VCDate( cgiGet( edtavGttbus_fechabaja_Internalname), 4) == 0 )
                              {
                                 GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"g TTBUS_ Fecha Baja"}), 1, "vGTTBUS_FECHABAJA");
                                 GX_FocusControl = edtavGttbus_fechabaja_Internalname ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                                 wbErr = true ;
                                 AV31gTTBUS_FechaBaja = DateTime.MinValue ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31gTTBUS_FechaBaja", context.localUtil.Format(AV31gTTBUS_FechaBaja, "99/99/9999"));
                              }
                              else
                              {
                                 AV31gTTBUS_FechaBaja = context.localUtil.CToD( cgiGet( edtavGttbus_fechabaja_Internalname), 4) ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31gTTBUS_FechaBaja", context.localUtil.Format(AV31gTTBUS_FechaBaja, "99/99/9999"));
                              }
                              if ( ! context.localUtil.VCNumber( cgiGet( chkavGttbus_alquilado_Internalname), "9") || ( ((StringUtil.StrCmp(cgiGet( chkavGttbus_alquilado_Internalname), "1")==0) ? 1 : 0) < 0 ) || ( ( ((StringUtil.StrCmp(cgiGet( chkavGttbus_alquilado_Internalname), "1")==0) ? 1 : 0) > 9 ) ) )
                              {
                                 GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vGTTBUS_ALQUILADO");
                                 GX_FocusControl = chkavGttbus_alquilado_Internalname ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                                 wbErr = true ;
                                 AV24gTTBUS_Alquilado = 0 ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24gTTBUS_Alquilado", StringUtil.Str( (decimal)(AV24gTTBUS_Alquilado), 1, 0));
                              }
                              else
                              {
                                 AV24gTTBUS_Alquilado = (short)(((StringUtil.StrCmp(cgiGet( chkavGttbus_alquilado_Internalname), "1")==0) ? 1 : 0)) ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24gTTBUS_Alquilado", StringUtil.Str( (decimal)(AV24gTTBUS_Alquilado), 1, 0));
                              }
                              if ( ! context.localUtil.VCNumber( cgiGet( edtavGttbus_codproveedor_Internalname), "ZZZZZ9") || ( context.localUtil.CToN( cgiGet( edtavGttbus_codproveedor_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavGttbus_codproveedor_Internalname), ",", ".") > Convert.ToDecimal( 99999999 )) ) )
                              {
                                 GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vGTTBUS_CODPROVEEDOR");
                                 GX_FocusControl = edtavGttbus_codproveedor_Internalname ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                                 wbErr = true ;
                                 AV26gTTBUS_CodProveedor = 0 ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26gTTBUS_CodProveedor", StringUtil.LTrim( StringUtil.Str( (decimal)(AV26gTTBUS_CodProveedor), 8, 0)));
                              }
                              else
                              {
                                 AV26gTTBUS_CodProveedor = (int)(context.localUtil.CToN( cgiGet( edtavGttbus_codproveedor_Internalname), ",", ".")) ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26gTTBUS_CodProveedor", StringUtil.LTrim( StringUtil.Str( (decimal)(AV26gTTBUS_CodProveedor), 8, 0)));
                              }
                              AV29gTTBUS_DesProveedor = cgiGet( edtavGttbus_desproveedor_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29gTTBUS_DesProveedor", AV29gTTBUS_DesProveedor);
                              cmbavGttbus_estado.Name = cmbavGttbus_estado_Internalname ;
                              cmbavGttbus_estado.CurrentValue = cgiGet( cmbavGttbus_estado_Internalname) ;
                              AV30gTTBUS_Estado = (short)(NumberUtil.Val( cgiGet( cmbavGttbus_estado_Internalname), ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30gTTBUS_Estado", StringUtil.Str( (decimal)(AV30gTTBUS_Estado), 1, 0));
                              if ( ! context.localUtil.VCNumber( cgiGet( edtavGttbus_codposicion_Internalname), "ZZ9") || ( context.localUtil.CToN( cgiGet( edtavGttbus_codposicion_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavGttbus_codposicion_Internalname), ",", ".") > Convert.ToDecimal( 999 )) ) )
                              {
                                 GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vGTTBUS_CODPOSICION");
                                 GX_FocusControl = edtavGttbus_codposicion_Internalname ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                                 wbErr = true ;
                                 AV25gTTBUS_CodPosicion = 0 ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25gTTBUS_CodPosicion", StringUtil.LTrim( StringUtil.Str( (decimal)(AV25gTTBUS_CodPosicion), 3, 0)));
                              }
                              else
                              {
                                 AV25gTTBUS_CodPosicion = (short)(context.localUtil.CToN( cgiGet( edtavGttbus_codposicion_Internalname), ",", ".")) ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25gTTBUS_CodPosicion", StringUtil.LTrim( StringUtil.Str( (decimal)(AV25gTTBUS_CodPosicion), 3, 0)));
                              }
                              AV28gTTBUS_DesPosicion = cgiGet( edtavGttbus_desposicion_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28gTTBUS_DesPosicion", AV28gTTBUS_DesPosicion);
                              AV42SEC_CRE = cgiGet( edtavSec_cre_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV42SEC_CRE", AV42SEC_CRE);
                              AV43SEC_DRE = cgiGet( edtavSec_dre_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV43SEC_DRE", AV43SEC_DRE);
                              OldWc_bienes_a_recibir = cgiGet( "W0101") ;
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( WebComp_Wc_bienes_a_recibir_Component)) && ! String.IsNullOrEmpty(StringUtil.RTrim( OldWc_bienes_a_recibir)) )
                              {
                                 WebComp_Wc_bienes_a_recibir = getWebComponent(GetType(), "GeneXus.Programs", OldWc_bienes_a_recibir, new Object[] {context} );
                                 WebComp_Wc_bienes_a_recibir.ComponentInit();
                                 WebComp_Wc_bienes_a_recibir.Name = "OldWc_bienes_a_recibir";
                                 WebComp_Wc_bienes_a_recibir_Component = OldWc_bienes_a_recibir ;
                                 WebComp_Wc_bienes_a_recibir.componentrestorestate("W0101", "");
                              }
                              OldWc_bienes_enviados = cgiGet( "W0103") ;
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( WebComp_Wc_bienes_enviados_Component)) && ! String.IsNullOrEmpty(StringUtil.RTrim( OldWc_bienes_enviados)) )
                              {
                                 WebComp_Wc_bienes_enviados = getWebComponent(GetType(), "GeneXus.Programs", OldWc_bienes_enviados, new Object[] {context} );
                                 WebComp_Wc_bienes_enviados.ComponentInit();
                                 WebComp_Wc_bienes_enviados.Name = "OldWc_bienes_enviados";
                                 WebComp_Wc_bienes_enviados_Component = OldWc_bienes_enviados ;
                                 WebComp_Wc_bienes_enviados.componentrestorestate("W0103", "");
                              }
                              OldWc_tabs = cgiGet( "W0114") ;
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( WebComp_Wc_tabs_Component)) && ! String.IsNullOrEmpty(StringUtil.RTrim( OldWc_tabs)) )
                              {
                                 WebComp_Wc_tabs = getWebComponent(GetType(), "GeneXus.Programs", OldWc_tabs, new Object[] {context} );
                                 WebComp_Wc_tabs.ComponentInit();
                                 WebComp_Wc_tabs.Name = "OldWc_tabs";
                                 WebComp_Wc_tabs_Component = OldWc_tabs ;
                                 WebComp_Wc_tabs.componentrestorestate("W0114", "");
                              }
                              OldWc_bienes_a_recibir = cgiGet( "W0101") ;
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( WebComp_Wc_bienes_a_recibir_Component)) && ! String.IsNullOrEmpty(StringUtil.RTrim( OldWc_bienes_a_recibir)) )
                              {
                                 WebComp_Wc_bienes_a_recibir = getWebComponent(GetType(), "GeneXus.Programs", OldWc_bienes_a_recibir, new Object[] {context} );
                                 WebComp_Wc_bienes_a_recibir.ComponentInit();
                                 WebComp_Wc_bienes_a_recibir.Name = "OldWc_bienes_a_recibir";
                                 WebComp_Wc_bienes_a_recibir_Component = OldWc_bienes_a_recibir ;
                                 WebComp_Wc_bienes_a_recibir.componentrestorestate("W0101", "");
                              }
                              OldWc_bienes_enviados = cgiGet( "W0103") ;
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( WebComp_Wc_bienes_enviados_Component)) && ! String.IsNullOrEmpty(StringUtil.RTrim( OldWc_bienes_enviados)) )
                              {
                                 WebComp_Wc_bienes_enviados = getWebComponent(GetType(), "GeneXus.Programs", OldWc_bienes_enviados, new Object[] {context} );
                                 WebComp_Wc_bienes_enviados.ComponentInit();
                                 WebComp_Wc_bienes_enviados.Name = "OldWc_bienes_enviados";
                                 WebComp_Wc_bienes_enviados_Component = OldWc_bienes_enviados ;
                                 WebComp_Wc_bienes_enviados.componentrestorestate("W0103", "");
                              }
                              OldWc_tabs = cgiGet( "W0114") ;
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( WebComp_Wc_tabs_Component)) && ! String.IsNullOrEmpty(StringUtil.RTrim( OldWc_tabs)) )
                              {
                                 WebComp_Wc_tabs = getWebComponent(GetType(), "GeneXus.Programs", OldWc_tabs, new Object[] {context} );
                                 WebComp_Wc_tabs.ComponentInit();
                                 WebComp_Wc_tabs.Name = "OldWc_tabs";
                                 WebComp_Wc_tabs_Component = OldWc_tabs ;
                                 WebComp_Wc_tabs.componentrestorestate("W0114", "");
                              }
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E151M2 */
                                    E151M2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'ALTA'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E121M2 */
                                    E121M2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'BAJA'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E161M2 */
                                    E161M2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'MODIFICACION'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E171M2 */
                                    E171M2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'VISUALIZACION'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E181M2 */
                                    E181M2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID1.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E191M2 */
                                    E191M2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'MOVIMIENTOS'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E131M2 */
                                    E131M2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'LISTAR MOVIMIENTOS'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E141M2 */
                                    E141M2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'BUSCAR'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E111M2 */
                                    E111M2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false ;
                                       if ( ! Rfr0gs )
                                       {
                                       }
                                       dynload_actions( ) ;
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "CANCEL") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                 }
                              }
                              else
                              {
                              }
                           }
                        }
                     }
                     else if ( StringUtil.StrCmp(sEvtType, "W") == 0 )
                     {
                        sEvtType = StringUtil.Left( sEvt, 4) ;
                        sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-4)) ;
                        nCmpId = (short)(NumberUtil.Val( sEvtType, ".")) ;
                        if ( nCmpId == 101 )
                        {
                           OldWc_bienes_a_recibir = cgiGet( "W0101") ;
                           if ( ( StringUtil.Len( OldWc_bienes_a_recibir) == 0 ) || ( StringUtil.StrCmp(OldWc_bienes_a_recibir, WebComp_Wc_bienes_a_recibir_Component) != 0 ) )
                           {
                              WebComp_Wc_bienes_a_recibir = getWebComponent(GetType(), "GeneXus.Programs", OldWc_bienes_a_recibir, new Object[] {context} );
                              WebComp_Wc_bienes_a_recibir.ComponentInit();
                              WebComp_Wc_bienes_a_recibir.Name = "OldWc_bienes_a_recibir";
                              WebComp_Wc_bienes_a_recibir_Component = OldWc_bienes_a_recibir ;
                           }
                           if ( StringUtil.Len( WebComp_Wc_bienes_a_recibir_Component) != 0 )
                           {
                              WebComp_Wc_bienes_a_recibir.componentprocess("W0101", "", sEvt);
                           }
                           WebComp_Wc_bienes_a_recibir_Component = OldWc_bienes_a_recibir ;
                        }
                        else if ( nCmpId == 103 )
                        {
                           OldWc_bienes_enviados = cgiGet( "W0103") ;
                           if ( ( StringUtil.Len( OldWc_bienes_enviados) == 0 ) || ( StringUtil.StrCmp(OldWc_bienes_enviados, WebComp_Wc_bienes_enviados_Component) != 0 ) )
                           {
                              WebComp_Wc_bienes_enviados = getWebComponent(GetType(), "GeneXus.Programs", OldWc_bienes_enviados, new Object[] {context} );
                              WebComp_Wc_bienes_enviados.ComponentInit();
                              WebComp_Wc_bienes_enviados.Name = "OldWc_bienes_enviados";
                              WebComp_Wc_bienes_enviados_Component = OldWc_bienes_enviados ;
                           }
                           if ( StringUtil.Len( WebComp_Wc_bienes_enviados_Component) != 0 )
                           {
                              WebComp_Wc_bienes_enviados.componentprocess("W0103", "", sEvt);
                           }
                           WebComp_Wc_bienes_enviados_Component = OldWc_bienes_enviados ;
                        }
                        else if ( nCmpId == 114 )
                        {
                           OldWc_tabs = cgiGet( "W0114") ;
                           if ( ( StringUtil.Len( OldWc_tabs) == 0 ) || ( StringUtil.StrCmp(OldWc_tabs, WebComp_Wc_tabs_Component) != 0 ) )
                           {
                              WebComp_Wc_tabs = getWebComponent(GetType(), "GeneXus.Programs", OldWc_tabs, new Object[] {context} );
                              WebComp_Wc_tabs.ComponentInit();
                              WebComp_Wc_tabs.Name = "OldWc_tabs";
                              WebComp_Wc_tabs_Component = OldWc_tabs ;
                           }
                           WebComp_Wc_tabs.componentprocess("W0114", "", sEvt);
                           WebComp_Wc_tabs_Component = OldWc_tabs ;
                        }
                     }
                     context.wbHandled = 1 ;
                  }
               }
            }
         }
      }

      protected void WE1M2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true ;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               if ( nGXWrapped == 1 )
               {
                  RenderHtmlCloseForm( ) ;
               }
            }
         }
      }

      protected void PA1M2( )
      {
         if ( nDonePA == 0 )
         {
            dynavFididentificador.Name = "vFIDIDENTIFICADOR" ;
            dynavFididentificador.WebTags = "" ;
            dynavFididentificador.removeAllItems();
            /* Using cursor H001M3 */
            pr_default.execute(1);
            while ( (pr_default.getStatus(1) != 101) )
            {
               dynavFididentificador.addItem(StringUtil.Str( (decimal)(H001M3_A20TTBUS5_IdIdentificador[0]), 8, 0), H001M3_A21TTBUS5_DescIdentificador[0], 0);
               pr_default.readNext(1);
            }
            pr_default.close(1);
            if ( ( dynavFididentificador.ItemCount > 0 ) && (0==AV12fIdIdentificador) )
            {
               AV12fIdIdentificador = 1 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12fIdIdentificador", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12fIdIdentificador), 8, 0)));
            }
            cmbavFttbus_estado.Name = "vFTTBUS_ESTADO" ;
            cmbavFttbus_estado.WebTags = "" ;
            cmbavFttbus_estado.addItem(StringUtil.Str( (decimal)(0), 1, 0), "TODOS", 0);
            cmbavFttbus_estado.addItem("1", "ASIGNADO A UN SECTOR", 0);
            cmbavFttbus_estado.addItem("2", "CAMBIANDO DE SECTOR", 0);
            if ( ( cmbavFttbus_estado.ItemCount > 0 ) && (0==AV15fTTBUS_Estado) )
            {
               AV15fTTBUS_Estado = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15fTTBUS_Estado", StringUtil.Str( (decimal)(AV15fTTBUS_Estado), 1, 0));
            }
            cmbavTtbus7_pos.Name = "vTTBUS7_POS" ;
            cmbavTtbus7_pos.WebTags = "" ;
            if ( ( cmbavTtbus7_pos.ItemCount > 0 ) && (0==AV60TTBUS7_Pos) )
            {
               AV60TTBUS7_Pos = (short)(NumberUtil.Val( cmbavTtbus7_pos.getItemValue(1), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV60TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(AV60TTBUS7_Pos), 3, 0)));
            }
            GXCCtl = "vGTTBUS_ALQUILADO_" + sGXsfl_61_idx ;
            chkavGttbus_alquilado.Name = GXCCtl ;
            chkavGttbus_alquilado.WebTags = "" ;
            chkavGttbus_alquilado.Caption = "" ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavGttbus_alquilado_Internalname, "Caption", chkavGttbus_alquilado.Caption);
            chkavGttbus_alquilado.CheckedValue = "0" ;
            GXCCtl = "vGTTBUS_ESTADO_" + sGXsfl_61_idx ;
            cmbavGttbus_estado.Name = GXCCtl ;
            cmbavGttbus_estado.WebTags = "" ;
            cmbavGttbus_estado.addItem("1", "ASIGNADO A UN SECTOR", 0);
            cmbavGttbus_estado.addItem("2", "CAMBIANDO DE SECTOR", 0);
            cmbavGttbus_estado.addItem("3", "BAJA A CONFIRMAR", 0);
            cmbavGttbus_estado.addItem("4", "BAJA", 0);
            if ( ( cmbavGttbus_estado.ItemCount > 0 ) && (0==AV30gTTBUS_Estado) )
            {
               AV30gTTBUS_Estado = (short)(NumberUtil.Val( cmbavGttbus_estado.getItemValue(1), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30gTTBUS_Estado", StringUtil.Str( (decimal)(AV30gTTBUS_Estado), 1, 0));
            }
            GX_FocusControl = dynavFididentificador_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void GXSGVvFTTBUS_DESCRIPCION1M0( String A12TTBUS_Descripcion )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
         }
         context.GX_webresponse.AddString("(new Array( new Array(");
         GXSGVvFTTBUS_DESCRIPCION_data1M0( A12TTBUS_Descripcion) ;
         gxdynajaxindex = 1 ;
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            context.GX_webresponse.AddString(gxwrpcisep+"{c:\""+GXUtil.EncodeJSConstant( gxdynajaxctrlcodr.Item(gxdynajaxindex))+"\",d:\""+GXUtil.EncodeJSConstant( gxdynajaxctrldescr.Item(gxdynajaxindex))+"\"}");
            gxdynajaxindex = (int)(gxdynajaxindex+1) ;
            gxwrpcisep = "," ;
         }
         context.GX_webresponse.AddString(")");
         if ( gxdynajaxctrlcodr.Count == 0 )
         {
            context.GX_webresponse.AddString(",101");
         }
         context.GX_webresponse.AddString("))");
      }

      protected void GXSGVvFTTBUS_DESCRIPCION_data1M0( String A12TTBUS_Descripcion )
      {
         l12TTBUS_Descripcion = StringUtil.PadR( StringUtil.RTrim( A12TTBUS_Descripcion), 50, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12TTBUS_Descripcion", A12TTBUS_Descripcion);
         /* Using cursor H001M4 */
         pr_default.execute(2, new Object[] {l12TTBUS_Descripcion});
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         while ( (pr_default.getStatus(2) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.RTrim( H001M4_A12TTBUS_Descripcion[0]));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( H001M4_A12TTBUS_Descripcion[0]));
            pr_default.readNext(2);
         }
         pr_default.close(2);
      }

      protected void GXSGVvGTTBUS_DESCRIPCION1M0( String A12TTBUS_Descripcion )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
         }
         context.GX_webresponse.AddString("(new Array( new Array(");
         GXSGVvGTTBUS_DESCRIPCION_data1M0( A12TTBUS_Descripcion) ;
         gxdynajaxindex = 1 ;
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            context.GX_webresponse.AddString(gxwrpcisep+"{c:\""+GXUtil.EncodeJSConstant( gxdynajaxctrlcodr.Item(gxdynajaxindex))+"\",d:\""+GXUtil.EncodeJSConstant( gxdynajaxctrldescr.Item(gxdynajaxindex))+"\"}");
            gxdynajaxindex = (int)(gxdynajaxindex+1) ;
            gxwrpcisep = "," ;
         }
         context.GX_webresponse.AddString(")");
         if ( gxdynajaxctrlcodr.Count == 0 )
         {
            context.GX_webresponse.AddString(",101");
         }
         context.GX_webresponse.AddString("))");
      }

      protected void GXSGVvGTTBUS_DESCRIPCION_data1M0( String A12TTBUS_Descripcion )
      {
         l12TTBUS_Descripcion = StringUtil.PadR( StringUtil.RTrim( A12TTBUS_Descripcion), 50, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12TTBUS_Descripcion", A12TTBUS_Descripcion);
         /* Using cursor H001M5 */
         pr_default.execute(3, new Object[] {l12TTBUS_Descripcion});
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         while ( (pr_default.getStatus(3) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.RTrim( H001M5_A12TTBUS_Descripcion[0]));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( H001M5_A12TTBUS_Descripcion[0]));
            pr_default.readNext(3);
         }
         pr_default.close(3);
      }

      protected void gxnrGrid1_newrow( short nRC_Grid1 ,
                                       short nGXsfl_61_idx ,
                                       String sGXsfl_61_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         edtavBaja_Internalname = "vBAJA_"+sGXsfl_61_idx ;
         edtavEdicion_Internalname = "vEDICION_"+sGXsfl_61_idx ;
         edtavVisualizacion_Internalname = "vVISUALIZACION_"+sGXsfl_61_idx ;
         edtavGididentificador_Internalname = "vGIDIDENTIFICADOR_"+sGXsfl_61_idx ;
         edtavGnumeroidentificador_Internalname = "vGNUMEROIDENTIFICADOR_"+sGXsfl_61_idx ;
         edtavGttbus_id_Internalname = "vGTTBUS_ID_"+sGXsfl_61_idx ;
         edtavGttbus_descripcion_Internalname = "vGTTBUS_DESCRIPCION_"+sGXsfl_61_idx ;
         edtavGttbus_fechacarga_Internalname = "vGTTBUS_FECHACARGA_"+sGXsfl_61_idx ;
         edtavGttbus_rubrobien_Internalname = "vGTTBUS_RUBROBIEN_"+sGXsfl_61_idx ;
         edtavGttbus_rubrodesc_Internalname = "vGTTBUS_RUBRODESC_"+sGXsfl_61_idx ;
         edtavGttbus_fechabaja_Internalname = "vGTTBUS_FECHABAJA_"+sGXsfl_61_idx ;
         chkavGttbus_alquilado_Internalname = "vGTTBUS_ALQUILADO_"+sGXsfl_61_idx ;
         edtavGttbus_codproveedor_Internalname = "vGTTBUS_CODPROVEEDOR_"+sGXsfl_61_idx ;
         edtavGttbus_desproveedor_Internalname = "vGTTBUS_DESPROVEEDOR_"+sGXsfl_61_idx ;
         cmbavGttbus_estado_Internalname = "vGTTBUS_ESTADO_"+sGXsfl_61_idx ;
         edtavGttbus_codposicion_Internalname = "vGTTBUS_CODPOSICION_"+sGXsfl_61_idx ;
         edtavGttbus_desposicion_Internalname = "vGTTBUS_DESPOSICION_"+sGXsfl_61_idx ;
         edtavSec_cre_Internalname = "vSEC_CRE_"+sGXsfl_61_idx ;
         edtavSec_dre_Internalname = "vSEC_DRE_"+sGXsfl_61_idx ;
         while ( nGXsfl_61_idx <= nRC_Grid1 )
         {
            sendrow_612( ) ;
            nGXsfl_61_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_61_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_61_idx+1)) ;
            sGXsfl_61_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_61_idx), 4, 0)), 4, "0") ;
            edtavBaja_Internalname = "vBAJA_"+sGXsfl_61_idx ;
            edtavEdicion_Internalname = "vEDICION_"+sGXsfl_61_idx ;
            edtavVisualizacion_Internalname = "vVISUALIZACION_"+sGXsfl_61_idx ;
            edtavGididentificador_Internalname = "vGIDIDENTIFICADOR_"+sGXsfl_61_idx ;
            edtavGnumeroidentificador_Internalname = "vGNUMEROIDENTIFICADOR_"+sGXsfl_61_idx ;
            edtavGttbus_id_Internalname = "vGTTBUS_ID_"+sGXsfl_61_idx ;
            edtavGttbus_descripcion_Internalname = "vGTTBUS_DESCRIPCION_"+sGXsfl_61_idx ;
            edtavGttbus_fechacarga_Internalname = "vGTTBUS_FECHACARGA_"+sGXsfl_61_idx ;
            edtavGttbus_rubrobien_Internalname = "vGTTBUS_RUBROBIEN_"+sGXsfl_61_idx ;
            edtavGttbus_rubrodesc_Internalname = "vGTTBUS_RUBRODESC_"+sGXsfl_61_idx ;
            edtavGttbus_fechabaja_Internalname = "vGTTBUS_FECHABAJA_"+sGXsfl_61_idx ;
            chkavGttbus_alquilado_Internalname = "vGTTBUS_ALQUILADO_"+sGXsfl_61_idx ;
            edtavGttbus_codproveedor_Internalname = "vGTTBUS_CODPROVEEDOR_"+sGXsfl_61_idx ;
            edtavGttbus_desproveedor_Internalname = "vGTTBUS_DESPROVEEDOR_"+sGXsfl_61_idx ;
            cmbavGttbus_estado_Internalname = "vGTTBUS_ESTADO_"+sGXsfl_61_idx ;
            edtavGttbus_codposicion_Internalname = "vGTTBUS_CODPOSICION_"+sGXsfl_61_idx ;
            edtavGttbus_desposicion_Internalname = "vGTTBUS_DESPOSICION_"+sGXsfl_61_idx ;
            edtavSec_cre_Internalname = "vSEC_CRE_"+sGXsfl_61_idx ;
            edtavSec_dre_Internalname = "vSEC_DRE_"+sGXsfl_61_idx ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int Grid1_PageSize61 ,
                                        short AV8band_2 ,
                                        String AV62USUARIO ,
                                        String A7USU_DES ,
                                        String A6USU_COD ,
                                        String A25TTBUS2_RespHacia ,
                                        String A24TTBUS2_RespDesde ,
                                        String A36TTBUS7_DesResp ,
                                        String A35TTBUS7_CodResp ,
                                        short A33TTBUS7_Pos ,
                                        int A14IdIdentificador ,
                                        String A18TTBUS_RubroDesc ,
                                        short A17TTBUS_RubroBien ,
                                        int A11TTBUS_Id ,
                                        DateTime A13TTBUS_FechaCarga ,
                                        DateTime A16TTBUS_FechaBaja ,
                                        short A23TTBUS_Estado ,
                                        String A30TTBUS_DesProveedor ,
                                        String A38TTBUS_DesPosicion ,
                                        String A12TTBUS_Descripcion ,
                                        int A27TTBUS_CodProveedor ,
                                        short A37TTBUS_CodPosicion ,
                                        short A29TTBUS_Alquilado ,
                                        String A15NumeroIdentificador ,
                                        String AV13fNumeroIdentificador )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         disableOutput();
         subGrid1_Rows = (short)(Grid1_PageSize61) ;
         RF1M2( ) ;
         enableOutput();
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxgrGrid1_refresh */
      }

      protected void Refresh( )
      {
         RF1M2( ) ;
         /* End function Refresh */
      }

      protected void RF1M2( )
      {
         Grid1Container.PageSize = subGrid1_Recordsperpage( ) ;
         wbStart = 61 ;
         nGXsfl_61_idx = 1 ;
         sGXsfl_61_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_61_idx), 4, 0)), 4, "0") ;
         edtavBaja_Internalname = "vBAJA_"+sGXsfl_61_idx ;
         edtavEdicion_Internalname = "vEDICION_"+sGXsfl_61_idx ;
         edtavVisualizacion_Internalname = "vVISUALIZACION_"+sGXsfl_61_idx ;
         edtavGididentificador_Internalname = "vGIDIDENTIFICADOR_"+sGXsfl_61_idx ;
         edtavGnumeroidentificador_Internalname = "vGNUMEROIDENTIFICADOR_"+sGXsfl_61_idx ;
         edtavGttbus_id_Internalname = "vGTTBUS_ID_"+sGXsfl_61_idx ;
         edtavGttbus_descripcion_Internalname = "vGTTBUS_DESCRIPCION_"+sGXsfl_61_idx ;
         edtavGttbus_fechacarga_Internalname = "vGTTBUS_FECHACARGA_"+sGXsfl_61_idx ;
         edtavGttbus_rubrobien_Internalname = "vGTTBUS_RUBROBIEN_"+sGXsfl_61_idx ;
         edtavGttbus_rubrodesc_Internalname = "vGTTBUS_RUBRODESC_"+sGXsfl_61_idx ;
         edtavGttbus_fechabaja_Internalname = "vGTTBUS_FECHABAJA_"+sGXsfl_61_idx ;
         chkavGttbus_alquilado_Internalname = "vGTTBUS_ALQUILADO_"+sGXsfl_61_idx ;
         edtavGttbus_codproveedor_Internalname = "vGTTBUS_CODPROVEEDOR_"+sGXsfl_61_idx ;
         edtavGttbus_desproveedor_Internalname = "vGTTBUS_DESPROVEEDOR_"+sGXsfl_61_idx ;
         cmbavGttbus_estado_Internalname = "vGTTBUS_ESTADO_"+sGXsfl_61_idx ;
         edtavGttbus_codposicion_Internalname = "vGTTBUS_CODPOSICION_"+sGXsfl_61_idx ;
         edtavGttbus_desposicion_Internalname = "vGTTBUS_DESPOSICION_"+sGXsfl_61_idx ;
         edtavSec_cre_Internalname = "vSEC_CRE_"+sGXsfl_61_idx ;
         edtavSec_dre_Internalname = "vSEC_DRE_"+sGXsfl_61_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            if ( StringUtil.StrCmp(WebComp_Wc_bienes_a_recibir_Component, "") == 0 )
            {
               WebComp_Wc_bienes_a_recibir = getWebComponent(GetType(), "GeneXus.Programs", "htbus004", new Object[] {context} );
               WebComp_Wc_bienes_a_recibir.ComponentInit();
               WebComp_Wc_bienes_a_recibir.Name = "HTBUS004";
               WebComp_Wc_bienes_a_recibir_Component = "HTBUS004" ;
            }
            if ( ( StringUtil.StrCmp(OldWc_bienes_a_recibir, WebComp_Wc_bienes_a_recibir_Component) != 0 ) && ( StringUtil.StrCmp(WebComp_Wc_bienes_a_recibir_Component, "HTBUS004") == 0 ) )
            {
               WebComp_Wc_bienes_a_recibir.setjustcreated();
            }
            if ( ( StringUtil.Len( WebComp_Wc_bienes_a_recibir_Component) != 0 ) && ( StringUtil.StrCmp(WebComp_Wc_bienes_a_recibir_Component, "HTBUS004") == 0 ) )
            {
               WebComp_Wc_bienes_a_recibir.componentprepare(new Object[] {(String)"W0101",(String)"",(String)AV62USUARIO,(String)AV45SISTEMA});
               WebComp_Wc_bienes_a_recibir.componentbind(new Object[] {(String)"",(String)""});
            }
            if ( 1 != 0 )
            {
               if ( StringUtil.Len( WebComp_Wc_bienes_a_recibir_Component) != 0 )
               {
                  WebComp_Wc_bienes_a_recibir.componentstart();
               }
            }
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            if ( StringUtil.StrCmp(WebComp_Wc_bienes_enviados_Component, "") == 0 )
            {
               WebComp_Wc_bienes_enviados = getWebComponent(GetType(), "GeneXus.Programs", "htbus003_", new Object[] {context} );
               WebComp_Wc_bienes_enviados.ComponentInit();
               WebComp_Wc_bienes_enviados.Name = "HTBUS003_";
               WebComp_Wc_bienes_enviados_Component = "HTBUS003_" ;
            }
            if ( ( StringUtil.StrCmp(OldWc_bienes_enviados, WebComp_Wc_bienes_enviados_Component) != 0 ) && ( StringUtil.StrCmp(WebComp_Wc_bienes_enviados_Component, "HTBUS003_") == 0 ) )
            {
               WebComp_Wc_bienes_enviados.setjustcreated();
            }
            if ( ( StringUtil.Len( WebComp_Wc_bienes_enviados_Component) != 0 ) && ( StringUtil.StrCmp(WebComp_Wc_bienes_enviados_Component, "HTBUS003_") == 0 ) )
            {
               WebComp_Wc_bienes_enviados.componentprepare(new Object[] {(String)"W0103",(String)"",(String)AV62USUARIO,(String)AV45SISTEMA});
               WebComp_Wc_bienes_enviados.componentbind(new Object[] {(String)"",(String)""});
            }
            if ( 1 != 0 )
            {
               if ( StringUtil.Len( WebComp_Wc_bienes_enviados_Component) != 0 )
               {
                  WebComp_Wc_bienes_enviados.componentstart();
               }
            }
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            if ( 1 != 0 )
            {
               WebComp_Wc_tabs.componentstart();
            }
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtavBaja_Internalname = "vBAJA_"+sGXsfl_61_idx ;
            edtavEdicion_Internalname = "vEDICION_"+sGXsfl_61_idx ;
            edtavVisualizacion_Internalname = "vVISUALIZACION_"+sGXsfl_61_idx ;
            edtavGididentificador_Internalname = "vGIDIDENTIFICADOR_"+sGXsfl_61_idx ;
            edtavGnumeroidentificador_Internalname = "vGNUMEROIDENTIFICADOR_"+sGXsfl_61_idx ;
            edtavGttbus_id_Internalname = "vGTTBUS_ID_"+sGXsfl_61_idx ;
            edtavGttbus_descripcion_Internalname = "vGTTBUS_DESCRIPCION_"+sGXsfl_61_idx ;
            edtavGttbus_fechacarga_Internalname = "vGTTBUS_FECHACARGA_"+sGXsfl_61_idx ;
            edtavGttbus_rubrobien_Internalname = "vGTTBUS_RUBROBIEN_"+sGXsfl_61_idx ;
            edtavGttbus_rubrodesc_Internalname = "vGTTBUS_RUBRODESC_"+sGXsfl_61_idx ;
            edtavGttbus_fechabaja_Internalname = "vGTTBUS_FECHABAJA_"+sGXsfl_61_idx ;
            chkavGttbus_alquilado_Internalname = "vGTTBUS_ALQUILADO_"+sGXsfl_61_idx ;
            edtavGttbus_codproveedor_Internalname = "vGTTBUS_CODPROVEEDOR_"+sGXsfl_61_idx ;
            edtavGttbus_desproveedor_Internalname = "vGTTBUS_DESPROVEEDOR_"+sGXsfl_61_idx ;
            cmbavGttbus_estado_Internalname = "vGTTBUS_ESTADO_"+sGXsfl_61_idx ;
            edtavGttbus_codposicion_Internalname = "vGTTBUS_CODPOSICION_"+sGXsfl_61_idx ;
            edtavGttbus_desposicion_Internalname = "vGTTBUS_DESPOSICION_"+sGXsfl_61_idx ;
            edtavSec_cre_Internalname = "vSEC_CRE_"+sGXsfl_61_idx ;
            edtavSec_dre_Internalname = "vSEC_DRE_"+sGXsfl_61_idx ;
            /* Execute user event: E191M2 */
            E191M2 ();
            wbEnd = 61 ;
            WB1M0( ) ;
         }
      }

      protected int subGrid1_Pagecount( )
      {
         return (int)(-1) ;
      }

      protected int subGrid1_Recordcount( )
      {
         return (int)(-1) ;
      }

      protected int subGrid1_Recordsperpage( )
      {
         if ( 10 > 0 )
         {
            if ( 1 > 0 )
            {
               return (int)(10*1) ;
            }
            else
            {
               return (int)(10) ;
            }
         }
         return (int)(-1) ;
      }

      protected int subGrid1_Currentpage( )
      {
         return (int)(-1) ;
      }

      protected short subgrid1_firstpage( )
      {
         GRID1_nFirstRecordOnPage = 0 ;
         return 0 ;
      }

      protected short subgrid1_nextpage( )
      {
         if ( GRID1_nEOF == 0 )
         {
            GRID1_nFirstRecordOnPage = (int)(GRID1_nFirstRecordOnPage+subGrid1_Recordsperpage( )) ;
         }
         return 0 ;
      }

      protected short subgrid1_previouspage( )
      {
         if ( GRID1_nFirstRecordOnPage >= subGrid1_Recordsperpage( ) )
         {
            GRID1_nFirstRecordOnPage = (int)(GRID1_nFirstRecordOnPage-subGrid1_Recordsperpage( )) ;
         }
         else
         {
            return 2 ;
         }
         return 0 ;
      }

      protected short subgrid1_lastpage( )
      {
         subGrid1_Islastpage = 1 ;
         return 3 ;
      }

      protected int subgrid1_gotopage( int nPageNo )
      {
         if ( nPageNo > 0 )
         {
            int gx_pageCount = subGrid1_Pagecount( ) ;
            if ( ( nPageNo <= gx_pageCount ) || ( gx_pageCount == -1 ) )
            {
               GRID1_nFirstRecordOnPage = (int)(subGrid1_Recordsperpage( )*(nPageNo-1)) ;
            }
            else
            {
               GRID1_nFirstRecordOnPage = (int)(subGrid1_Recordsperpage( )*(gx_pageCount-1)) ;
            }
         }
         else
         {
            GRID1_nFirstRecordOnPage = 0 ;
         }
         return (int)(0) ;
      }

      protected void STRUP1M0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         edtavGididentificador_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGididentificador_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGididentificador_Enabled), 5, 0)));
         edtavGnumeroidentificador_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGnumeroidentificador_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGnumeroidentificador_Enabled), 5, 0)));
         edtavGttbus_id_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGttbus_id_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGttbus_id_Enabled), 5, 0)));
         edtavGttbus_descripcion_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGttbus_descripcion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGttbus_descripcion_Enabled), 5, 0)));
         edtavGttbus_fechacarga_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGttbus_fechacarga_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGttbus_fechacarga_Enabled), 5, 0)));
         edtavGttbus_rubrobien_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGttbus_rubrobien_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGttbus_rubrobien_Enabled), 5, 0)));
         edtavGttbus_rubrodesc_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGttbus_rubrodesc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGttbus_rubrodesc_Enabled), 5, 0)));
         edtavGttbus_fechabaja_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGttbus_fechabaja_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGttbus_fechabaja_Enabled), 5, 0)));
         chkavGttbus_alquilado.Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavGttbus_alquilado_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(chkavGttbus_alquilado.Enabled), 5, 0)));
         edtavGttbus_codproveedor_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGttbus_codproveedor_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGttbus_codproveedor_Enabled), 5, 0)));
         edtavGttbus_desproveedor_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGttbus_desproveedor_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGttbus_desproveedor_Enabled), 5, 0)));
         cmbavGttbus_estado.Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavGttbus_estado_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavGttbus_estado.Enabled), 5, 0)));
         edtavGttbus_codposicion_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGttbus_codposicion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGttbus_codposicion_Enabled), 5, 0)));
         edtavGttbus_desposicion_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGttbus_desposicion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGttbus_desposicion_Enabled), 5, 0)));
         edtavSec_cre_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSec_cre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavSec_cre_Enabled), 5, 0)));
         edtavSec_dre_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSec_dre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavSec_dre_Enabled), 5, 0)));
         imgprompt_Ttbus_rubrobien_Link = "javascript:"+"gx.popup.openPrompt('"+"htbus_rub.aspx"+"',["+"{Ctrl:gx.dom.el('"+"vTTBUS_RUBROBIEN"+"'), id:'"+"vTTBUS_RUBROBIEN"+"'"+",isOut:true,isKey:false,isLastKey:false}"+"],"+"null"+","+"'', false"+","+"false"+","+"false"+");" ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E151M2 */
         E151M2 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            dynavFididentificador.Name = dynavFididentificador_Internalname ;
            dynavFididentificador.CurrentValue = cgiGet( dynavFididentificador_Internalname) ;
            AV12fIdIdentificador = (int)(NumberUtil.Val( cgiGet( dynavFididentificador_Internalname), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12fIdIdentificador", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12fIdIdentificador), 8, 0)));
            if ( ! context.localUtil.VCNumber( cgiGet( edtavTtbus_id_Internalname), "ZZZZZZZ9") || ( context.localUtil.CToN( cgiGet( edtavTtbus_id_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavTtbus_id_Internalname), ",", ".") > Convert.ToDecimal( 99999999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vTTBUS_ID");
               GX_FocusControl = edtavTtbus_id_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV55TTBUS_Id = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV55TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(AV55TTBUS_Id), 8, 0)));
            }
            else
            {
               AV55TTBUS_Id = (int)(context.localUtil.CToN( cgiGet( edtavTtbus_id_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV55TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(AV55TTBUS_Id), 8, 0)));
            }
            AV13fNumeroIdentificador = cgiGet( edtavFnumeroidentificador_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13fNumeroIdentificador", AV13fNumeroIdentificador);
            cmbavFttbus_estado.Name = cmbavFttbus_estado_Internalname ;
            cmbavFttbus_estado.CurrentValue = cgiGet( cmbavFttbus_estado_Internalname) ;
            AV15fTTBUS_Estado = (short)(NumberUtil.Val( cgiGet( cmbavFttbus_estado_Internalname), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15fTTBUS_Estado", StringUtil.Str( (decimal)(AV15fTTBUS_Estado), 1, 0));
            AV14fTTBUS_Descripcion = StringUtil.Upper( cgiGet( edtavFttbus_descripcion_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14fTTBUS_Descripcion", AV14fTTBUS_Descripcion);
            if ( ! context.localUtil.VCNumber( cgiGet( edtavTtbus_rubrobien_Internalname), "ZZZ9") || ( context.localUtil.CToN( cgiGet( edtavTtbus_rubrobien_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavTtbus_rubrobien_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vTTBUS_RUBROBIEN");
               GX_FocusControl = edtavTtbus_rubrobien_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV56TTBUS_RubroBien = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV56TTBUS_RubroBien", StringUtil.LTrim( StringUtil.Str( (decimal)(AV56TTBUS_RubroBien), 4, 0)));
            }
            else
            {
               AV56TTBUS_RubroBien = (short)(context.localUtil.CToN( cgiGet( edtavTtbus_rubrobien_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV56TTBUS_RubroBien", StringUtil.LTrim( StringUtil.Str( (decimal)(AV56TTBUS_RubroBien), 4, 0)));
            }
            cmbavTtbus7_pos.Name = cmbavTtbus7_pos_Internalname ;
            cmbavTtbus7_pos.CurrentValue = cgiGet( cmbavTtbus7_pos_Internalname) ;
            AV60TTBUS7_Pos = (short)(NumberUtil.Val( cgiGet( cmbavTtbus7_pos_Internalname), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV60TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(AV60TTBUS7_Pos), 3, 0)));
            if ( context.localUtil.VCDate( cgiGet( edtavTtbus_fechacarga_Internalname), 4) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"TTBUS_ Fecha Carga"}), 1, "vTTBUS_FECHACARGA");
               GX_FocusControl = edtavTtbus_fechacarga_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV54TTBUS_FechaCarga = DateTime.MinValue ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV54TTBUS_FechaCarga", context.localUtil.Format(AV54TTBUS_FechaCarga, "99/99/9999"));
            }
            else
            {
               AV54TTBUS_FechaCarga = context.localUtil.CToD( cgiGet( edtavTtbus_fechacarga_Internalname), 4) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV54TTBUS_FechaCarga", context.localUtil.Format(AV54TTBUS_FechaCarga, "99/99/9999"));
            }
            /* Read saved values. */
            nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ",", ".")) ;
            AV45SISTEMA = cgiGet( "vSISTEMA") ;
            AV62USUARIO = cgiGet( "vUSUARIO") ;
            GRID1_nFirstRecordOnPage = (int)(context.localUtil.CToN( cgiGet( "GRID1_nFirstRecordOnPage"), ",", ".")) ;
            GRID1_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID1_nEOF"), ",", ".")) ;
            OldWc_bienes_a_recibir = cgiGet( "W0101") ;
            if ( String.IsNullOrEmpty(StringUtil.RTrim( WebComp_Wc_bienes_a_recibir_Component)) && ! String.IsNullOrEmpty(StringUtil.RTrim( OldWc_bienes_a_recibir)) )
            {
               WebComp_Wc_bienes_a_recibir = getWebComponent(GetType(), "GeneXus.Programs", OldWc_bienes_a_recibir, new Object[] {context} );
               WebComp_Wc_bienes_a_recibir.ComponentInit();
               WebComp_Wc_bienes_a_recibir.Name = "OldWc_bienes_a_recibir";
               WebComp_Wc_bienes_a_recibir_Component = OldWc_bienes_a_recibir ;
               WebComp_Wc_bienes_a_recibir.componentrestorestate("W0101", "");
            }
            OldWc_bienes_enviados = cgiGet( "W0103") ;
            if ( String.IsNullOrEmpty(StringUtil.RTrim( WebComp_Wc_bienes_enviados_Component)) && ! String.IsNullOrEmpty(StringUtil.RTrim( OldWc_bienes_enviados)) )
            {
               WebComp_Wc_bienes_enviados = getWebComponent(GetType(), "GeneXus.Programs", OldWc_bienes_enviados, new Object[] {context} );
               WebComp_Wc_bienes_enviados.ComponentInit();
               WebComp_Wc_bienes_enviados.Name = "OldWc_bienes_enviados";
               WebComp_Wc_bienes_enviados_Component = OldWc_bienes_enviados ;
               WebComp_Wc_bienes_enviados.componentrestorestate("W0103", "");
            }
            OldWc_tabs = cgiGet( "W0114") ;
            if ( String.IsNullOrEmpty(StringUtil.RTrim( WebComp_Wc_tabs_Component)) && ! String.IsNullOrEmpty(StringUtil.RTrim( OldWc_tabs)) )
            {
               WebComp_Wc_tabs = getWebComponent(GetType(), "GeneXus.Programs", OldWc_tabs, new Object[] {context} );
               WebComp_Wc_tabs.ComponentInit();
               WebComp_Wc_tabs.Name = "OldWc_tabs";
               WebComp_Wc_tabs_Component = OldWc_tabs ;
               WebComp_Wc_tabs.componentrestorestate("W0114", "");
            }
            /* Read subfile selected row values. */
            nGXsfl_61_idx = (short)(context.localUtil.CToN( cgiGet( subGrid1_Internalname+"_ROW"), ",", ".")) ;
            sGXsfl_61_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_61_idx), 4, 0)), 4, "0") ;
            edtavBaja_Internalname = "vBAJA_"+sGXsfl_61_idx ;
            edtavEdicion_Internalname = "vEDICION_"+sGXsfl_61_idx ;
            edtavVisualizacion_Internalname = "vVISUALIZACION_"+sGXsfl_61_idx ;
            edtavGididentificador_Internalname = "vGIDIDENTIFICADOR_"+sGXsfl_61_idx ;
            edtavGnumeroidentificador_Internalname = "vGNUMEROIDENTIFICADOR_"+sGXsfl_61_idx ;
            edtavGttbus_id_Internalname = "vGTTBUS_ID_"+sGXsfl_61_idx ;
            edtavGttbus_descripcion_Internalname = "vGTTBUS_DESCRIPCION_"+sGXsfl_61_idx ;
            edtavGttbus_fechacarga_Internalname = "vGTTBUS_FECHACARGA_"+sGXsfl_61_idx ;
            edtavGttbus_rubrobien_Internalname = "vGTTBUS_RUBROBIEN_"+sGXsfl_61_idx ;
            edtavGttbus_rubrodesc_Internalname = "vGTTBUS_RUBRODESC_"+sGXsfl_61_idx ;
            edtavGttbus_fechabaja_Internalname = "vGTTBUS_FECHABAJA_"+sGXsfl_61_idx ;
            chkavGttbus_alquilado_Internalname = "vGTTBUS_ALQUILADO_"+sGXsfl_61_idx ;
            edtavGttbus_codproveedor_Internalname = "vGTTBUS_CODPROVEEDOR_"+sGXsfl_61_idx ;
            edtavGttbus_desproveedor_Internalname = "vGTTBUS_DESPROVEEDOR_"+sGXsfl_61_idx ;
            cmbavGttbus_estado_Internalname = "vGTTBUS_ESTADO_"+sGXsfl_61_idx ;
            edtavGttbus_codposicion_Internalname = "vGTTBUS_CODPOSICION_"+sGXsfl_61_idx ;
            edtavGttbus_desposicion_Internalname = "vGTTBUS_DESPOSICION_"+sGXsfl_61_idx ;
            edtavSec_cre_Internalname = "vSEC_CRE_"+sGXsfl_61_idx ;
            edtavSec_dre_Internalname = "vSEC_DRE_"+sGXsfl_61_idx ;
            if ( nGXsfl_61_idx > 0 )
            {
               AV5baja = cgiGet( "GXimg"+edtavBaja_Internalname) ;
               AV11edicion = cgiGet( "GXimg"+edtavEdicion_Internalname) ;
               AV63visualizacion = cgiGet( "GXimg"+edtavVisualizacion_Internalname) ;
               if ( ! context.localUtil.VCNumber( cgiGet( edtavGididentificador_Internalname), "ZZZZZZZ9") || ( context.localUtil.CToN( cgiGet( edtavGididentificador_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavGididentificador_Internalname), ",", ".") > Convert.ToDecimal( 99999999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vGIDIDENTIFICADOR");
                  GX_FocusControl = edtavGididentificador_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  AV22gIdIdentificador = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22gIdIdentificador", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22gIdIdentificador), 8, 0)));
               }
               else
               {
                  AV22gIdIdentificador = (int)(context.localUtil.CToN( cgiGet( edtavGididentificador_Internalname), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22gIdIdentificador", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22gIdIdentificador), 8, 0)));
               }
               AV23gNumeroIdentificador = cgiGet( edtavGnumeroidentificador_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23gNumeroIdentificador", AV23gNumeroIdentificador);
               if ( ! context.localUtil.VCNumber( cgiGet( edtavGttbus_id_Internalname), "ZZZZZZZ9") || ( context.localUtil.CToN( cgiGet( edtavGttbus_id_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavGttbus_id_Internalname), ",", ".") > Convert.ToDecimal( 99999999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vGTTBUS_ID");
                  GX_FocusControl = edtavGttbus_id_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  AV33gTTBUS_ID = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33gTTBUS_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV33gTTBUS_ID), 8, 0)));
               }
               else
               {
                  AV33gTTBUS_ID = (int)(context.localUtil.CToN( cgiGet( edtavGttbus_id_Internalname), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33gTTBUS_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV33gTTBUS_ID), 8, 0)));
               }
               AV27gTTBUS_Descripcion = StringUtil.Upper( cgiGet( edtavGttbus_descripcion_Internalname)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27gTTBUS_Descripcion", AV27gTTBUS_Descripcion);
               if ( context.localUtil.VCDate( cgiGet( edtavGttbus_fechacarga_Internalname), 4) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"g TTBUS_ Fecha Carga"}), 1, "vGTTBUS_FECHACARGA");
                  GX_FocusControl = edtavGttbus_fechacarga_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  AV32gTTBUS_FechaCarga = DateTime.MinValue ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32gTTBUS_FechaCarga", context.localUtil.Format(AV32gTTBUS_FechaCarga, "99/99/9999"));
               }
               else
               {
                  AV32gTTBUS_FechaCarga = context.localUtil.CToD( cgiGet( edtavGttbus_fechacarga_Internalname), 4) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32gTTBUS_FechaCarga", context.localUtil.Format(AV32gTTBUS_FechaCarga, "99/99/9999"));
               }
               if ( ! context.localUtil.VCNumber( cgiGet( edtavGttbus_rubrobien_Internalname), "ZZZ9") || ( context.localUtil.CToN( cgiGet( edtavGttbus_rubrobien_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavGttbus_rubrobien_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vGTTBUS_RUBROBIEN");
                  GX_FocusControl = edtavGttbus_rubrobien_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  AV34gTTBUS_RubroBien = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34gTTBUS_RubroBien", StringUtil.LTrim( StringUtil.Str( (decimal)(AV34gTTBUS_RubroBien), 4, 0)));
               }
               else
               {
                  AV34gTTBUS_RubroBien = (short)(context.localUtil.CToN( cgiGet( edtavGttbus_rubrobien_Internalname), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34gTTBUS_RubroBien", StringUtil.LTrim( StringUtil.Str( (decimal)(AV34gTTBUS_RubroBien), 4, 0)));
               }
               AV35gTTBUS_RubroDesc = StringUtil.Upper( cgiGet( edtavGttbus_rubrodesc_Internalname)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35gTTBUS_RubroDesc", AV35gTTBUS_RubroDesc);
               if ( context.localUtil.VCDate( cgiGet( edtavGttbus_fechabaja_Internalname), 4) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"g TTBUS_ Fecha Baja"}), 1, "vGTTBUS_FECHABAJA");
                  GX_FocusControl = edtavGttbus_fechabaja_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  AV31gTTBUS_FechaBaja = DateTime.MinValue ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31gTTBUS_FechaBaja", context.localUtil.Format(AV31gTTBUS_FechaBaja, "99/99/9999"));
               }
               else
               {
                  AV31gTTBUS_FechaBaja = context.localUtil.CToD( cgiGet( edtavGttbus_fechabaja_Internalname), 4) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31gTTBUS_FechaBaja", context.localUtil.Format(AV31gTTBUS_FechaBaja, "99/99/9999"));
               }
               if ( ! context.localUtil.VCNumber( cgiGet( chkavGttbus_alquilado_Internalname), "9") || ( ((StringUtil.StrCmp(cgiGet( chkavGttbus_alquilado_Internalname), "1")==0) ? 1 : 0) < 0 ) || ( ( ((StringUtil.StrCmp(cgiGet( chkavGttbus_alquilado_Internalname), "1")==0) ? 1 : 0) > 9 ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vGTTBUS_ALQUILADO");
                  GX_FocusControl = chkavGttbus_alquilado_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  AV24gTTBUS_Alquilado = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24gTTBUS_Alquilado", StringUtil.Str( (decimal)(AV24gTTBUS_Alquilado), 1, 0));
               }
               else
               {
                  AV24gTTBUS_Alquilado = (short)(((StringUtil.StrCmp(cgiGet( chkavGttbus_alquilado_Internalname), "1")==0) ? 1 : 0)) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24gTTBUS_Alquilado", StringUtil.Str( (decimal)(AV24gTTBUS_Alquilado), 1, 0));
               }
               if ( ! context.localUtil.VCNumber( cgiGet( edtavGttbus_codproveedor_Internalname), "ZZZZZ9") || ( context.localUtil.CToN( cgiGet( edtavGttbus_codproveedor_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavGttbus_codproveedor_Internalname), ",", ".") > Convert.ToDecimal( 99999999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vGTTBUS_CODPROVEEDOR");
                  GX_FocusControl = edtavGttbus_codproveedor_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  AV26gTTBUS_CodProveedor = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26gTTBUS_CodProveedor", StringUtil.LTrim( StringUtil.Str( (decimal)(AV26gTTBUS_CodProveedor), 8, 0)));
               }
               else
               {
                  AV26gTTBUS_CodProveedor = (int)(context.localUtil.CToN( cgiGet( edtavGttbus_codproveedor_Internalname), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26gTTBUS_CodProveedor", StringUtil.LTrim( StringUtil.Str( (decimal)(AV26gTTBUS_CodProveedor), 8, 0)));
               }
               AV29gTTBUS_DesProveedor = cgiGet( edtavGttbus_desproveedor_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29gTTBUS_DesProveedor", AV29gTTBUS_DesProveedor);
               cmbavGttbus_estado.Name = cmbavGttbus_estado_Internalname ;
               cmbavGttbus_estado.CurrentValue = cgiGet( cmbavGttbus_estado_Internalname) ;
               AV30gTTBUS_Estado = (short)(NumberUtil.Val( cgiGet( cmbavGttbus_estado_Internalname), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30gTTBUS_Estado", StringUtil.Str( (decimal)(AV30gTTBUS_Estado), 1, 0));
               if ( ! context.localUtil.VCNumber( cgiGet( edtavGttbus_codposicion_Internalname), "ZZ9") || ( context.localUtil.CToN( cgiGet( edtavGttbus_codposicion_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavGttbus_codposicion_Internalname), ",", ".") > Convert.ToDecimal( 999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vGTTBUS_CODPOSICION");
                  GX_FocusControl = edtavGttbus_codposicion_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  AV25gTTBUS_CodPosicion = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25gTTBUS_CodPosicion", StringUtil.LTrim( StringUtil.Str( (decimal)(AV25gTTBUS_CodPosicion), 3, 0)));
               }
               else
               {
                  AV25gTTBUS_CodPosicion = (short)(context.localUtil.CToN( cgiGet( edtavGttbus_codposicion_Internalname), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25gTTBUS_CodPosicion", StringUtil.LTrim( StringUtil.Str( (decimal)(AV25gTTBUS_CodPosicion), 3, 0)));
               }
               AV28gTTBUS_DesPosicion = cgiGet( edtavGttbus_desposicion_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28gTTBUS_DesPosicion", AV28gTTBUS_DesPosicion);
               AV42SEC_CRE = cgiGet( edtavSec_cre_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV42SEC_CRE", AV42SEC_CRE);
               AV43SEC_DRE = cgiGet( edtavSec_dre_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV43SEC_DRE", AV43SEC_DRE);
               OldWc_bienes_a_recibir = cgiGet( "W0101") ;
               if ( String.IsNullOrEmpty(StringUtil.RTrim( WebComp_Wc_bienes_a_recibir_Component)) && ! String.IsNullOrEmpty(StringUtil.RTrim( OldWc_bienes_a_recibir)) )
               {
                  WebComp_Wc_bienes_a_recibir = getWebComponent(GetType(), "GeneXus.Programs", OldWc_bienes_a_recibir, new Object[] {context} );
                  WebComp_Wc_bienes_a_recibir.ComponentInit();
                  WebComp_Wc_bienes_a_recibir.Name = "OldWc_bienes_a_recibir";
                  WebComp_Wc_bienes_a_recibir_Component = OldWc_bienes_a_recibir ;
                  WebComp_Wc_bienes_a_recibir.componentrestorestate("W0101", "");
               }
               OldWc_bienes_enviados = cgiGet( "W0103") ;
               if ( String.IsNullOrEmpty(StringUtil.RTrim( WebComp_Wc_bienes_enviados_Component)) && ! String.IsNullOrEmpty(StringUtil.RTrim( OldWc_bienes_enviados)) )
               {
                  WebComp_Wc_bienes_enviados = getWebComponent(GetType(), "GeneXus.Programs", OldWc_bienes_enviados, new Object[] {context} );
                  WebComp_Wc_bienes_enviados.ComponentInit();
                  WebComp_Wc_bienes_enviados.Name = "OldWc_bienes_enviados";
                  WebComp_Wc_bienes_enviados_Component = OldWc_bienes_enviados ;
                  WebComp_Wc_bienes_enviados.componentrestorestate("W0103", "");
               }
               OldWc_tabs = cgiGet( "W0114") ;
               if ( String.IsNullOrEmpty(StringUtil.RTrim( WebComp_Wc_tabs_Component)) && ! String.IsNullOrEmpty(StringUtil.RTrim( OldWc_tabs)) )
               {
                  WebComp_Wc_tabs = getWebComponent(GetType(), "GeneXus.Programs", OldWc_tabs, new Object[] {context} );
                  WebComp_Wc_tabs.ComponentInit();
                  WebComp_Wc_tabs.Name = "OldWc_tabs";
                  WebComp_Wc_tabs_Component = OldWc_tabs ;
                  WebComp_Wc_tabs.componentrestorestate("W0114", "");
               }
               OldWc_bienes_a_recibir = cgiGet( "W0101") ;
               if ( String.IsNullOrEmpty(StringUtil.RTrim( WebComp_Wc_bienes_a_recibir_Component)) && ! String.IsNullOrEmpty(StringUtil.RTrim( OldWc_bienes_a_recibir)) )
               {
                  WebComp_Wc_bienes_a_recibir = getWebComponent(GetType(), "GeneXus.Programs", OldWc_bienes_a_recibir, new Object[] {context} );
                  WebComp_Wc_bienes_a_recibir.ComponentInit();
                  WebComp_Wc_bienes_a_recibir.Name = "OldWc_bienes_a_recibir";
                  WebComp_Wc_bienes_a_recibir_Component = OldWc_bienes_a_recibir ;
                  WebComp_Wc_bienes_a_recibir.componentrestorestate("W0101", "");
               }
               OldWc_bienes_enviados = cgiGet( "W0103") ;
               if ( String.IsNullOrEmpty(StringUtil.RTrim( WebComp_Wc_bienes_enviados_Component)) && ! String.IsNullOrEmpty(StringUtil.RTrim( OldWc_bienes_enviados)) )
               {
                  WebComp_Wc_bienes_enviados = getWebComponent(GetType(), "GeneXus.Programs", OldWc_bienes_enviados, new Object[] {context} );
                  WebComp_Wc_bienes_enviados.ComponentInit();
                  WebComp_Wc_bienes_enviados.Name = "OldWc_bienes_enviados";
                  WebComp_Wc_bienes_enviados_Component = OldWc_bienes_enviados ;
                  WebComp_Wc_bienes_enviados.componentrestorestate("W0103", "");
               }
               OldWc_tabs = cgiGet( "W0114") ;
               if ( String.IsNullOrEmpty(StringUtil.RTrim( WebComp_Wc_tabs_Component)) && ! String.IsNullOrEmpty(StringUtil.RTrim( OldWc_tabs)) )
               {
                  WebComp_Wc_tabs = getWebComponent(GetType(), "GeneXus.Programs", OldWc_tabs, new Object[] {context} );
                  WebComp_Wc_tabs.ComponentInit();
                  WebComp_Wc_tabs.Name = "OldWc_tabs";
                  WebComp_Wc_tabs_Component = OldWc_tabs ;
                  WebComp_Wc_tabs.componentrestorestate("W0114", "");
               }
            }
            /* Read hidden variables. */
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: E151M2 */
         E151M2 ();
         if (returnInSub) return;
      }

      protected void E151M2( )
      {
         /* Start Routine */
         new loadcontext(context ).execute( out  AV9Context) ;
         AV62USUARIO = AV9Context.gxTpr_User ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV62USUARIO", AV62USUARIO);
         edtavSec_dre_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSec_dre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavSec_dre_Enabled), 5, 0)));
         AV37inicio = (short)(NumberUtil.Val( AV44SESION.Get("Inicio"), ".")) ;
         if ( AV37inicio < 2 )
         {
            AV37inicio = (short)(AV37inicio+1) ;
            AV44SESION.Set("Inicio", StringUtil.Str( (decimal)(AV37inicio), 1, 0));
            context.DoAjaxRefresh();
         }
         /* Object Property */
         if ( StringUtil.StrCmp(WebComp_Wc_bienes_a_recibir_Component, "HTBUS004") != 0 )
         {
            WebComp_Wc_bienes_a_recibir = getWebComponent(GetType(), "GeneXus.Programs", "htbus004", new Object[] {context} );
            WebComp_Wc_bienes_a_recibir.ComponentInit();
            WebComp_Wc_bienes_a_recibir.Name = "HTBUS004";
            WebComp_Wc_bienes_a_recibir_Component = "HTBUS004" ;
         }
         if ( StringUtil.StrCmp(OldWc_bienes_a_recibir, WebComp_Wc_bienes_a_recibir_Component) != 0 )
         {
            WebComp_Wc_bienes_a_recibir.setjustcreated();
         }
         if ( StringUtil.Len( WebComp_Wc_bienes_a_recibir_Component) != 0 )
         {
            WebComp_Wc_bienes_a_recibir.componentprepare(new Object[] {(String)"W0101",(String)"",(String)AV62USUARIO,(String)AV45SISTEMA});
            WebComp_Wc_bienes_a_recibir.componentbind(new Object[] {(String)"",(String)""});
         }
         /* Object Property */
         if ( StringUtil.StrCmp(WebComp_Wc_bienes_enviados_Component, "HTBUS003_") != 0 )
         {
            WebComp_Wc_bienes_enviados = getWebComponent(GetType(), "GeneXus.Programs", "htbus003_", new Object[] {context} );
            WebComp_Wc_bienes_enviados.ComponentInit();
            WebComp_Wc_bienes_enviados.Name = "HTBUS003_";
            WebComp_Wc_bienes_enviados_Component = "HTBUS003_" ;
         }
         if ( StringUtil.StrCmp(OldWc_bienes_enviados, WebComp_Wc_bienes_enviados_Component) != 0 )
         {
            WebComp_Wc_bienes_enviados.setjustcreated();
         }
         if ( StringUtil.Len( WebComp_Wc_bienes_enviados_Component) != 0 )
         {
            WebComp_Wc_bienes_enviados.componentprepare(new Object[] {(String)"W0103",(String)"",(String)AV62USUARIO,(String)AV45SISTEMA});
            WebComp_Wc_bienes_enviados.componentbind(new Object[] {(String)"",(String)""});
         }
         /* Execute user subroutine: S112 */
         S112 ();
         if (returnInSub) return;
         new ptbus025(context ).execute(  AV62USUARIO, out  AV61usu_permiso) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV62USUARIO", AV62USUARIO);
         if ( AV61usu_permiso == 1 )
         {
            imgImg_alta_Visible = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgImg_alta_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgImg_alta_Visible), 5, 0)));
            edtavBaja_Visible = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBaja_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBaja_Visible), 5, 0)));
            edtavEdicion_Visible = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavEdicion_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavEdicion_Visible), 5, 0)));
            tblTbl_movimientos_Visible = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, tblTbl_movimientos_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(tblTbl_movimientos_Visible), 5, 0)));
         }
         else
         {
            imgImg_alta_Visible = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgImg_alta_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgImg_alta_Visible), 5, 0)));
            edtavBaja_Visible = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBaja_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBaja_Visible), 5, 0)));
            edtavEdicion_Visible = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavEdicion_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavEdicion_Visible), 5, 0)));
            tblTbl_movimientos_Visible = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, tblTbl_movimientos_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(tblTbl_movimientos_Visible), 5, 0)));
         }
         lblTbxpantallacomp1_Link = formatLink("htbus004c.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV62USUARIO)) + "," + UrlEncode(StringUtil.RTrim(AV45SISTEMA)) ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblTbxpantallacomp1_Internalname, "Link", lblTbxpantallacomp1_Link);
         lblTbxpantallacomp1_Linktarget = "_blanck" ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblTbxpantallacomp1_Internalname, "Linktarget", lblTbxpantallacomp1_Linktarget);
         lblTbxpantallacomp2_Link = formatLink("htbus003c.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV62USUARIO)) + "," + UrlEncode(StringUtil.RTrim(AV45SISTEMA)) ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblTbxpantallacomp2_Internalname, "Link", lblTbxpantallacomp2_Link);
         lblTbxpantallacomp2_Linktarget = "_blanck" ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblTbxpantallacomp2_Internalname, "Linktarget", lblTbxpantallacomp2_Linktarget);
      }

      protected void E121M2( )
      {
         /* 'Alta' Routine */
         context.wjLoc = formatLink("ttbus000.aspx") + "?" + UrlEncode("" +0) + "," + UrlEncode(StringUtil.RTrim("INS")) + "," + UrlEncode("" +0) + "," + UrlEncode(StringUtil.RTrim("")) + "," + UrlEncode("" +0) + "," + UrlEncode("" +0) + "," + UrlEncode(StringUtil.RTrim(AV45SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV62USUARIO)) ;
      }

      protected void E161M2( )
      {
         /* 'Baja' Routine */
         AV50TTBUS_CodPosicion = AV25gTTBUS_CodPosicion ;
         new ptbus025_(context ).execute(  AV62USUARIO,  AV50TTBUS_CodPosicion, out  AV7band_1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV62USUARIO", AV62USUARIO);
         if ( AV7band_1 == 1 )
         {
            /* Window Datatype Object Property */
            AV65window.Url = formatLink("ttbus000_b.aspx") + "?" + UrlEncode("" +AV33gTTBUS_ID) + "," + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode(StringUtil.RTrim(AV45SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV62USUARIO)) ;
            AV65window.SetReturnParms(new Object[] {"AV33gTTBUS_ID","","AV45SISTEMA","AV62USUARIO"});
            AV65window.Width = 450 ;
            AV65window.Height = 200 ;
            context.NewWindow(AV65window);
            context.DoAjaxRefresh();
         }
         else
         {
            if ( AV50TTBUS_CodPosicion != 999 )
            {
               GX_msglist.addItem("NO TIENE PERMISOS PARA DAR DE BAJA BIENES DE ESTA POSICIÓN.");
            }
            else
            {
               GX_msglist.addItem("NO SE PUEDE DAR DE BAJA UN BIEN QUE ESTÁ CAMBIANDO DE POSICIÓN.");
            }
         }
      }

      protected void E171M2( )
      {
         /* 'Modificacion' Routine */
         AV50TTBUS_CodPosicion = AV25gTTBUS_CodPosicion ;
         if ( AV50TTBUS_CodPosicion != 999 )
         {
            new ptbus025_(context ).execute(  AV62USUARIO,  AV50TTBUS_CodPosicion, out  AV7band_1) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV62USUARIO", AV62USUARIO);
            if ( AV7band_1 == 1 )
            {
               AV44SESION.Set("Estado", StringUtil.Str( (decimal)(AV30gTTBUS_Estado), 1, 0));
               AV44SESION.Set("TTBUS_EMP", AV17gBUS_EMP);
               AV44SESION.Set("TTBUS_RUB", StringUtil.Str( (decimal)(AV19gBUS_RUB), 4, 0));
               AV44SESION.Set("TTBUS_COD", StringUtil.Str( (decimal)(AV16gBUS_COD), 4, 0));
               AV44SESION.Set("TTBUS_PAR", StringUtil.Str( (decimal)(AV18gBUS_PAR), 2, 0));
               AV44SESION.Set("TTHARDWARE_ID", StringUtil.Str( (decimal)(AV20gHARDWARE_ID), 4, 0));
               context.wjLoc = formatLink("ttbus000.aspx") + "?" + UrlEncode("" +AV33gTTBUS_ID) + "," + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode("" +AV25gTTBUS_CodPosicion) + "," + UrlEncode(StringUtil.RTrim(AV42SEC_CRE)) + "," + UrlEncode("" +AV30gTTBUS_Estado) + "," + UrlEncode("" +0) + "," + UrlEncode(StringUtil.RTrim(AV45SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV62USUARIO)) ;
            }
            else
            {
               GX_msglist.addItem("NO TIENE PERMISOS PARA MODIFICAR BIENES DE ESTA POSICIÓN.");
            }
         }
         else
         {
            AV44SESION.Set("Estado", StringUtil.Str( (decimal)(AV30gTTBUS_Estado), 1, 0));
            AV44SESION.Set("TTBUS_EMP", AV17gBUS_EMP);
            AV44SESION.Set("TTBUS_RUB", StringUtil.Str( (decimal)(AV19gBUS_RUB), 4, 0));
            AV44SESION.Set("TTBUS_COD", StringUtil.Str( (decimal)(AV16gBUS_COD), 4, 0));
            AV44SESION.Set("TTBUS_PAR", StringUtil.Str( (decimal)(AV18gBUS_PAR), 2, 0));
            AV44SESION.Set("TTHARDWARE_ID", StringUtil.Str( (decimal)(AV20gHARDWARE_ID), 4, 0));
            context.wjLoc = formatLink("ttbus000.aspx") + "?" + UrlEncode("" +AV33gTTBUS_ID) + "," + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode("" +AV25gTTBUS_CodPosicion) + "," + UrlEncode(StringUtil.RTrim(AV42SEC_CRE)) + "," + UrlEncode("" +AV30gTTBUS_Estado) + "," + UrlEncode("" +0) + "," + UrlEncode(StringUtil.RTrim(AV45SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV62USUARIO)) ;
         }
      }

      protected void E181M2( )
      {
         /* 'Visualizacion' Routine */
         context.wjLoc = formatLink("ttbus000.aspx") + "?" + UrlEncode("" +AV33gTTBUS_ID) + "," + UrlEncode(StringUtil.RTrim("DSP")) + "," + UrlEncode("" +AV25gTTBUS_CodPosicion) + "," + UrlEncode(StringUtil.RTrim(AV42SEC_CRE)) + "," + UrlEncode("" +AV30gTTBUS_Estado) + "," + UrlEncode("" +0) + "," + UrlEncode(StringUtil.RTrim(AV45SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV62USUARIO)) ;
      }

      private void E191M2( )
      {
         /* Grid1_Load Routine */
         AV5baja = context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", "Modern") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBaja_Internalname, "Bitmap", context.convertURL( AV5baja));
         AV11edicion = context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", "Modern") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavEdicion_Internalname, "Bitmap", context.convertURL( AV11edicion));
         AV63visualizacion = context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", "Modern") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVisualizacion_Internalname, "Bitmap", context.convertURL( AV63visualizacion));
         AV13fNumeroIdentificador = StringUtil.Trim( AV13fNumeroIdentificador) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13fNumeroIdentificador", AV13fNumeroIdentificador);
         AV40NumeroIdentificador = "%" + StringUtil.Upper( StringUtil.Trim( AV13fNumeroIdentificador)) + "%" ;
         pr_default.dynParam(4, new Object[]{ new Object[]{
                                              AV60TTBUS7_Pos ,
                                              AV14fTTBUS_Descripcion ,
                                              AV54TTBUS_FechaCarga ,
                                              AV56TTBUS_RubroBien ,
                                              AV15fTTBUS_Estado ,
                                              AV13fNumeroIdentificador ,
                                              A37TTBUS_CodPosicion ,
                                              A12TTBUS_Descripcion ,
                                              AV52TTBUS_Descripcion ,
                                              A13TTBUS_FechaCarga ,
                                              A17TTBUS_RubroBien ,
                                              A23TTBUS_Estado ,
                                              A15NumeroIdentificador ,
                                              AV40NumeroIdentificador ,
                                              A11TTBUS_Id ,
                                              AV55TTBUS_Id ,
                                              A16TTBUS_FechaBaja ,
                                              A14IdIdentificador ,
                                              AV12fIdIdentificador },
                                              new int[] {
                                              TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.DATE, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DATE,
                                              TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.INT, TypeConstants.INT, TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.INT, TypeConstants.INT
                                              }
         });
         lV52TTBUS_Descripcion = StringUtil.PadR( StringUtil.RTrim( AV52TTBUS_Descripcion), 50, "%") ;
         lV40NumeroIdentificador = StringUtil.PadR( StringUtil.RTrim( AV40NumeroIdentificador), 80, "%") ;
         /* Using cursor H001M6 */
         pr_default.execute(4, new Object[] {AV55TTBUS_Id, AV12fIdIdentificador, AV60TTBUS7_Pos, lV52TTBUS_Descripcion, AV54TTBUS_FechaCarga, AV56TTBUS_RubroBien, AV15fTTBUS_Estado, lV40NumeroIdentificador});
         while ( (pr_default.getStatus(4) != 101) )
         {
            A11TTBUS_Id = H001M6_A11TTBUS_Id[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
            A37TTBUS_CodPosicion = H001M6_A37TTBUS_CodPosicion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37TTBUS_CodPosicion", StringUtil.LTrim( StringUtil.Str( (decimal)(A37TTBUS_CodPosicion), 3, 0)));
            A35TTBUS7_CodResp = H001M6_A35TTBUS7_CodResp[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35TTBUS7_CodResp", A35TTBUS7_CodResp);
            n35TTBUS7_CodResp = H001M6_n35TTBUS7_CodResp[0] ;
            A36TTBUS7_DesResp = H001M6_A36TTBUS7_DesResp[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36TTBUS7_DesResp", A36TTBUS7_DesResp);
            n36TTBUS7_DesResp = H001M6_n36TTBUS7_DesResp[0] ;
            A15NumeroIdentificador = H001M6_A15NumeroIdentificador[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15NumeroIdentificador", A15NumeroIdentificador);
            A14IdIdentificador = H001M6_A14IdIdentificador[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14IdIdentificador", StringUtil.LTrim( StringUtil.Str( (decimal)(A14IdIdentificador), 8, 0)));
            A23TTBUS_Estado = H001M6_A23TTBUS_Estado[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23TTBUS_Estado", StringUtil.Str( (decimal)(A23TTBUS_Estado), 1, 0));
            A17TTBUS_RubroBien = H001M6_A17TTBUS_RubroBien[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17TTBUS_RubroBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A17TTBUS_RubroBien), 4, 0)));
            A13TTBUS_FechaCarga = H001M6_A13TTBUS_FechaCarga[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13TTBUS_FechaCarga", context.localUtil.Format(A13TTBUS_FechaCarga, "99/99/9999"));
            A12TTBUS_Descripcion = H001M6_A12TTBUS_Descripcion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12TTBUS_Descripcion", A12TTBUS_Descripcion);
            A16TTBUS_FechaBaja = H001M6_A16TTBUS_FechaBaja[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16TTBUS_FechaBaja", context.localUtil.Format(A16TTBUS_FechaBaja, "99/99/9999"));
            n16TTBUS_FechaBaja = H001M6_n16TTBUS_FechaBaja[0] ;
            A29TTBUS_Alquilado = H001M6_A29TTBUS_Alquilado[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29TTBUS_Alquilado", StringUtil.Str( (decimal)(A29TTBUS_Alquilado), 1, 0));
            A27TTBUS_CodProveedor = H001M6_A27TTBUS_CodProveedor[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27TTBUS_CodProveedor", StringUtil.LTrim( StringUtil.Str( (decimal)(A27TTBUS_CodProveedor), 8, 0)));
            n27TTBUS_CodProveedor = H001M6_n27TTBUS_CodProveedor[0] ;
            A38TTBUS_DesPosicion = H001M6_A38TTBUS_DesPosicion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A38TTBUS_DesPosicion", A38TTBUS_DesPosicion);
            A30TTBUS_DesProveedor = H001M6_A30TTBUS_DesProveedor[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30TTBUS_DesProveedor", A30TTBUS_DesProveedor);
            n30TTBUS_DesProveedor = H001M6_n30TTBUS_DesProveedor[0] ;
            A18TTBUS_RubroDesc = H001M6_A18TTBUS_RubroDesc[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18TTBUS_RubroDesc", A18TTBUS_RubroDesc);
            n18TTBUS_RubroDesc = H001M6_n18TTBUS_RubroDesc[0] ;
            A37TTBUS_CodPosicion = H001M6_A37TTBUS_CodPosicion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37TTBUS_CodPosicion", StringUtil.LTrim( StringUtil.Str( (decimal)(A37TTBUS_CodPosicion), 3, 0)));
            A23TTBUS_Estado = H001M6_A23TTBUS_Estado[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23TTBUS_Estado", StringUtil.Str( (decimal)(A23TTBUS_Estado), 1, 0));
            A17TTBUS_RubroBien = H001M6_A17TTBUS_RubroBien[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17TTBUS_RubroBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A17TTBUS_RubroBien), 4, 0)));
            A13TTBUS_FechaCarga = H001M6_A13TTBUS_FechaCarga[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13TTBUS_FechaCarga", context.localUtil.Format(A13TTBUS_FechaCarga, "99/99/9999"));
            A12TTBUS_Descripcion = H001M6_A12TTBUS_Descripcion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12TTBUS_Descripcion", A12TTBUS_Descripcion);
            A16TTBUS_FechaBaja = H001M6_A16TTBUS_FechaBaja[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16TTBUS_FechaBaja", context.localUtil.Format(A16TTBUS_FechaBaja, "99/99/9999"));
            n16TTBUS_FechaBaja = H001M6_n16TTBUS_FechaBaja[0] ;
            A29TTBUS_Alquilado = H001M6_A29TTBUS_Alquilado[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29TTBUS_Alquilado", StringUtil.Str( (decimal)(A29TTBUS_Alquilado), 1, 0));
            A27TTBUS_CodProveedor = H001M6_A27TTBUS_CodProveedor[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27TTBUS_CodProveedor", StringUtil.LTrim( StringUtil.Str( (decimal)(A27TTBUS_CodProveedor), 8, 0)));
            n27TTBUS_CodProveedor = H001M6_n27TTBUS_CodProveedor[0] ;
            A38TTBUS_DesPosicion = H001M6_A38TTBUS_DesPosicion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A38TTBUS_DesPosicion", A38TTBUS_DesPosicion);
            A35TTBUS7_CodResp = H001M6_A35TTBUS7_CodResp[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35TTBUS7_CodResp", A35TTBUS7_CodResp);
            n35TTBUS7_CodResp = H001M6_n35TTBUS7_CodResp[0] ;
            A36TTBUS7_DesResp = H001M6_A36TTBUS7_DesResp[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36TTBUS7_DesResp", A36TTBUS7_DesResp);
            n36TTBUS7_DesResp = H001M6_n36TTBUS7_DesResp[0] ;
            A18TTBUS_RubroDesc = H001M6_A18TTBUS_RubroDesc[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18TTBUS_RubroDesc", A18TTBUS_RubroDesc);
            n18TTBUS_RubroDesc = H001M6_n18TTBUS_RubroDesc[0] ;
            A30TTBUS_DesProveedor = H001M6_A30TTBUS_DesProveedor[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30TTBUS_DesProveedor", A30TTBUS_DesProveedor);
            n30TTBUS_DesProveedor = H001M6_n30TTBUS_DesProveedor[0] ;
            AV24gTTBUS_Alquilado = A29TTBUS_Alquilado ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24gTTBUS_Alquilado", StringUtil.Str( (decimal)(AV24gTTBUS_Alquilado), 1, 0));
            AV25gTTBUS_CodPosicion = A37TTBUS_CodPosicion ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25gTTBUS_CodPosicion", StringUtil.LTrim( StringUtil.Str( (decimal)(AV25gTTBUS_CodPosicion), 3, 0)));
            AV26gTTBUS_CodProveedor = A27TTBUS_CodProveedor ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26gTTBUS_CodProveedor", StringUtil.LTrim( StringUtil.Str( (decimal)(AV26gTTBUS_CodProveedor), 8, 0)));
            AV27gTTBUS_Descripcion = A12TTBUS_Descripcion ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27gTTBUS_Descripcion", AV27gTTBUS_Descripcion);
            AV28gTTBUS_DesPosicion = A38TTBUS_DesPosicion ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28gTTBUS_DesPosicion", AV28gTTBUS_DesPosicion);
            AV29gTTBUS_DesProveedor = A30TTBUS_DesProveedor ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29gTTBUS_DesProveedor", AV29gTTBUS_DesProveedor);
            AV30gTTBUS_Estado = A23TTBUS_Estado ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30gTTBUS_Estado", StringUtil.Str( (decimal)(AV30gTTBUS_Estado), 1, 0));
            AV31gTTBUS_FechaBaja = A16TTBUS_FechaBaja ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31gTTBUS_FechaBaja", context.localUtil.Format(AV31gTTBUS_FechaBaja, "99/99/9999"));
            AV32gTTBUS_FechaCarga = A13TTBUS_FechaCarga ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32gTTBUS_FechaCarga", context.localUtil.Format(AV32gTTBUS_FechaCarga, "99/99/9999"));
            AV33gTTBUS_ID = A11TTBUS_Id ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33gTTBUS_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV33gTTBUS_ID), 8, 0)));
            AV34gTTBUS_RubroBien = A17TTBUS_RubroBien ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34gTTBUS_RubroBien", StringUtil.LTrim( StringUtil.Str( (decimal)(AV34gTTBUS_RubroBien), 4, 0)));
            AV35gTTBUS_RubroDesc = A18TTBUS_RubroDesc ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35gTTBUS_RubroDesc", AV35gTTBUS_RubroDesc);
            AV23gNumeroIdentificador = A15NumeroIdentificador ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23gNumeroIdentificador", AV23gNumeroIdentificador);
            AV22gIdIdentificador = A14IdIdentificador ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22gIdIdentificador", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22gIdIdentificador), 8, 0)));
            if ( A23TTBUS_Estado == 1 )
            {
               /* Using cursor H001M7 */
               pr_default.execute(5, new Object[] {A37TTBUS_CodPosicion});
               while ( (pr_default.getStatus(5) != 101) )
               {
                  A33TTBUS7_Pos = H001M7_A33TTBUS7_Pos[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
                  AV42SEC_CRE = A35TTBUS7_CodResp ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV42SEC_CRE", AV42SEC_CRE);
                  AV43SEC_DRE = A36TTBUS7_DesResp ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV43SEC_DRE", AV43SEC_DRE);
                  /* Exiting from a For First loop. */
                  if (true) break;
               }
               pr_default.close(5);
            }
            else
            {
               /* Using cursor H001M8 */
               pr_default.execute(6, new Object[] {A11TTBUS_Id});
               while ( (pr_default.getStatus(6) != 101) )
               {
                  A22TTBUS2_IdBien = H001M8_A22TTBUS2_IdBien[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22TTBUS2_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A22TTBUS2_IdBien), 8, 0)));
                  A26TTBUS2_EstadoEnvio = H001M8_A26TTBUS2_EstadoEnvio[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A26TTBUS2_EstadoEnvio", StringUtil.Str( (decimal)(A26TTBUS2_EstadoEnvio), 1, 0));
                  A24TTBUS2_RespDesde = H001M8_A24TTBUS2_RespDesde[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24TTBUS2_RespDesde", A24TTBUS2_RespDesde);
                  A25TTBUS2_RespHacia = H001M8_A25TTBUS2_RespHacia[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25TTBUS2_RespHacia", A25TTBUS2_RespHacia);
                  AV57TTBUS2_RespDesde = A24TTBUS2_RespDesde ;
                  AV58TTBUS2_RespHacia = A25TTBUS2_RespHacia ;
                  /* Execute user subroutine: S125 */
                  S125 ();
                  if ( returnInSub )
                  {
                     pr_default.close(6);
                     returnInSub = true;
                     if (true) return;
                  }
                  pr_default.readNext(6);
               }
               pr_default.close(6);
               AV43SEC_DRE = StringUtil.Trim( AV10dUSU_DES) + " Y " + StringUtil.Trim( AV36hUSU_DES) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV43SEC_DRE", AV43SEC_DRE);
            }
            /* Load Method */
            if ( wbStart != -1 )
            {
               wbStart = 61 ;
            }
            if ( ( subGrid1_Islastpage == 1 ) || ( 10 == 0 ) || ( ( GRID1_nCurrentRecord >= GRID1_nFirstRecordOnPage ) && ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) )
            {
               sendrow_612( ) ;
               GRID1_nEOF = 1 ;
               if ( ( subGrid1_Islastpage == 1 ) && ( ((int)(GRID1_nCurrentRecord) % (subGrid1_Recordsperpage( ))) == 0 ) )
               {
                  GRID1_nFirstRecordOnPage = GRID1_nCurrentRecord ;
               }
            }
            if ( GRID1_nCurrentRecord >= GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) )
            {
               GRID1_nEOF = 0 ;
            }
            GRID1_nCurrentRecord = (int)(GRID1_nCurrentRecord+1) ;
            pr_default.readNext(4);
         }
         pr_default.close(4);
         pr_default.dynParam(7, new Object[]{ new Object[]{
                                              AV14fTTBUS_Descripcion ,
                                              AV54TTBUS_FechaCarga ,
                                              AV56TTBUS_RubroBien ,
                                              AV15fTTBUS_Estado ,
                                              AV13fNumeroIdentificador ,
                                              A12TTBUS_Descripcion ,
                                              AV52TTBUS_Descripcion ,
                                              A13TTBUS_FechaCarga ,
                                              A17TTBUS_RubroBien ,
                                              A23TTBUS_Estado ,
                                              A15NumeroIdentificador ,
                                              AV40NumeroIdentificador ,
                                              A11TTBUS_Id ,
                                              AV55TTBUS_Id ,
                                              A16TTBUS_FechaBaja ,
                                              A37TTBUS_CodPosicion ,
                                              A14IdIdentificador ,
                                              AV12fIdIdentificador },
                                              new int[] {
                                              TypeConstants.STRING, TypeConstants.DATE, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DATE, TypeConstants.SHORT, TypeConstants.SHORT,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.INT, TypeConstants.INT, TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.INT, TypeConstants.INT
                                              }
         });
         lV52TTBUS_Descripcion = StringUtil.PadR( StringUtil.RTrim( AV52TTBUS_Descripcion), 50, "%") ;
         /* Using cursor H001M9 */
         pr_default.execute(7, new Object[] {AV55TTBUS_Id, AV12fIdIdentificador, lV52TTBUS_Descripcion, AV54TTBUS_FechaCarga, AV56TTBUS_RubroBien, AV15fTTBUS_Estado, AV40NumeroIdentificador});
         while ( (pr_default.getStatus(7) != 101) )
         {
            A11TTBUS_Id = H001M9_A11TTBUS_Id[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
            A37TTBUS_CodPosicion = H001M9_A37TTBUS_CodPosicion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37TTBUS_CodPosicion", StringUtil.LTrim( StringUtil.Str( (decimal)(A37TTBUS_CodPosicion), 3, 0)));
            A35TTBUS7_CodResp = H001M9_A35TTBUS7_CodResp[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35TTBUS7_CodResp", A35TTBUS7_CodResp);
            n35TTBUS7_CodResp = H001M9_n35TTBUS7_CodResp[0] ;
            A36TTBUS7_DesResp = H001M9_A36TTBUS7_DesResp[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36TTBUS7_DesResp", A36TTBUS7_DesResp);
            n36TTBUS7_DesResp = H001M9_n36TTBUS7_DesResp[0] ;
            A15NumeroIdentificador = H001M9_A15NumeroIdentificador[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A15NumeroIdentificador", A15NumeroIdentificador);
            A14IdIdentificador = H001M9_A14IdIdentificador[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A14IdIdentificador", StringUtil.LTrim( StringUtil.Str( (decimal)(A14IdIdentificador), 8, 0)));
            A23TTBUS_Estado = H001M9_A23TTBUS_Estado[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23TTBUS_Estado", StringUtil.Str( (decimal)(A23TTBUS_Estado), 1, 0));
            A17TTBUS_RubroBien = H001M9_A17TTBUS_RubroBien[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17TTBUS_RubroBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A17TTBUS_RubroBien), 4, 0)));
            A13TTBUS_FechaCarga = H001M9_A13TTBUS_FechaCarga[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13TTBUS_FechaCarga", context.localUtil.Format(A13TTBUS_FechaCarga, "99/99/9999"));
            A12TTBUS_Descripcion = H001M9_A12TTBUS_Descripcion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12TTBUS_Descripcion", A12TTBUS_Descripcion);
            A16TTBUS_FechaBaja = H001M9_A16TTBUS_FechaBaja[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16TTBUS_FechaBaja", context.localUtil.Format(A16TTBUS_FechaBaja, "99/99/9999"));
            n16TTBUS_FechaBaja = H001M9_n16TTBUS_FechaBaja[0] ;
            A29TTBUS_Alquilado = H001M9_A29TTBUS_Alquilado[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29TTBUS_Alquilado", StringUtil.Str( (decimal)(A29TTBUS_Alquilado), 1, 0));
            A27TTBUS_CodProveedor = H001M9_A27TTBUS_CodProveedor[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27TTBUS_CodProveedor", StringUtil.LTrim( StringUtil.Str( (decimal)(A27TTBUS_CodProveedor), 8, 0)));
            n27TTBUS_CodProveedor = H001M9_n27TTBUS_CodProveedor[0] ;
            A38TTBUS_DesPosicion = H001M9_A38TTBUS_DesPosicion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A38TTBUS_DesPosicion", A38TTBUS_DesPosicion);
            A30TTBUS_DesProveedor = H001M9_A30TTBUS_DesProveedor[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30TTBUS_DesProveedor", A30TTBUS_DesProveedor);
            n30TTBUS_DesProveedor = H001M9_n30TTBUS_DesProveedor[0] ;
            A18TTBUS_RubroDesc = H001M9_A18TTBUS_RubroDesc[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18TTBUS_RubroDesc", A18TTBUS_RubroDesc);
            n18TTBUS_RubroDesc = H001M9_n18TTBUS_RubroDesc[0] ;
            A37TTBUS_CodPosicion = H001M9_A37TTBUS_CodPosicion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37TTBUS_CodPosicion", StringUtil.LTrim( StringUtil.Str( (decimal)(A37TTBUS_CodPosicion), 3, 0)));
            A23TTBUS_Estado = H001M9_A23TTBUS_Estado[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23TTBUS_Estado", StringUtil.Str( (decimal)(A23TTBUS_Estado), 1, 0));
            A17TTBUS_RubroBien = H001M9_A17TTBUS_RubroBien[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A17TTBUS_RubroBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A17TTBUS_RubroBien), 4, 0)));
            A13TTBUS_FechaCarga = H001M9_A13TTBUS_FechaCarga[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A13TTBUS_FechaCarga", context.localUtil.Format(A13TTBUS_FechaCarga, "99/99/9999"));
            A12TTBUS_Descripcion = H001M9_A12TTBUS_Descripcion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12TTBUS_Descripcion", A12TTBUS_Descripcion);
            A16TTBUS_FechaBaja = H001M9_A16TTBUS_FechaBaja[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A16TTBUS_FechaBaja", context.localUtil.Format(A16TTBUS_FechaBaja, "99/99/9999"));
            n16TTBUS_FechaBaja = H001M9_n16TTBUS_FechaBaja[0] ;
            A29TTBUS_Alquilado = H001M9_A29TTBUS_Alquilado[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29TTBUS_Alquilado", StringUtil.Str( (decimal)(A29TTBUS_Alquilado), 1, 0));
            A27TTBUS_CodProveedor = H001M9_A27TTBUS_CodProveedor[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27TTBUS_CodProveedor", StringUtil.LTrim( StringUtil.Str( (decimal)(A27TTBUS_CodProveedor), 8, 0)));
            n27TTBUS_CodProveedor = H001M9_n27TTBUS_CodProveedor[0] ;
            A38TTBUS_DesPosicion = H001M9_A38TTBUS_DesPosicion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A38TTBUS_DesPosicion", A38TTBUS_DesPosicion);
            A35TTBUS7_CodResp = H001M9_A35TTBUS7_CodResp[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35TTBUS7_CodResp", A35TTBUS7_CodResp);
            n35TTBUS7_CodResp = H001M9_n35TTBUS7_CodResp[0] ;
            A36TTBUS7_DesResp = H001M9_A36TTBUS7_DesResp[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36TTBUS7_DesResp", A36TTBUS7_DesResp);
            n36TTBUS7_DesResp = H001M9_n36TTBUS7_DesResp[0] ;
            A18TTBUS_RubroDesc = H001M9_A18TTBUS_RubroDesc[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18TTBUS_RubroDesc", A18TTBUS_RubroDesc);
            n18TTBUS_RubroDesc = H001M9_n18TTBUS_RubroDesc[0] ;
            A30TTBUS_DesProveedor = H001M9_A30TTBUS_DesProveedor[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30TTBUS_DesProveedor", A30TTBUS_DesProveedor);
            n30TTBUS_DesProveedor = H001M9_n30TTBUS_DesProveedor[0] ;
            AV24gTTBUS_Alquilado = A29TTBUS_Alquilado ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24gTTBUS_Alquilado", StringUtil.Str( (decimal)(AV24gTTBUS_Alquilado), 1, 0));
            AV25gTTBUS_CodPosicion = A37TTBUS_CodPosicion ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25gTTBUS_CodPosicion", StringUtil.LTrim( StringUtil.Str( (decimal)(AV25gTTBUS_CodPosicion), 3, 0)));
            AV26gTTBUS_CodProveedor = A27TTBUS_CodProveedor ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26gTTBUS_CodProveedor", StringUtil.LTrim( StringUtil.Str( (decimal)(AV26gTTBUS_CodProveedor), 8, 0)));
            AV27gTTBUS_Descripcion = A12TTBUS_Descripcion ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27gTTBUS_Descripcion", AV27gTTBUS_Descripcion);
            AV28gTTBUS_DesPosicion = A38TTBUS_DesPosicion ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28gTTBUS_DesPosicion", AV28gTTBUS_DesPosicion);
            AV29gTTBUS_DesProveedor = A30TTBUS_DesProveedor ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29gTTBUS_DesProveedor", AV29gTTBUS_DesProveedor);
            AV30gTTBUS_Estado = A23TTBUS_Estado ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30gTTBUS_Estado", StringUtil.Str( (decimal)(AV30gTTBUS_Estado), 1, 0));
            AV31gTTBUS_FechaBaja = A16TTBUS_FechaBaja ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31gTTBUS_FechaBaja", context.localUtil.Format(AV31gTTBUS_FechaBaja, "99/99/9999"));
            AV32gTTBUS_FechaCarga = A13TTBUS_FechaCarga ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32gTTBUS_FechaCarga", context.localUtil.Format(AV32gTTBUS_FechaCarga, "99/99/9999"));
            AV33gTTBUS_ID = A11TTBUS_Id ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33gTTBUS_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV33gTTBUS_ID), 8, 0)));
            AV34gTTBUS_RubroBien = A17TTBUS_RubroBien ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34gTTBUS_RubroBien", StringUtil.LTrim( StringUtil.Str( (decimal)(AV34gTTBUS_RubroBien), 4, 0)));
            AV35gTTBUS_RubroDesc = A18TTBUS_RubroDesc ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35gTTBUS_RubroDesc", AV35gTTBUS_RubroDesc);
            AV23gNumeroIdentificador = A15NumeroIdentificador ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23gNumeroIdentificador", AV23gNumeroIdentificador);
            AV22gIdIdentificador = A14IdIdentificador ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22gIdIdentificador", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22gIdIdentificador), 8, 0)));
            if ( A23TTBUS_Estado == 1 )
            {
               /* Using cursor H001M10 */
               pr_default.execute(8, new Object[] {A37TTBUS_CodPosicion});
               while ( (pr_default.getStatus(8) != 101) )
               {
                  A33TTBUS7_Pos = H001M10_A33TTBUS7_Pos[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
                  AV42SEC_CRE = A35TTBUS7_CodResp ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV42SEC_CRE", AV42SEC_CRE);
                  AV43SEC_DRE = A36TTBUS7_DesResp ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV43SEC_DRE", AV43SEC_DRE);
                  /* Exiting from a For First loop. */
                  if (true) break;
               }
               pr_default.close(8);
            }
            else
            {
               /* Using cursor H001M11 */
               pr_default.execute(9, new Object[] {A11TTBUS_Id});
               while ( (pr_default.getStatus(9) != 101) )
               {
                  A22TTBUS2_IdBien = H001M11_A22TTBUS2_IdBien[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22TTBUS2_IdBien", StringUtil.LTrim( StringUtil.Str( (decimal)(A22TTBUS2_IdBien), 8, 0)));
                  A26TTBUS2_EstadoEnvio = H001M11_A26TTBUS2_EstadoEnvio[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A26TTBUS2_EstadoEnvio", StringUtil.Str( (decimal)(A26TTBUS2_EstadoEnvio), 1, 0));
                  A24TTBUS2_RespDesde = H001M11_A24TTBUS2_RespDesde[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24TTBUS2_RespDesde", A24TTBUS2_RespDesde);
                  A25TTBUS2_RespHacia = H001M11_A25TTBUS2_RespHacia[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25TTBUS2_RespHacia", A25TTBUS2_RespHacia);
                  AV57TTBUS2_RespDesde = A24TTBUS2_RespDesde ;
                  AV58TTBUS2_RespHacia = A25TTBUS2_RespHacia ;
                  /* Execute user subroutine: S125 */
                  S125 ();
                  if ( returnInSub )
                  {
                     pr_default.close(9);
                     returnInSub = true;
                     if (true) return;
                  }
                  pr_default.readNext(9);
               }
               pr_default.close(9);
               AV43SEC_DRE = StringUtil.Trim( AV10dUSU_DES) + " Y " + StringUtil.Trim( AV36hUSU_DES) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV43SEC_DRE", AV43SEC_DRE);
            }
            new ptbus001(context ).execute(  A11TTBUS_Id,  AV62USUARIO, out  AV8band_2) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV62USUARIO", AV62USUARIO);
            if ( AV8band_2 == 1 )
            {
               /* Load Method */
               if ( wbStart != -1 )
               {
                  wbStart = 61 ;
               }
               if ( ( subGrid1_Islastpage == 1 ) || ( 10 == 0 ) || ( ( GRID1_nCurrentRecord >= GRID1_nFirstRecordOnPage ) && ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) )
               {
                  sendrow_612( ) ;
                  GRID1_nEOF = 1 ;
                  if ( ( subGrid1_Islastpage == 1 ) && ( ((int)(GRID1_nCurrentRecord) % (subGrid1_Recordsperpage( ))) == 0 ) )
                  {
                     GRID1_nFirstRecordOnPage = GRID1_nCurrentRecord ;
                  }
               }
               if ( GRID1_nCurrentRecord >= GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) )
               {
                  GRID1_nEOF = 0 ;
               }
               GRID1_nCurrentRecord = (int)(GRID1_nCurrentRecord+1) ;
            }
            pr_default.readNext(7);
         }
         pr_default.close(7);
      }

      protected void E131M2( )
      {
         /* 'Movimientos' Routine */
         AV44SESION.Set("CONT_MOV", "1");
         context.PopUp(formatLink("htbus002.aspx") + "?" + UrlEncode("" +AV33gTTBUS_ID) + "," + UrlEncode(StringUtil.RTrim(AV27gTTBUS_Descripcion)) + "," + UrlEncode(StringUtil.RTrim(AV45SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV62USUARIO)), new Object[] {"AV33gTTBUS_ID","AV27gTTBUS_Descripcion","AV45SISTEMA","AV62USUARIO"});
      }

      protected void E141M2( )
      {
         /* 'Listar Movimientos' Routine */
         GXt_char3 = "PDF" ;
         new prep000(context ).execute( ref  AV38NOMBRE_REPORTE, ref  GXt_char3) ;
         context.wjLoc = formatLink("aptbus012.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV38NOMBRE_REPORTE)) + "," + UrlEncode(StringUtil.RTrim(AV62USUARIO)) + "," + UrlEncode("" +AV33gTTBUS_ID) ;
      }

      protected void E111M2( )
      {
         /* 'Buscar' Routine */
         AV52TTBUS_Descripcion = "%" + StringUtil.Trim( AV14fTTBUS_Descripcion) + "%" ;
      }

      protected void S112( )
      {
         /* 'CARGA POSICIONES' Routine */
         AV6band = 0 ;
         /* Using cursor H001M12 */
         pr_default.execute(10, new Object[] {AV62USUARIO});
         while ( (pr_default.getStatus(10) != 101) )
         {
            A40TTBUS8_CodUsuario = H001M12_A40TTBUS8_CodUsuario[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A40TTBUS8_CodUsuario", A40TTBUS8_CodUsuario);
            AV6band = 1 ;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(10);
         if ( ( ( AV6band == 1 ) ) || ( ( StringUtil.StrCmp(AV62USUARIO, "SUPERVISOR") == 0 ) ) )
         {
            cmbavTtbus7_pos.addItem(" -1", "TODAS", 0);
            /* Using cursor H001M13 */
            pr_default.execute(11);
            while ( (pr_default.getStatus(11) != 101) )
            {
               A31W53POS = H001M13_A31W53POS[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A31W53POS", StringUtil.LTrim( StringUtil.Str( (decimal)(A31W53POS), 3, 0)));
               A32W53DES = H001M13_A32W53DES[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32W53DES", A32W53DES);
               /* Using cursor H001M14 */
               pr_default.execute(12, new Object[] {A31W53POS});
               while ( (pr_default.getStatus(12) != 101) )
               {
                  A33TTBUS7_Pos = H001M14_A33TTBUS7_Pos[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
                  A34TTBUS7_Des = H001M14_A34TTBUS7_Des[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34TTBUS7_Des", A34TTBUS7_Des);
                  n34TTBUS7_Des = H001M14_n34TTBUS7_Des[0] ;
                  A34TTBUS7_Des = H001M14_A34TTBUS7_Des[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34TTBUS7_Des", A34TTBUS7_Des);
                  n34TTBUS7_Des = H001M14_n34TTBUS7_Des[0] ;
                  cmbavTtbus7_pos.addItem(StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0), A34TTBUS7_Des, 0);
                  /* Exiting from a For First loop. */
                  if (true) break;
               }
               pr_default.close(12);
               pr_default.readNext(11);
            }
            pr_default.close(11);
            AV60TTBUS7_Pos = -1 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV60TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(AV60TTBUS7_Pos), 3, 0)));
         }
         else
         {
            /* Using cursor H001M15 */
            pr_default.execute(13);
            while ( (pr_default.getStatus(13) != 101) )
            {
               A31W53POS = H001M15_A31W53POS[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A31W53POS", StringUtil.LTrim( StringUtil.Str( (decimal)(A31W53POS), 3, 0)));
               A32W53DES = H001M15_A32W53DES[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32W53DES", A32W53DES);
               /* Using cursor H001M16 */
               pr_default.execute(14, new Object[] {A31W53POS});
               while ( (pr_default.getStatus(14) != 101) )
               {
                  BRK1M13 = false ;
                  A33TTBUS7_Pos = H001M16_A33TTBUS7_Pos[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
                  A34TTBUS7_Des = H001M16_A34TTBUS7_Des[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34TTBUS7_Des", A34TTBUS7_Des);
                  n34TTBUS7_Des = H001M16_n34TTBUS7_Des[0] ;
                  A35TTBUS7_CodResp = H001M16_A35TTBUS7_CodResp[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35TTBUS7_CodResp", A35TTBUS7_CodResp);
                  n35TTBUS7_CodResp = H001M16_n35TTBUS7_CodResp[0] ;
                  A34TTBUS7_Des = H001M16_A34TTBUS7_Des[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34TTBUS7_Des", A34TTBUS7_Des);
                  n34TTBUS7_Des = H001M16_n34TTBUS7_Des[0] ;
                  AV64vTTBUS7_Pos = A33TTBUS7_Pos ;
                  if ( StringUtil.StrCmp(A35TTBUS7_CodResp, AV62USUARIO) == 0 )
                  {
                     cmbavTtbus7_pos.addItem(StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0), A34TTBUS7_Des, 0);
                  }
                  else
                  {
                     while ( (pr_default.getStatus(14) != 101) && ( H001M16_A33TTBUS7_Pos[0] == A33TTBUS7_Pos ) )
                     {
                        BRK1M13 = false ;
                        A34TTBUS7_Des = H001M16_A34TTBUS7_Des[0] ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34TTBUS7_Des", A34TTBUS7_Des);
                        n34TTBUS7_Des = H001M16_n34TTBUS7_Des[0] ;
                        A35TTBUS7_CodResp = H001M16_A35TTBUS7_CodResp[0] ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35TTBUS7_CodResp", A35TTBUS7_CodResp);
                        n35TTBUS7_CodResp = H001M16_n35TTBUS7_CodResp[0] ;
                        A34TTBUS7_Des = H001M16_A34TTBUS7_Des[0] ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34TTBUS7_Des", A34TTBUS7_Des);
                        n34TTBUS7_Des = H001M16_n34TTBUS7_Des[0] ;
                        /* Using cursor H001M17 */
                        pr_default.execute(15, new Object[] {A31W53POS, AV62USUARIO, AV64vTTBUS7_Pos});
                        while ( (pr_default.getStatus(15) != 101) )
                        {
                           A39TTBUS7_CodUsuario = H001M17_A39TTBUS7_CodUsuario[0] ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39TTBUS7_CodUsuario", A39TTBUS7_CodUsuario);
                           A33TTBUS7_Pos = H001M17_A33TTBUS7_Pos[0] ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
                           cmbavTtbus7_pos.addItem(StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0), A34TTBUS7_Des, 0);
                           /* Exiting from a For First loop. */
                           if (true) break;
                        }
                        pr_default.close(15);
                        BRK1M13 = true ;
                        pr_default.readNext(14);
                     }
                  }
                  if ( ! BRK1M13 )
                  {
                     BRK1M13 = true ;
                     pr_default.readNext(14);
                  }
               }
               pr_default.close(14);
               pr_default.readNext(13);
            }
            pr_default.close(13);
         }
      }

      protected void S125( )
      {
         /* 'RESPONSABLES' Routine */
         /* Using cursor H001M18 */
         pr_default.execute(16, new Object[] {AV57TTBUS2_RespDesde});
         while ( (pr_default.getStatus(16) != 101) )
         {
            A6USU_COD = H001M18_A6USU_COD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
            A7USU_DES = H001M18_A7USU_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7USU_DES", A7USU_DES);
            AV10dUSU_DES = A7USU_DES ;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(16);
         /* Using cursor H001M19 */
         pr_default.execute(17, new Object[] {AV58TTBUS2_RespHacia});
         while ( (pr_default.getStatus(17) != 101) )
         {
            A6USU_COD = H001M19_A6USU_COD[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
            A7USU_DES = H001M19_A7USU_DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7USU_DES", A7USU_DES);
            AV36hUSU_DES = A7USU_DES ;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(17);
      }

      protected void wb_table1_2_1M2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            sStyleString = sStyleString + " height: " + StringUtil.LTrim( StringUtil.Str( (decimal)(57), 10, 0)) + "px" + ";" ;
            sStyleString = sStyleString + " width: " + StringUtil.LTrim( StringUtil.Str( (decimal)(824), 10, 0)) + "px" + ";" ;
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "left")+"\">") ;
            ClassString = "ErrorViewer" ;
            StyleString = "" ;
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_8_1M2( true) ;
         }
         else
         {
            wb_table2_8_1M2( false) ;
         }
         return  ;
      }

      protected void wb_table2_8_1M2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"height:18px\">") ;
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"" ;
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgImg_alta_Internalname, "", context.GetImagePath( "5649fbb8-8ce0-4810-a5ce-bd649ea83c3a", "", "Modern"), "Modern", imgImg_alta_Visible, 1, "", "Alta", 0, 0, 0, "", 0, "", 0, 0, "", "", 5, imgImg_alta_Jsonclick, "E\\'ALTA\\'.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_HTBUS001.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /*  Grid Control  */
            Grid1Container.SetWrapped(nGXWrapped);
            if ( Grid1Container.GetWrapped() == 1 )
            {
               sStyleString = "" ;
               GxWebStd.gx_table_start( context, subGrid1_Internalname, subGrid1_Internalname, "", "Grid", 0, "", "", 1, 2, sStyleString, "", 0);
               /* Subfile titles */
               context.WriteHtmlText( "<tr") ;
               context.WriteHtmlTextNl( ">") ;
               if ( subGrid1_Backcolorstyle == 0 )
               {
                  subGrid1_Titlebackstyle = 0 ;
                  if ( StringUtil.Len( subGrid1_Class) > 0 )
                  {
                     subGrid1_Linesclass = subGrid1_Class+"Title" ;
                  }
               }
               else
               {
                  subGrid1_Titlebackstyle = 1 ;
                  if ( subGrid1_Backcolorstyle == 1 )
                  {
                     subGrid1_Titlebackcolor = subGrid1_Allbackcolor ;
                     if ( StringUtil.Len( subGrid1_Class) > 0 )
                     {
                        subGrid1_Linesclass = subGrid1_Class+"UniformTitle" ;
                     }
                  }
                  else
                  {
                     if ( StringUtil.Len( subGrid1_Class) > 0 )
                     {
                        subGrid1_Linesclass = subGrid1_Class+"Title" ;
                     }
                  }
               }
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((edtavBaja_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((edtavEdicion_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "g Id Identificador") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Cód. Identificador") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Nº Bien") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Descripción") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Fecha Carga") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Cód. Rubro") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Desc. Rubro") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "g TTBUS_ Fecha Baja") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Alquilado") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "g TTBUS_ Cod Proveedor") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Proveedor") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" width="+StringUtil.LTrim( StringUtil.Str( (decimal)(150), 4, 0))+"px"+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Estado") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "g TTBUS_ Cod Posicion") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Posición Actual") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "SEC_ CRE") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" width="+StringUtil.LTrim( StringUtil.Str( (decimal)(150), 4, 0))+"px"+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Responsable Actual") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlTextNl( "</tr>") ;
            }
            else
            {
               Grid1Container.AddObjectProperty("GridName", "Grid1");
               Grid1Container.AddObjectProperty("Class", "Grid");
               Grid1Container.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Backcolorstyle), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("CmpContext", "");
               Grid1Container.AddObjectProperty("InMasterPage", "false");
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", context.convertURL( AV5baja));
               Grid1Column.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavBaja_Visible), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", context.convertURL( AV11edicion));
               Grid1Column.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavEdicion_Visible), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", context.convertURL( AV63visualizacion));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV22gIdIdentificador), 8, 0, ".", "")));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavGididentificador_Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( AV23gNumeroIdentificador));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavGnumeroidentificador_Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV33gTTBUS_ID), 8, 0, ".", "")));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavGttbus_id_Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( AV27gTTBUS_Descripcion));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavGttbus_descripcion_Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", context.localUtil.Format(AV32gTTBUS_FechaCarga, "99/99/9999"));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavGttbus_fechacarga_Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV34gTTBUS_RubroBien), 4, 0, ".", "")));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavGttbus_rubrobien_Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( AV35gTTBUS_RubroDesc));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavGttbus_rubrodesc_Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", context.localUtil.Format(AV31gTTBUS_FechaBaja, "99/99/9999"));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavGttbus_fechabaja_Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV24gTTBUS_Alquilado), 1, 0, ".", "")));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(chkavGttbus_alquilado.Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV26gTTBUS_CodProveedor), 8, 0, ".", "")));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavGttbus_codproveedor_Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( AV29gTTBUS_DesProveedor));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavGttbus_desproveedor_Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV30gTTBUS_Estado), 1, 0, ".", "")));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbavGttbus_estado.Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV25gTTBUS_CodPosicion), 3, 0, ".", "")));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavGttbus_codposicion_Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( AV28gTTBUS_DesPosicion));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavGttbus_desposicion_Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( AV42SEC_CRE));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavSec_cre_Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( AV43SEC_DRE));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavSec_dre_Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Container.AddObjectProperty("Allowselection", "true");
               Grid1Container.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Selectioncolor), 9, 0, ".", "")));
               Grid1Container.AddObjectProperty("Allowhover", "true");
               Grid1Container.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Hoveringcolor), 9, 0, ".", "")));
               Grid1Container.AddObjectProperty("Allowcollapsing", "false");
               Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 9, 0, ".", "")));
            }
         }
         if ( wbEnd == 61 )
         {
            wbEnd = 0 ;
            nRC_Grid1 = (short)(nGXsfl_61_idx-1) ;
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
            }
            else
            {
               Grid1Container.AddObjectProperty("GRID1_nEOF", GRID1_nEOF);
               Grid1Container.AddObjectProperty("GRID1_nFirstRecordOnPage", GRID1_nFirstRecordOnPage);
               sStyleString = " style=\"display:none;\"" ;
               sStyleString = "" ;
               context.WriteHtmlText( "<div id=\""+"Grid1Container"+"Div\" "+sStyleString+">"+"</div>") ;
               context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Grid1", (Object)(Grid1Container));
               GxWebStd.gx_hidden_field( context, "Grid1ContainerData", Grid1Container.ToJavascriptSource());
               if ( context.isAjaxRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "Grid1ContainerData"+"V", Grid1Container.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Grid1ContainerData"+"V"+"\" value='"+Grid1Container.GridValuesHidden()+"'>") ;
               }
            }
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "left")+";height:24px\">") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 83,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttButton1_Internalname, "Ver Movimientos del Bien", "Ver Movimientos del Bien", "", StyleString, ClassString, 1, 1, "rounded", 5, bttButton1_Jsonclick, "E\\'MOVIMIENTOS\\'.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(61), 3, 0)+","+"null"+");", "", "HLP_HTBUS001.htm");
            context.WriteHtmlText( "&nbsp;&nbsp;&nbsp;") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 84,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttButton4_Internalname, "Listar Movimientos del Bien", "Listar Movimientos del Bien", "", StyleString, ClassString, 1, 1, "rounded", 5, bttButton4_Jsonclick, "E\\'LISTAR MOVIMIENTOS\\'.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(61), 3, 0)+","+"null"+");", "", "HLP_HTBUS001.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"height:15px\">") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"height:15px\">") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"height:15px\">") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"height:36px\">") ;
            wb_table3_93_1M2( true) ;
         }
         else
         {
            wb_table3_93_1M2( false) ;
         }
         return  ;
      }

      protected void wb_table3_93_1M2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table4_111_1M2( true) ;
         }
         else
         {
            wb_table4_111_1M2( false) ;
         }
         return  ;
      }

      protected void wb_table4_111_1M2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"height:15px\">") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"height:22px\">") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_1M2e( true) ;
         }
         else
         {
            wb_table1_2_1M2e( false) ;
         }
      }

      protected void wb_table4_111_1M2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTbl_tabs_Internalname, tblTbl_tabs_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* WebComponent */
            GxWebStd.gx_hidden_field( context, "W0114"+"", StringUtil.RTrim( WebComp_Wc_tabs_Component));
            context.WriteHtmlText( "<div") ;
            context.WriteHtmlText( " id=\""+"gxHTMLWrpW0114"+""+"\""+"") ;
            context.WriteHtmlText( ">") ;
            if ( StringUtil.StrCmp(OldWc_tabs, WebComp_Wc_tabs_Component) != 0 )
            {
               context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0114"+"");
            }
            WebComp_Wc_tabs.componentdraw();
            if ( StringUtil.StrCmp(OldWc_tabs, WebComp_Wc_tabs_Component) != 0 )
            {
               context.httpAjaxContext.ajax_rspEndCmp();
            }
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_111_1M2e( true) ;
         }
         else
         {
            wb_table4_111_1M2e( false) ;
         }
      }

      protected void wb_table3_93_1M2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            if ( tblTbl_movimientos_Visible == 0 )
            {
               sStyleString = sStyleString + "display:none;" ;
            }
            sStyleString = sStyleString + " height: " + StringUtil.LTrim( StringUtil.Str( (decimal)(46), 10, 0)) + "px" + ";" ;
            sStyleString = sStyleString + " width: " + StringUtil.LTrim( StringUtil.Str( (decimal)(463), 10, 0)) + "px" + ";" ;
            GxWebStd.gx_table_start( context, tblTbl_movimientos_Internalname, tblTbl_movimientos_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"height:26px\">") ;
            /* Text block */
            ClassString = "SubTitle" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock2_Internalname, 1, 1, 0, "Bienes a Recibir", "", "", "", 0, lblTextblock2_Jsonclick, "", StyleString, ClassString, "HLP_HTBUS001.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "SubTitle" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock3_Internalname, 1, 1, 0, "Bienes Enviados", "", "", "", 0, lblTextblock3_Jsonclick, "", StyleString, ClassString, "HLP_HTBUS001.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\"  style=\"height:15px\">") ;
            /* WebComponent */
            GxWebStd.gx_hidden_field( context, "W0101"+"", StringUtil.RTrim( WebComp_Wc_bienes_a_recibir_Component));
            context.WriteHtmlText( "<div") ;
            context.WriteHtmlText( " id=\""+"gxHTMLWrpW0101"+""+"\""+"") ;
            context.WriteHtmlText( ">") ;
            if ( StringUtil.Len( WebComp_Wc_bienes_a_recibir_Component) != 0 )
            {
               if ( StringUtil.StrCmp(OldWc_bienes_a_recibir, WebComp_Wc_bienes_a_recibir_Component) != 0 )
               {
                  context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0101"+"");
               }
               WebComp_Wc_bienes_a_recibir.componentdraw();
               if ( StringUtil.StrCmp(OldWc_bienes_a_recibir, WebComp_Wc_bienes_a_recibir_Component) != 0 )
               {
                  context.httpAjaxContext.ajax_rspEndCmp();
               }
            }
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td valign=\"top\" >") ;
            /* WebComponent */
            GxWebStd.gx_hidden_field( context, "W0103"+"", StringUtil.RTrim( WebComp_Wc_bienes_enviados_Component));
            context.WriteHtmlText( "<div") ;
            context.WriteHtmlText( " id=\""+"gxHTMLWrpW0103"+""+"\""+"") ;
            context.WriteHtmlText( ">") ;
            if ( StringUtil.Len( WebComp_Wc_bienes_enviados_Component) != 0 )
            {
               if ( StringUtil.StrCmp(OldWc_bienes_enviados, WebComp_Wc_bienes_enviados_Component) != 0 )
               {
                  context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0103"+"");
               }
               WebComp_Wc_bienes_enviados.componentdraw();
               if ( StringUtil.StrCmp(OldWc_bienes_enviados, WebComp_Wc_bienes_enviados_Component) != 0 )
               {
                  context.httpAjaxContext.ajax_rspEndCmp();
               }
            }
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"height:15px\">") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTbxpantallacomp1_Internalname, 1, 1, 0, "Ver Todos los Bienes a Recibir", "", lblTbxpantallacomp1_Link, lblTbxpantallacomp1_Linktarget, 0, lblTbxpantallacomp1_Jsonclick, "", StyleString, ClassString, "HLP_HTBUS001.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTbxpantallacomp2_Internalname, 1, 1, 0, "Ver Todos los Bienes Enviados", "", lblTbxpantallacomp2_Link, lblTbxpantallacomp2_Linktarget, 0, lblTbxpantallacomp2_Jsonclick, "", StyleString, ClassString, "HLP_HTBUS001.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_93_1M2e( true) ;
         }
         else
         {
            wb_table3_93_1M2e( false) ;
         }
      }

      protected void wb_table2_8_1M2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            sStyleString = sStyleString + " height: " + StringUtil.LTrim( StringUtil.Str( (decimal)(118), 10, 0)) + "px" + ";" ;
            sStyleString = sStyleString + " width: " + StringUtil.LTrim( StringUtil.Str( (decimal)(870), 10, 0)) + "px" + ";" ;
            GxWebStd.gx_table_start( context, tblTable3_Internalname, tblTable3_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock10_Internalname, 1, 1, 0, "Tipo Identificador:", "", "", "", 0, lblTextblock10_Jsonclick, "", StyleString, ClassString, "HLP_HTBUS001.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'" + sGXsfl_61_idx + "',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavFididentificador, dynavFididentificador_Internalname, StringUtil.Str( (decimal)(AV12fIdIdentificador), 8, 0), "", "int", 1, 1, 0, 1, 0, 60, "chr", 0, "", StyleString, ClassString, "", 0, dynavFididentificador_Jsonclick, "", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(13);\"", true, "HLP_HTBUS001.htm");
            dynavFididentificador.CurrentValue = StringUtil.Str( (decimal)(AV12fIdIdentificador), 8, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavFididentificador_Internalname, "Values", (String)(dynavFididentificador.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td style=\"width:163px\">") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, 1, 1, 0, "Nº Bien:", "", "", "", 0, lblTextblock1_Jsonclick, "", StyleString, ClassString, "HLP_HTBUS001.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'" + sGXsfl_61_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavTtbus_id_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV55TTBUS_Id), 8, 0, ",", "")), "", 8, "chr", 1, "row", 8, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(AV55TTBUS_Id), "ZZZZZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(18);\"", 0, edtavTtbus_id_Jsonclick, "", 0, 1, -1, true, "right", "HLP_HTBUS001.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock9_Internalname, 1, 1, 0, "Cód. Identificador", "", "", "", 0, lblTextblock9_Jsonclick, "", StyleString, ClassString, "HLP_HTBUS001.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'" + sGXsfl_61_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavFnumeroidentificador_Internalname, StringUtil.RTrim( AV13fNumeroIdentificador), "", 80, "chr", 1, "row", 80, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV13fNumeroIdentificador, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(23);\"", 0, edtavFnumeroidentificador_Jsonclick, "", 0, 1, -1, true, "left", "HLP_HTBUS001.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock8_Internalname, 1, 1, 0, "Estado:", "", "", "", 0, lblTextblock8_Jsonclick, "", StyleString, ClassString, "HLP_HTBUS001.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 28,'',false,'" + sGXsfl_61_idx + "',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavFttbus_estado, cmbavFttbus_estado_Internalname, StringUtil.Str( (decimal)(AV15fTTBUS_Estado), 1, 0), "", "int", 1, 1, 0, 1, 0, 1, "chr", 0, "", StyleString, ClassString, "", 0, cmbavFttbus_estado_Jsonclick, "", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(28);\"", true, "HLP_HTBUS001.htm");
            cmbavFttbus_estado.CurrentValue = StringUtil.Str( (decimal)(AV15fTTBUS_Estado), 1, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavFttbus_estado_Internalname, "Values", (String)(cmbavFttbus_estado.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock5_Internalname, 1, 1, 0, "Descripción:", "", "", "", 0, lblTextblock5_Jsonclick, "", StyleString, ClassString, "HLP_HTBUS001.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 33,'',false,'" + sGXsfl_61_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavFttbus_descripcion_Internalname, StringUtil.RTrim( AV14fTTBUS_Descripcion), "", 50, "chr", 1, "row", 50, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV14fTTBUS_Descripcion, "@!")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(33);\"", 0, edtavFttbus_descripcion_Jsonclick, "", 0, 1, 0, true, "left", "HLP_HTBUS001.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock7_Internalname, 1, 1, 0, "Rubro:", "", "", "", 0, lblTextblock7_Jsonclick, "", StyleString, ClassString, "HLP_HTBUS001.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'" + sGXsfl_61_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavTtbus_rubrobien_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV56TTBUS_RubroBien), 4, 0, ",", "")), "", 4, "chr", 1, "row", 4, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(AV56TTBUS_RubroBien), "ZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(38);\"", 0, edtavTtbus_rubrobien_Jsonclick, "", 0, 1, -1, true, "right", "HLP_HTBUS001.htm");
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgprompt_Ttbus_rubrobien_Internalname, "", "prompt.gif", "Modern", 1, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, imgprompt_Ttbus_rubrobien_Link, "", 0, "", "", StyleString, ClassString, "", "", "''", "", "HLP_HTBUS001.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock4_Internalname, 1, 1, 0, "Posición:", "", "", "", 0, lblTextblock4_Jsonclick, "", StyleString, ClassString, "HLP_HTBUS001.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'" + sGXsfl_61_idx + "',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavTtbus7_pos, cmbavTtbus7_pos_Internalname, StringUtil.Str( (decimal)(AV60TTBUS7_Pos), 3, 0), "", "int", 1, 1, 0, 1, 0, 3, "chr", 0, "", StyleString, ClassString, "", 0, cmbavTtbus7_pos_Jsonclick, "", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(43);\"", true, "HLP_HTBUS001.htm");
            cmbavTtbus7_pos.CurrentValue = StringUtil.Str( (decimal)(AV60TTBUS7_Pos), 3, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavTtbus7_pos_Internalname, "Values", (String)(cmbavTtbus7_pos.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "&nbsp;&nbsp; ") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock6_Internalname, 1, 1, 0, "Fecha de Carga:", "", "", "", 0, lblTextblock6_Jsonclick, "", StyleString, ClassString, "HLP_HTBUS001.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'" + sGXsfl_61_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtavTtbus_fechacarga_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavTtbus_fechacarga_Internalname, context.localUtil.Format(AV54TTBUS_FechaCarga, "99/99/9999"), "", 10, "chr", 1, "row", 10, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( AV54TTBUS_FechaCarga, "99/99/9999"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',0,24,'spa',false,0);"+";gx.evt.onblur(48);\"", 0, edtavTtbus_fechacarga_Jsonclick, "", 0, 1, -1, true, "right", "HLP_HTBUS001.htm");
            GxWebStd.gx_bitmap( context, edtavTtbus_fechacarga_Internalname+"_dp_trigger", "", "calendar-img.gif", "", ((1==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, "", "", 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_HTBUS001.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 52,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttButton3_Internalname, "Buscar", "Buscar", "", StyleString, ClassString, 1, 1, "rounded", 5, bttButton3_Jsonclick, "E\\'BUSCAR\\'.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(61), 3, 0)+","+"null"+");", "", "HLP_HTBUS001.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_8_1M2e( true) ;
         }
         else
         {
            wb_table2_8_1M2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV45SISTEMA = (String)getParm(obj,0) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV45SISTEMA", AV45SISTEMA);
         AV62USUARIO = (String)getParm(obj,1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV62USUARIO", AV62USUARIO);
      }

      public override String getresponse( String sGXDynURL )
      {
         initialize_properties( ) ;
         BackMsgLst = context.GX_msglist ;
         context.GX_msglist = LclMsgLst ;
         sDynURL = sGXDynURL ;
         nGotPars = (short)(1) ;
         nGXWrapped = (short)(1) ;
         context.SetWrapped(true);
         PA1M2( ) ;
         WS1M2( ) ;
         WE1M2( ) ;
         this.cleanup();
         context.SetWrapped(false);
         context.GX_msglist = BackMsgLst ;
         return "";
      }

      public void responsestatic( String sGXDynURL )
      {
      }

      protected void define_styles( )
      {
         AddStyleSheetFile("calendar-system.css", "?84120");
         AddThemeStyleSheetFile("", "Modern.css", "?2051812");
         if ( StringUtil.StrCmp(WebComp_Wc_bienes_a_recibir_Component, "") == 0 )
         {
            WebComp_Wc_bienes_a_recibir = getWebComponent(GetType(), "GeneXus.Programs", "htbus004", new Object[] {context} );
            WebComp_Wc_bienes_a_recibir.ComponentInit();
            WebComp_Wc_bienes_a_recibir.Name = "HTBUS004";
            WebComp_Wc_bienes_a_recibir_Component = "HTBUS004" ;
         }
         if ( ! ( WebComp_Wc_bienes_a_recibir == null ) )
         {
            if ( StringUtil.Len( WebComp_Wc_bienes_a_recibir_Component) != 0 )
            {
               WebComp_Wc_bienes_a_recibir.componentthemes();
            }
         }
         if ( StringUtil.StrCmp(WebComp_Wc_bienes_enviados_Component, "") == 0 )
         {
            WebComp_Wc_bienes_enviados = getWebComponent(GetType(), "GeneXus.Programs", "htbus003_", new Object[] {context} );
            WebComp_Wc_bienes_enviados.ComponentInit();
            WebComp_Wc_bienes_enviados.Name = "HTBUS003_";
            WebComp_Wc_bienes_enviados_Component = "HTBUS003_" ;
         }
         if ( ! ( WebComp_Wc_bienes_enviados == null ) )
         {
            if ( StringUtil.Len( WebComp_Wc_bienes_enviados_Component) != 0 )
            {
               WebComp_Wc_bienes_enviados.componentthemes();
            }
         }
         if ( ! ( WebComp_Wc_tabs == null ) )
         {
            WebComp_Wc_tabs.componentthemes();
         }
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?13222697");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?42940");
         context.AddJavascriptSource("htbus001.js", "?13222697");
         /* End function include_jscripts */
      }

      protected void sendrow_612( )
      {
         WB1M0( ) ;
         if ( ( 10 * 1 == 0 ) || ( nGXsfl_61_idx <= subGrid1_Recordsperpage( ) * 1 ) )
         {
            Grid1Row = GXWebRow.GetNew(context,Grid1Container) ;
            if ( subGrid1_Backcolorstyle == 0 )
            {
               /* None style subfile background logic. */
               subGrid1_Backstyle = 0 ;
               if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Odd" ;
               }
            }
            else if ( subGrid1_Backcolorstyle == 1 )
            {
               /* Uniform style subfile background logic. */
               subGrid1_Backstyle = 0 ;
               subGrid1_Backcolor = subGrid1_Allbackcolor ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Grid1ContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid1_Backcolor), 9, 0)));
               if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Uniform" ;
               }
            }
            else if ( subGrid1_Backcolorstyle == 2 )
            {
               /* Header style subfile background logic. */
               subGrid1_Backstyle = 1 ;
               if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Odd" ;
               }
               subGrid1_Backcolor = (int)(0xF0F0F0) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Grid1ContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid1_Backcolor), 9, 0)));
            }
            else if ( subGrid1_Backcolorstyle == 3 )
            {
               /* Report style subfile background logic. */
               subGrid1_Backstyle = 1 ;
               if ( ((int)(nGXsfl_61_idx) % (2)) == 0 )
               {
                  subGrid1_Backcolor = (int)(0xE5E5E5) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Grid1ContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid1_Backcolor), 9, 0)));
                  if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
                  {
                     subGrid1_Linesclass = subGrid1_Class+"Even" ;
                  }
               }
               else
               {
                  subGrid1_Backcolor = (int)(0xF0F0F0) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Grid1ContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid1_Backcolor), 9, 0)));
                  if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
                  {
                     subGrid1_Linesclass = subGrid1_Class+"Odd" ;
                  }
               }
            }
            imgprompt_Ttbus_rubrobien_Link = "javascript:"+"gx.popup.openPrompt('"+"htbus_rub.aspx"+"',["+"{Ctrl:gx.dom.el('"+"vTTBUS_RUBROBIEN"+"'), id:'"+"vTTBUS_RUBROBIEN"+"'"+",isOut:true,isKey:false,isLastKey:false}"+"],"+"null"+","+"'', false"+","+"false"+","+"false"+");" ;
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<tr ") ;
               context.WriteHtmlText( " class=\""+subGrid1_Linesclass+"\" style=\""+""+"\"") ;
               context.WriteHtmlText( ">") ;
            }
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavBaja_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Active Bitmap Variable */
            TempTags = " " + ((edtavBaja_Enabled!=0)&&(edtavBaja_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 62,'',false,'',61)\"" : " ") ;
            ClassString = "Image" ;
            StyleString = "" ;
            Grid1Row.AddColumnProperties("bitmap", 2, isAjaxCallMode( ), new Object[] {(String)edtavBaja_Internalname,(String)"",(String)AV5baja,(String)"Modern",(int)edtavBaja_Visible,(short)1,(String)"",(String)"Baja",(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"",(short)0,(short)0,(String)"",(String)"",(short)5,(String)edtavBaja_Jsonclick,"E\\'BAJA\\'."+sGXsfl_61_idx,(String)StyleString,(String)ClassString,(String)"",(String)""+TempTags,(String)"''",(String)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavEdicion_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Active Bitmap Variable */
            TempTags = " " + ((edtavEdicion_Enabled!=0)&&(edtavEdicion_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 63,'',false,'',61)\"" : " ") ;
            ClassString = "Image" ;
            StyleString = "" ;
            Grid1Row.AddColumnProperties("bitmap", 2, isAjaxCallMode( ), new Object[] {(String)edtavEdicion_Internalname,(String)"",(String)AV11edicion,(String)"Modern",(int)edtavEdicion_Visible,(short)1,(String)"",(String)"Edición",(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"",(short)0,(short)0,(String)"",(String)"",(short)5,(String)edtavEdicion_Jsonclick,"E\\'MODIFICACION\\'."+sGXsfl_61_idx,(String)StyleString,(String)ClassString,(String)"",(String)""+TempTags,(String)"''",(String)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Active Bitmap Variable */
            TempTags = " " + ((edtavVisualizacion_Enabled!=0)&&(edtavVisualizacion_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 64,'',false,'',61)\"" : " ") ;
            ClassString = "Image" ;
            StyleString = "" ;
            Grid1Row.AddColumnProperties("bitmap", 2, isAjaxCallMode( ), new Object[] {(String)edtavVisualizacion_Internalname,(String)"",(String)AV63visualizacion,(String)"Modern",(short)-1,(short)1,(String)"",(String)"Visualización",(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"",(short)0,(short)0,(String)"",(String)"",(short)5,(String)edtavVisualizacion_Jsonclick,"E\\'VISUALIZACION\\'."+sGXsfl_61_idx,(String)StyleString,(String)ClassString,(String)"",(String)""+TempTags,(String)"''",(String)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            TempTags = " " + ((edtavGididentificador_Enabled!=0)&&(edtavGididentificador_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 65,'',false,'"+sGXsfl_61_idx+"',61)\"" : " ") ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavGididentificador_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(AV22gIdIdentificador), 8, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)8,(short)0,(int)edtavGididentificador_Enabled,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(AV22gIdIdentificador), "ZZZZZZZ9"),TempTags+((edtavGididentificador_Enabled!=0)&&(edtavGididentificador_Visible!=0) ? " onchange=\"gx.evt.onchange(this)\" " : " ")+((edtavGididentificador_Enabled!=0)&&(edtavGididentificador_Visible!=0) ? " onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(65);\"" : " "),(short)0,(String)edtavGididentificador_Jsonclick,(String)"",(short)61,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            TempTags = " " + ((edtavGnumeroidentificador_Enabled!=0)&&(edtavGnumeroidentificador_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 66,'',false,'"+sGXsfl_61_idx+"',61)\"" : " ") ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavGnumeroidentificador_Internalname,StringUtil.RTrim( AV23gNumeroIdentificador),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)80,(short)-1,(int)edtavGnumeroidentificador_Enabled,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( AV23gNumeroIdentificador, "")),TempTags+((edtavGnumeroidentificador_Enabled!=0)&&(edtavGnumeroidentificador_Visible!=0) ? " onchange=\"gx.evt.onchange(this)\" " : " ")+((edtavGnumeroidentificador_Enabled!=0)&&(edtavGnumeroidentificador_Visible!=0) ? " onblur=\""+""+";gx.evt.onblur(66);\"" : " "),(short)0,(String)edtavGnumeroidentificador_Jsonclick,(String)"",(short)61,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            TempTags = " " + ((edtavGttbus_id_Enabled!=0)&&(edtavGttbus_id_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 67,'',false,'"+sGXsfl_61_idx+"',61)\"" : " ") ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavGttbus_id_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(AV33gTTBUS_ID), 8, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)8,(short)-1,(int)edtavGttbus_id_Enabled,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(AV33gTTBUS_ID), "ZZZZZZZ9"),TempTags+((edtavGttbus_id_Enabled!=0)&&(edtavGttbus_id_Visible!=0) ? " onchange=\"gx.evt.onchange(this)\" " : " ")+((edtavGttbus_id_Enabled!=0)&&(edtavGttbus_id_Visible!=0) ? " onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(67);\"" : " "),(short)0,(String)edtavGttbus_id_Jsonclick,(String)"",(short)61,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            TempTags = " " + ((edtavGttbus_descripcion_Enabled!=0)&&(edtavGttbus_descripcion_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 68,'',false,'"+sGXsfl_61_idx+"',61)\"" : " ") ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavGttbus_descripcion_Internalname,StringUtil.RTrim( AV27gTTBUS_Descripcion),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)50,(short)-1,(int)edtavGttbus_descripcion_Enabled,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( AV27gTTBUS_Descripcion, "@!")),TempTags+((edtavGttbus_descripcion_Enabled!=0)&&(edtavGttbus_descripcion_Visible!=0) ? " onchange=\"gx.evt.onchange(this)\" " : " ")+((edtavGttbus_descripcion_Enabled!=0)&&(edtavGttbus_descripcion_Visible!=0) ? " onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(68);\"" : " "),(short)0,(String)edtavGttbus_descripcion_Jsonclick,(String)"",(short)61,(short)1,(short)0,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            TempTags = " " + ((edtavGttbus_fechacarga_Enabled!=0)&&(edtavGttbus_fechacarga_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 69,'',false,'"+sGXsfl_61_idx+"',61)\"" : " ") ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavGttbus_fechacarga_Internalname,context.localUtil.Format(AV32gTTBUS_FechaCarga, "99/99/9999"),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)10,(short)-1,(int)edtavGttbus_fechacarga_Enabled,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( AV32gTTBUS_FechaCarga, "99/99/9999"),TempTags+((edtavGttbus_fechacarga_Enabled!=0)&&(edtavGttbus_fechacarga_Visible!=0) ? " onchange=\"gx.evt.onchange(this)\" " : " ")+((edtavGttbus_fechacarga_Enabled!=0)&&(edtavGttbus_fechacarga_Visible!=0) ? " onblur=\""+"gx.date.valid_date(this, 10,'DMY',0,24,'spa',false,0);"+";gx.evt.onblur(69);\"" : " "),(short)0,(String)edtavGttbus_fechacarga_Jsonclick,(String)"",(short)61,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            TempTags = " " + ((edtavGttbus_rubrobien_Enabled!=0)&&(edtavGttbus_rubrobien_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 70,'',false,'"+sGXsfl_61_idx+"',61)\"" : " ") ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavGttbus_rubrobien_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(AV34gTTBUS_RubroBien), 4, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)4,(short)0,(int)edtavGttbus_rubrobien_Enabled,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(AV34gTTBUS_RubroBien), "ZZZ9"),TempTags+((edtavGttbus_rubrobien_Enabled!=0)&&(edtavGttbus_rubrobien_Visible!=0) ? " onchange=\"gx.evt.onchange(this)\" " : " ")+((edtavGttbus_rubrobien_Enabled!=0)&&(edtavGttbus_rubrobien_Visible!=0) ? " onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(70);\"" : " "),(short)0,(String)edtavGttbus_rubrobien_Jsonclick,(String)"",(short)61,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            TempTags = " " + ((edtavGttbus_rubrodesc_Enabled!=0)&&(edtavGttbus_rubrodesc_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 71,'',false,'"+sGXsfl_61_idx+"',61)\"" : " ") ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavGttbus_rubrodesc_Internalname,StringUtil.RTrim( AV35gTTBUS_RubroDesc),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)30,(short)-1,(int)edtavGttbus_rubrodesc_Enabled,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( AV35gTTBUS_RubroDesc, "@!")),TempTags+((edtavGttbus_rubrodesc_Enabled!=0)&&(edtavGttbus_rubrodesc_Visible!=0) ? " onchange=\"gx.evt.onchange(this)\" " : " ")+((edtavGttbus_rubrodesc_Enabled!=0)&&(edtavGttbus_rubrodesc_Visible!=0) ? " onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(71);\"" : " "),(short)0,(String)edtavGttbus_rubrodesc_Jsonclick,(String)"",(short)61,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            TempTags = " " + ((edtavGttbus_fechabaja_Enabled!=0)&&(edtavGttbus_fechabaja_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 72,'',false,'"+sGXsfl_61_idx+"',61)\"" : " ") ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavGttbus_fechabaja_Internalname,context.localUtil.Format(AV31gTTBUS_FechaBaja, "99/99/9999"),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)10,(short)0,(int)edtavGttbus_fechabaja_Enabled,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( AV31gTTBUS_FechaBaja, "99/99/9999"),TempTags+((edtavGttbus_fechabaja_Enabled!=0)&&(edtavGttbus_fechabaja_Visible!=0) ? " onchange=\"gx.evt.onchange(this)\" " : " ")+((edtavGttbus_fechabaja_Enabled!=0)&&(edtavGttbus_fechabaja_Visible!=0) ? " onblur=\""+"gx.date.valid_date(this, 10,'DMY',0,24,'spa',false,0);"+";gx.evt.onblur(72);\"" : " "),(short)0,(String)edtavGttbus_fechabaja_Jsonclick,(String)"",(short)61,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Check box */
            TempTags = " " + ((chkavGttbus_alquilado.Enabled!=0)&&(chkavGttbus_alquilado.Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 73,'',false,'"+sGXsfl_61_idx+"',61)\"" : " ") ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            Grid1Row.AddColumnProperties("checkbox", 1, isAjaxCallMode( ), new Object[] {(String)chkavGttbus_alquilado_Internalname,StringUtil.Str( (decimal)(AV24gTTBUS_Alquilado), 1, 0),(String)"",(short)-1,chkavGttbus_alquilado.Enabled,(String)"1",(String)"",(String)StyleString,(String)ClassString,TempTags+((chkavGttbus_alquilado.Enabled!=0)&&(chkavGttbus_alquilado.Visible!=0) ? " onclick=\"gx.fn.checkboxClick(73, this, 1, 0);gx.evt.onchange(this);\" " : " ")+((chkavGttbus_alquilado.Enabled!=0)&&(chkavGttbus_alquilado.Visible!=0) ? " onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(73);\"" : " ")});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            TempTags = " " + ((edtavGttbus_codproveedor_Enabled!=0)&&(edtavGttbus_codproveedor_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 74,'',false,'"+sGXsfl_61_idx+"',61)\"" : " ") ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavGttbus_codproveedor_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(AV26gTTBUS_CodProveedor), 8, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)8,(short)0,(int)edtavGttbus_codproveedor_Enabled,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(AV26gTTBUS_CodProveedor), "ZZZZZ9"),TempTags+((edtavGttbus_codproveedor_Enabled!=0)&&(edtavGttbus_codproveedor_Visible!=0) ? " onchange=\"gx.evt.onchange(this)\" " : " ")+((edtavGttbus_codproveedor_Enabled!=0)&&(edtavGttbus_codproveedor_Visible!=0) ? " onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(74);\"" : " "),(short)0,(String)edtavGttbus_codproveedor_Jsonclick,(String)"",(short)61,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            TempTags = " " + ((edtavGttbus_desproveedor_Enabled!=0)&&(edtavGttbus_desproveedor_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 75,'',false,'"+sGXsfl_61_idx+"',61)\"" : " ") ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavGttbus_desproveedor_Internalname,StringUtil.RTrim( AV29gTTBUS_DesProveedor),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)30,(short)0,(int)edtavGttbus_desproveedor_Enabled,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( AV29gTTBUS_DesProveedor, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")),TempTags+((edtavGttbus_desproveedor_Enabled!=0)&&(edtavGttbus_desproveedor_Visible!=0) ? " onchange=\"gx.evt.onchange(this)\" " : " ")+((edtavGttbus_desproveedor_Enabled!=0)&&(edtavGttbus_desproveedor_Visible!=0) ? " onblur=\""+""+";gx.evt.onblur(75);\"" : " "),(short)0,(String)edtavGttbus_desproveedor_Jsonclick,(String)"",(short)61,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = " " + ((cmbavGttbus_estado.Enabled!=0)&&(cmbavGttbus_estado.Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 76,'',false,'"+sGXsfl_61_idx+"',61)\"" : " ") ;
            if ( ( nGXsfl_61_idx == 1 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "vGTTBUS_ESTADO_" + sGXsfl_61_idx ;
               cmbavGttbus_estado.Name = GXCCtl ;
               cmbavGttbus_estado.WebTags = "" ;
               cmbavGttbus_estado.addItem("1", "ASIGNADO A UN SECTOR", 0);
               cmbavGttbus_estado.addItem("2", "CAMBIANDO DE SECTOR", 0);
               cmbavGttbus_estado.addItem("3", "BAJA A CONFIRMAR", 0);
               cmbavGttbus_estado.addItem("4", "BAJA", 0);
               if ( ( cmbavGttbus_estado.ItemCount > 0 ) && (0==AV30gTTBUS_Estado) )
               {
                  AV30gTTBUS_Estado = (short)(NumberUtil.Val( cmbavGttbus_estado.getItemValue(1), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30gTTBUS_Estado", StringUtil.Str( (decimal)(AV30gTTBUS_Estado), 1, 0));
               }
            }
            /* ComboBox */
            Grid1Row.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbavGttbus_estado,(String)cmbavGttbus_estado_Internalname,StringUtil.Str( (decimal)(AV30gTTBUS_Estado), 1, 0),(String)"",(String)"int",(short)-1,cmbavGttbus_estado.Enabled,(short)0,(short)1,(short)0,(short)150,(String)"px",(short)0,(String)"",(String)StyleString,(String)ClassString,(String)"",(short)0,(String)cmbavGttbus_estado_Jsonclick,(String)"",TempTags+((cmbavGttbus_estado.Enabled!=0)&&(cmbavGttbus_estado.Visible!=0) ? " onchange=\"gx.evt.onchange(this)\" " : " ")+((cmbavGttbus_estado.Enabled!=0)&&(cmbavGttbus_estado.Visible!=0) ? " onblur=\""+""+";gx.evt.onblur(76);\"" : " "),(bool)true});
            cmbavGttbus_estado.CurrentValue = StringUtil.Str( (decimal)(AV30gTTBUS_Estado), 1, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavGttbus_estado_Internalname, "Values", (String)(cmbavGttbus_estado.ToJavascriptSource()));
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            TempTags = " " + ((edtavGttbus_codposicion_Enabled!=0)&&(edtavGttbus_codposicion_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 77,'',false,'"+sGXsfl_61_idx+"',61)\"" : " ") ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavGttbus_codposicion_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(AV25gTTBUS_CodPosicion), 3, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)3,(short)0,(int)edtavGttbus_codposicion_Enabled,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(AV25gTTBUS_CodPosicion), "ZZ9"),TempTags+((edtavGttbus_codposicion_Enabled!=0)&&(edtavGttbus_codposicion_Visible!=0) ? " onchange=\"gx.evt.onchange(this)\" " : " ")+((edtavGttbus_codposicion_Enabled!=0)&&(edtavGttbus_codposicion_Visible!=0) ? " onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(77);\"" : " "),(short)0,(String)edtavGttbus_codposicion_Jsonclick,(String)"",(short)61,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            TempTags = " " + ((edtavGttbus_desposicion_Enabled!=0)&&(edtavGttbus_desposicion_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 78,'',false,'"+sGXsfl_61_idx+"',61)\"" : " ") ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavGttbus_desposicion_Internalname,StringUtil.RTrim( AV28gTTBUS_DesPosicion),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)50,(short)-1,(int)edtavGttbus_desposicion_Enabled,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( AV28gTTBUS_DesPosicion, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")),TempTags+((edtavGttbus_desposicion_Enabled!=0)&&(edtavGttbus_desposicion_Visible!=0) ? " onchange=\"gx.evt.onchange(this)\" " : " ")+((edtavGttbus_desposicion_Enabled!=0)&&(edtavGttbus_desposicion_Visible!=0) ? " onblur=\""+""+";gx.evt.onblur(78);\"" : " "),(short)0,(String)edtavGttbus_desposicion_Jsonclick,(String)"",(short)61,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            TempTags = " " + ((edtavSec_cre_Enabled!=0)&&(edtavSec_cre_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 79,'',false,'"+sGXsfl_61_idx+"',61)\"" : " ") ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavSec_cre_Internalname,StringUtil.RTrim( AV42SEC_CRE),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)15,(short)0,(int)edtavSec_cre_Enabled,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( AV42SEC_CRE, "XXXXXXXXXXXXXXX")),TempTags+((edtavSec_cre_Enabled!=0)&&(edtavSec_cre_Visible!=0) ? " onchange=\"gx.evt.onchange(this)\" " : " ")+((edtavSec_cre_Enabled!=0)&&(edtavSec_cre_Visible!=0) ? " onblur=\""+""+";gx.evt.onblur(79);\"" : " "),(short)0,(String)edtavSec_cre_Jsonclick,(String)"",(short)61,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            TempTags = " " + ((edtavSec_dre_Enabled!=0)&&(edtavSec_dre_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 80,'',false,'"+sGXsfl_61_idx+"',61)\"" : " ") ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavSec_dre_Internalname,StringUtil.RTrim( AV43SEC_DRE),(String)"",(short)150,(String)"px",(short)17,(String)"",(short)50,(short)-1,(int)edtavSec_dre_Enabled,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( AV43SEC_DRE, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")),TempTags+((edtavSec_dre_Enabled!=0)&&(edtavSec_dre_Visible!=0) ? " onchange=\"gx.evt.onchange(this)\" " : " ")+((edtavSec_dre_Enabled!=0)&&(edtavSec_dre_Visible!=0) ? " onblur=\""+""+";gx.evt.onblur(80);\"" : " "),(short)0,(String)edtavSec_dre_Jsonclick,(String)"",(short)61,(short)1,(short)1,(bool)true,(String)"left"});
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_61_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_61_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_61_idx+1)) ;
            sGXsfl_61_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_61_idx), 4, 0)), 4, "0") ;
            edtavBaja_Internalname = "vBAJA_"+sGXsfl_61_idx ;
            edtavEdicion_Internalname = "vEDICION_"+sGXsfl_61_idx ;
            edtavVisualizacion_Internalname = "vVISUALIZACION_"+sGXsfl_61_idx ;
            edtavGididentificador_Internalname = "vGIDIDENTIFICADOR_"+sGXsfl_61_idx ;
            edtavGnumeroidentificador_Internalname = "vGNUMEROIDENTIFICADOR_"+sGXsfl_61_idx ;
            edtavGttbus_id_Internalname = "vGTTBUS_ID_"+sGXsfl_61_idx ;
            edtavGttbus_descripcion_Internalname = "vGTTBUS_DESCRIPCION_"+sGXsfl_61_idx ;
            edtavGttbus_fechacarga_Internalname = "vGTTBUS_FECHACARGA_"+sGXsfl_61_idx ;
            edtavGttbus_rubrobien_Internalname = "vGTTBUS_RUBROBIEN_"+sGXsfl_61_idx ;
            edtavGttbus_rubrodesc_Internalname = "vGTTBUS_RUBRODESC_"+sGXsfl_61_idx ;
            edtavGttbus_fechabaja_Internalname = "vGTTBUS_FECHABAJA_"+sGXsfl_61_idx ;
            chkavGttbus_alquilado_Internalname = "vGTTBUS_ALQUILADO_"+sGXsfl_61_idx ;
            edtavGttbus_codproveedor_Internalname = "vGTTBUS_CODPROVEEDOR_"+sGXsfl_61_idx ;
            edtavGttbus_desproveedor_Internalname = "vGTTBUS_DESPROVEEDOR_"+sGXsfl_61_idx ;
            cmbavGttbus_estado_Internalname = "vGTTBUS_ESTADO_"+sGXsfl_61_idx ;
            edtavGttbus_codposicion_Internalname = "vGTTBUS_CODPOSICION_"+sGXsfl_61_idx ;
            edtavGttbus_desposicion_Internalname = "vGTTBUS_DESPOSICION_"+sGXsfl_61_idx ;
            edtavSec_cre_Internalname = "vSEC_CRE_"+sGXsfl_61_idx ;
            edtavSec_dre_Internalname = "vSEC_DRE_"+sGXsfl_61_idx ;
         }
         /* End function sendrow_612 */
      }

      protected void init_default_properties( )
      {
         lblTextblock10_Internalname = "TEXTBLOCK10" ;
         dynavFididentificador_Internalname = "vFIDIDENTIFICADOR" ;
         lblTextblock1_Internalname = "TEXTBLOCK1" ;
         edtavTtbus_id_Internalname = "vTTBUS_ID" ;
         lblTextblock9_Internalname = "TEXTBLOCK9" ;
         edtavFnumeroidentificador_Internalname = "vFNUMEROIDENTIFICADOR" ;
         lblTextblock8_Internalname = "TEXTBLOCK8" ;
         cmbavFttbus_estado_Internalname = "vFTTBUS_ESTADO" ;
         lblTextblock5_Internalname = "TEXTBLOCK5" ;
         edtavFttbus_descripcion_Internalname = "vFTTBUS_DESCRIPCION" ;
         lblTextblock7_Internalname = "TEXTBLOCK7" ;
         edtavTtbus_rubrobien_Internalname = "vTTBUS_RUBROBIEN" ;
         lblTextblock4_Internalname = "TEXTBLOCK4" ;
         cmbavTtbus7_pos_Internalname = "vTTBUS7_POS" ;
         lblTextblock6_Internalname = "TEXTBLOCK6" ;
         edtavTtbus_fechacarga_Internalname = "vTTBUS_FECHACARGA" ;
         bttButton3_Internalname = "BUTTON3" ;
         tblTable3_Internalname = "TABLE3" ;
         imgImg_alta_Internalname = "IMG_ALTA" ;
         bttButton1_Internalname = "BUTTON1" ;
         bttButton4_Internalname = "BUTTON4" ;
         lblTextblock2_Internalname = "TEXTBLOCK2" ;
         lblTextblock3_Internalname = "TEXTBLOCK3" ;
         lblTbxpantallacomp1_Internalname = "TBXPANTALLACOMP1" ;
         lblTbxpantallacomp2_Internalname = "TBXPANTALLACOMP2" ;
         tblTbl_movimientos_Internalname = "TBL_MOVIMIENTOS" ;
         tblTbl_tabs_Internalname = "TBL_TABS" ;
         tblTable1_Internalname = "TABLE1" ;
         Form.Internalname = "FORM" ;
         imgprompt_Ttbus_rubrobien_Internalname = "PROMPT_TTBUS_RUBROBIEN" ;
         subGrid1_Internalname = "GRID1" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         edtavSec_dre_Jsonclick = "" ;
         edtavSec_dre_Visible = -1 ;
         edtavSec_cre_Jsonclick = "" ;
         edtavSec_cre_Visible = 0 ;
         edtavGttbus_desposicion_Jsonclick = "" ;
         edtavGttbus_desposicion_Visible = -1 ;
         edtavGttbus_codposicion_Jsonclick = "" ;
         edtavGttbus_codposicion_Visible = 0 ;
         cmbavGttbus_estado_Jsonclick = "" ;
         cmbavGttbus_estado.Visible = -1 ;
         edtavGttbus_desproveedor_Jsonclick = "" ;
         edtavGttbus_desproveedor_Visible = 0 ;
         edtavGttbus_codproveedor_Jsonclick = "" ;
         edtavGttbus_codproveedor_Visible = 0 ;
         chkavGttbus_alquilado.Visible = -1 ;
         edtavGttbus_fechabaja_Jsonclick = "" ;
         edtavGttbus_fechabaja_Visible = 0 ;
         edtavGttbus_rubrodesc_Jsonclick = "" ;
         edtavGttbus_rubrodesc_Visible = -1 ;
         edtavGttbus_rubrobien_Jsonclick = "" ;
         edtavGttbus_rubrobien_Visible = 0 ;
         edtavGttbus_fechacarga_Jsonclick = "" ;
         edtavGttbus_fechacarga_Visible = -1 ;
         edtavGttbus_descripcion_Jsonclick = "" ;
         edtavGttbus_descripcion_Visible = -1 ;
         edtavGttbus_id_Jsonclick = "" ;
         edtavGttbus_id_Visible = -1 ;
         edtavGnumeroidentificador_Jsonclick = "" ;
         edtavGnumeroidentificador_Visible = -1 ;
         edtavGididentificador_Jsonclick = "" ;
         edtavGididentificador_Visible = 0 ;
         edtavVisualizacion_Jsonclick = "" ;
         edtavVisualizacion_Visible = -1 ;
         edtavVisualizacion_Enabled = 1 ;
         edtavEdicion_Jsonclick = "" ;
         edtavEdicion_Enabled = 1 ;
         edtavBaja_Jsonclick = "" ;
         edtavBaja_Enabled = 1 ;
         edtavTtbus_fechacarga_Jsonclick = "" ;
         cmbavTtbus7_pos_Jsonclick = "" ;
         imgprompt_Ttbus_rubrobien_Link = "" ;
         edtavTtbus_rubrobien_Jsonclick = "" ;
         edtavFttbus_descripcion_Jsonclick = "" ;
         cmbavFttbus_estado_Jsonclick = "" ;
         edtavFnumeroidentificador_Jsonclick = "" ;
         edtavTtbus_id_Jsonclick = "" ;
         dynavFididentificador_Jsonclick = "" ;
         lblTbxpantallacomp2_Linktarget = "" ;
         lblTbxpantallacomp2_Link = "" ;
         lblTbxpantallacomp1_Linktarget = "" ;
         lblTbxpantallacomp1_Link = "" ;
         subGrid1_Hoveringcolor = (int)(0x00C0C0) ;
         subGrid1_Selectioncolor = (int)(0x80FFFF) ;
         edtavSec_cre_Enabled = 1 ;
         edtavGttbus_desposicion_Enabled = 1 ;
         edtavGttbus_codposicion_Enabled = 1 ;
         cmbavGttbus_estado.Enabled = 1 ;
         edtavGttbus_desproveedor_Enabled = 1 ;
         edtavGttbus_codproveedor_Enabled = 1 ;
         chkavGttbus_alquilado.Enabled = 1 ;
         edtavGttbus_fechabaja_Enabled = 1 ;
         edtavGttbus_rubrodesc_Enabled = 1 ;
         edtavGttbus_rubrobien_Enabled = 1 ;
         edtavGttbus_fechacarga_Enabled = 1 ;
         edtavGttbus_descripcion_Enabled = 1 ;
         edtavGttbus_id_Enabled = 1 ;
         edtavGnumeroidentificador_Enabled = 1 ;
         edtavGididentificador_Enabled = 1 ;
         subGrid1_Class = "Grid" ;
         subGrid1_Backcolorstyle = 3 ;
         imgImg_alta_Visible = 1 ;
         tblTbl_movimientos_Visible = 1 ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Actualización de Bienes de Uso (Trazabilidad)" ;
         chkavGttbus_alquilado.Caption = "" ;
         edtavSec_dre_Enabled = 1 ;
         edtavBaja_Visible = -1 ;
         edtavEdicion_Visible = -1 ;
         context.GX_msglist.DisplayMode = 1 ;
      }

      protected void cleanup( )
      {
         flushBuffer();
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         wcpOAV45SISTEMA = "" ;
         wcpOAV62USUARIO = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         A12TTBUS_Descripcion = "" ;
         edtavEdicion_Internalname = "" ;
         edtavBaja_Internalname = "" ;
         edtavSec_dre_Internalname = "" ;
         edtavGididentificador_Internalname = "" ;
         edtavGnumeroidentificador_Internalname = "" ;
         edtavGttbus_id_Internalname = "" ;
         edtavGttbus_descripcion_Internalname = "" ;
         edtavGttbus_fechacarga_Internalname = "" ;
         edtavGttbus_rubrobien_Internalname = "" ;
         edtavGttbus_rubrodesc_Internalname = "" ;
         edtavGttbus_fechabaja_Internalname = "" ;
         chkavGttbus_alquilado_Internalname = "" ;
         edtavGttbus_codproveedor_Internalname = "" ;
         edtavGttbus_desproveedor_Internalname = "" ;
         cmbavGttbus_estado_Internalname = "" ;
         edtavGttbus_codposicion_Internalname = "" ;
         edtavGttbus_desposicion_Internalname = "" ;
         edtavSec_cre_Internalname = "" ;
         scmdbuf = "" ;
         H001M2_A20TTBUS5_IdIdentificador = new int[1] ;
         H001M2_A21TTBUS5_DescIdentificador = new String[] {""} ;
         AV15fTTBUS_Estado = 1 ;
         GXCCtl = "" ;
         AV30gTTBUS_Estado = 1 ;
         A7USU_DES = "" ;
         A6USU_COD = "" ;
         A25TTBUS2_RespHacia = "" ;
         A24TTBUS2_RespDesde = "" ;
         A36TTBUS7_DesResp = "" ;
         A35TTBUS7_CodResp = "" ;
         A18TTBUS_RubroDesc = "" ;
         A13TTBUS_FechaCarga = DateTime.MinValue ;
         A16TTBUS_FechaBaja = DateTime.MinValue ;
         A30TTBUS_DesProveedor = "" ;
         A38TTBUS_DesPosicion = "" ;
         A15NumeroIdentificador = "" ;
         AV13fNumeroIdentificador = "" ;
         sDynURL = "" ;
         FormProcess = "" ;
         GX_FocusControl = "" ;
         Form = new GXWebForm();
         sPrefix = "" ;
         OldWc_bienes_a_recibir = "" ;
         WebComp_Wc_bienes_a_recibir_Component = "" ;
         OldWc_bienes_enviados = "" ;
         WebComp_Wc_bienes_enviados_Component = "" ;
         OldWc_tabs = "" ;
         WebComp_Wc_tabs_Component = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         edtavVisualizacion_Internalname = "" ;
         AV5baja = "" ;
         AV11edicion = "" ;
         AV63visualizacion = "" ;
         AV23gNumeroIdentificador = "" ;
         AV27gTTBUS_Descripcion = "" ;
         AV32gTTBUS_FechaCarga = DateTime.MinValue ;
         AV35gTTBUS_RubroDesc = "" ;
         AV31gTTBUS_FechaBaja = DateTime.MinValue ;
         AV29gTTBUS_DesProveedor = "" ;
         AV28gTTBUS_DesPosicion = "" ;
         AV42SEC_CRE = "" ;
         AV43SEC_DRE = "" ;
         H001M3_A20TTBUS5_IdIdentificador = new int[1] ;
         H001M3_A21TTBUS5_DescIdentificador = new String[] {""} ;
         gxdynajaxctrlcodr = new GeneXus.Utils.GxStringCollection();
         gxdynajaxctrldescr = new GeneXus.Utils.GxStringCollection();
         gxwrpcisep = "" ;
         l12TTBUS_Descripcion = "" ;
         H001M4_A12TTBUS_Descripcion = new String[] {""} ;
         H001M5_A12TTBUS_Descripcion = new String[] {""} ;
         Grid1Container = new GXWebGrid( context);
         AV14fTTBUS_Descripcion = "" ;
         AV54TTBUS_FechaCarga = DateTime.MinValue ;
         AV9Context = new SdtContext(context);
         AV44SESION = new GxWebSession( context);
         AV65window = new GXWindow();
         AV17gBUS_EMP = "" ;
         AV40NumeroIdentificador = "" ;
         AV52TTBUS_Descripcion = "" ;
         lV52TTBUS_Descripcion = "" ;
         lV40NumeroIdentificador = "" ;
         H001M6_A11TTBUS_Id = new int[1] ;
         H001M6_A37TTBUS_CodPosicion = new short[1] ;
         H001M6_A35TTBUS7_CodResp = new String[] {""} ;
         H001M6_n35TTBUS7_CodResp = new bool[] {false} ;
         H001M6_A36TTBUS7_DesResp = new String[] {""} ;
         H001M6_n36TTBUS7_DesResp = new bool[] {false} ;
         H001M6_A15NumeroIdentificador = new String[] {""} ;
         H001M6_A14IdIdentificador = new int[1] ;
         H001M6_A23TTBUS_Estado = new short[1] ;
         H001M6_A17TTBUS_RubroBien = new short[1] ;
         H001M6_A13TTBUS_FechaCarga = new DateTime[] {DateTime.MinValue} ;
         H001M6_A12TTBUS_Descripcion = new String[] {""} ;
         H001M6_A16TTBUS_FechaBaja = new DateTime[] {DateTime.MinValue} ;
         H001M6_n16TTBUS_FechaBaja = new bool[] {false} ;
         H001M6_A29TTBUS_Alquilado = new short[1] ;
         H001M6_A27TTBUS_CodProveedor = new int[1] ;
         H001M6_n27TTBUS_CodProveedor = new bool[] {false} ;
         H001M6_A38TTBUS_DesPosicion = new String[] {""} ;
         H001M6_A30TTBUS_DesProveedor = new String[] {""} ;
         H001M6_n30TTBUS_DesProveedor = new bool[] {false} ;
         H001M6_A18TTBUS_RubroDesc = new String[] {""} ;
         H001M6_n18TTBUS_RubroDesc = new bool[] {false} ;
         H001M7_A33TTBUS7_Pos = new short[1] ;
         H001M8_A52TTBUS2_IdMovimiento = new long[1] ;
         H001M8_A22TTBUS2_IdBien = new int[1] ;
         H001M8_A26TTBUS2_EstadoEnvio = new short[1] ;
         H001M8_A24TTBUS2_RespDesde = new String[] {""} ;
         H001M8_A25TTBUS2_RespHacia = new String[] {""} ;
         AV57TTBUS2_RespDesde = "" ;
         AV58TTBUS2_RespHacia = "" ;
         AV10dUSU_DES = "" ;
         AV36hUSU_DES = "" ;
         H001M9_A11TTBUS_Id = new int[1] ;
         H001M9_A37TTBUS_CodPosicion = new short[1] ;
         H001M9_A35TTBUS7_CodResp = new String[] {""} ;
         H001M9_n35TTBUS7_CodResp = new bool[] {false} ;
         H001M9_A36TTBUS7_DesResp = new String[] {""} ;
         H001M9_n36TTBUS7_DesResp = new bool[] {false} ;
         H001M9_A15NumeroIdentificador = new String[] {""} ;
         H001M9_A14IdIdentificador = new int[1] ;
         H001M9_A23TTBUS_Estado = new short[1] ;
         H001M9_A17TTBUS_RubroBien = new short[1] ;
         H001M9_A13TTBUS_FechaCarga = new DateTime[] {DateTime.MinValue} ;
         H001M9_A12TTBUS_Descripcion = new String[] {""} ;
         H001M9_A16TTBUS_FechaBaja = new DateTime[] {DateTime.MinValue} ;
         H001M9_n16TTBUS_FechaBaja = new bool[] {false} ;
         H001M9_A29TTBUS_Alquilado = new short[1] ;
         H001M9_A27TTBUS_CodProveedor = new int[1] ;
         H001M9_n27TTBUS_CodProveedor = new bool[] {false} ;
         H001M9_A38TTBUS_DesPosicion = new String[] {""} ;
         H001M9_A30TTBUS_DesProveedor = new String[] {""} ;
         H001M9_n30TTBUS_DesProveedor = new bool[] {false} ;
         H001M9_A18TTBUS_RubroDesc = new String[] {""} ;
         H001M9_n18TTBUS_RubroDesc = new bool[] {false} ;
         H001M10_A33TTBUS7_Pos = new short[1] ;
         H001M11_A52TTBUS2_IdMovimiento = new long[1] ;
         H001M11_A22TTBUS2_IdBien = new int[1] ;
         H001M11_A26TTBUS2_EstadoEnvio = new short[1] ;
         H001M11_A24TTBUS2_RespDesde = new String[] {""} ;
         H001M11_A25TTBUS2_RespHacia = new String[] {""} ;
         AV38NOMBRE_REPORTE = "" ;
         H001M12_A40TTBUS8_CodUsuario = new String[] {""} ;
         A40TTBUS8_CodUsuario = "" ;
         H001M13_A31W53POS = new short[1] ;
         H001M13_A32W53DES = new String[] {""} ;
         A32W53DES = "" ;
         H001M14_A33TTBUS7_Pos = new short[1] ;
         H001M14_A34TTBUS7_Des = new String[] {""} ;
         H001M14_n34TTBUS7_Des = new bool[] {false} ;
         A34TTBUS7_Des = "" ;
         H001M15_A31W53POS = new short[1] ;
         H001M15_A32W53DES = new String[] {""} ;
         H001M16_A33TTBUS7_Pos = new short[1] ;
         H001M16_A34TTBUS7_Des = new String[] {""} ;
         H001M16_n34TTBUS7_Des = new bool[] {false} ;
         H001M16_A35TTBUS7_CodResp = new String[] {""} ;
         H001M16_n35TTBUS7_CodResp = new bool[] {false} ;
         H001M17_A39TTBUS7_CodUsuario = new String[] {""} ;
         H001M17_A33TTBUS7_Pos = new short[1] ;
         A39TTBUS7_CodUsuario = "" ;
         H001M18_A6USU_COD = new String[] {""} ;
         H001M18_A7USU_DES = new String[] {""} ;
         H001M19_A6USU_COD = new String[] {""} ;
         H001M19_A7USU_DES = new String[] {""} ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         TempTags = "" ;
         imgImg_alta_Jsonclick = "" ;
         subGrid1_Linesclass = "" ;
         GXt_char3 = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GXt_char4 = "" ;
         GXt_char5 = "" ;
         GXt_char6 = "" ;
         GXt_char7 = "" ;
         GXt_char8 = "" ;
         GXt_char9 = "" ;
         GXt_char10 = "" ;
         GXt_char11 = "" ;
         GXt_char12 = "" ;
         GXt_char13 = "" ;
         GXt_char14 = "" ;
         GXt_char15 = "" ;
         GXt_char16 = "" ;
         GXt_char17 = "" ;
         Grid1Column = new GXWebColumn();
         bttButton1_Jsonclick = "" ;
         bttButton4_Jsonclick = "" ;
         lblTextblock2_Jsonclick = "" ;
         lblTextblock3_Jsonclick = "" ;
         lblTbxpantallacomp1_Jsonclick = "" ;
         lblTbxpantallacomp2_Jsonclick = "" ;
         lblTextblock10_Jsonclick = "" ;
         lblTextblock1_Jsonclick = "" ;
         lblTextblock9_Jsonclick = "" ;
         lblTextblock8_Jsonclick = "" ;
         lblTextblock5_Jsonclick = "" ;
         lblTextblock7_Jsonclick = "" ;
         lblTextblock4_Jsonclick = "" ;
         lblTextblock6_Jsonclick = "" ;
         GXt_char18 = "" ;
         bttButton3_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         Grid1Row = new GXWebRow();
         ROClassString = "" ;
         GXt_char19 = "" ;
         GXt_char20 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.htbus001__default(),
            new Object[][] {
                new Object[] {
               H001M2_A20TTBUS5_IdIdentificador, H001M2_A21TTBUS5_DescIdentificador
               }
               , new Object[] {
               H001M3_A20TTBUS5_IdIdentificador, H001M3_A21TTBUS5_DescIdentificador
               }
               , new Object[] {
               H001M4_A12TTBUS_Descripcion
               }
               , new Object[] {
               H001M5_A12TTBUS_Descripcion
               }
               , new Object[] {
               H001M6_A11TTBUS_Id, H001M6_A37TTBUS_CodPosicion, H001M6_A35TTBUS7_CodResp, H001M6_n35TTBUS7_CodResp, H001M6_A36TTBUS7_DesResp, H001M6_n36TTBUS7_DesResp, H001M6_A15NumeroIdentificador, H001M6_A14IdIdentificador, H001M6_A23TTBUS_Estado, H001M6_A17TTBUS_RubroBien,
               H001M6_A13TTBUS_FechaCarga, H001M6_A12TTBUS_Descripcion, H001M6_A16TTBUS_FechaBaja, H001M6_n16TTBUS_FechaBaja, H001M6_A29TTBUS_Alquilado, H001M6_A27TTBUS_CodProveedor, H001M6_n27TTBUS_CodProveedor, H001M6_A38TTBUS_DesPosicion, H001M6_A30TTBUS_DesProveedor, H001M6_n30TTBUS_DesProveedor,
               H001M6_A18TTBUS_RubroDesc, H001M6_n18TTBUS_RubroDesc
               }
               , new Object[] {
               H001M7_A33TTBUS7_Pos
               }
               , new Object[] {
               H001M8_A52TTBUS2_IdMovimiento, H001M8_A22TTBUS2_IdBien, H001M8_A26TTBUS2_EstadoEnvio, H001M8_A24TTBUS2_RespDesde, H001M8_A25TTBUS2_RespHacia
               }
               , new Object[] {
               H001M9_A11TTBUS_Id, H001M9_A37TTBUS_CodPosicion, H001M9_A35TTBUS7_CodResp, H001M9_n35TTBUS7_CodResp, H001M9_A36TTBUS7_DesResp, H001M9_n36TTBUS7_DesResp, H001M9_A15NumeroIdentificador, H001M9_A14IdIdentificador, H001M9_A23TTBUS_Estado, H001M9_A17TTBUS_RubroBien,
               H001M9_A13TTBUS_FechaCarga, H001M9_A12TTBUS_Descripcion, H001M9_A16TTBUS_FechaBaja, H001M9_n16TTBUS_FechaBaja, H001M9_A29TTBUS_Alquilado, H001M9_A27TTBUS_CodProveedor, H001M9_n27TTBUS_CodProveedor, H001M9_A38TTBUS_DesPosicion, H001M9_A30TTBUS_DesProveedor, H001M9_n30TTBUS_DesProveedor,
               H001M9_A18TTBUS_RubroDesc, H001M9_n18TTBUS_RubroDesc
               }
               , new Object[] {
               H001M10_A33TTBUS7_Pos
               }
               , new Object[] {
               H001M11_A52TTBUS2_IdMovimiento, H001M11_A22TTBUS2_IdBien, H001M11_A26TTBUS2_EstadoEnvio, H001M11_A24TTBUS2_RespDesde, H001M11_A25TTBUS2_RespHacia
               }
               , new Object[] {
               H001M12_A40TTBUS8_CodUsuario
               }
               , new Object[] {
               H001M13_A31W53POS, H001M13_A32W53DES
               }
               , new Object[] {
               H001M14_A33TTBUS7_Pos, H001M14_A34TTBUS7_Des, H001M14_n34TTBUS7_Des
               }
               , new Object[] {
               H001M15_A31W53POS, H001M15_A32W53DES
               }
               , new Object[] {
               H001M16_A33TTBUS7_Pos, H001M16_A34TTBUS7_Des, H001M16_n34TTBUS7_Des, H001M16_A35TTBUS7_CodResp
               }
               , new Object[] {
               H001M17_A39TTBUS7_CodUsuario, H001M17_A33TTBUS7_Pos
               }
               , new Object[] {
               H001M18_A6USU_COD, H001M18_A7USU_DES
               }
               , new Object[] {
               H001M19_A6USU_COD, H001M19_A7USU_DES
               }
            }
         );
         WebComp_Wc_bienes_a_recibir = new GeneXus.Http.GXNullWebComponent();
         WebComp_Wc_bienes_enviados = new GeneXus.Http.GXNullWebComponent();
         WebComp_Wc_tabs = new GeneXus.Http.GXNullWebComponent();
         AV12fIdIdentificador = 1 ;
         AV15fTTBUS_Estado = 0 ;
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
         edtavGididentificador_Enabled = 0 ;
         edtavGnumeroidentificador_Enabled = 0 ;
         edtavGttbus_id_Enabled = 0 ;
         edtavGttbus_descripcion_Enabled = 0 ;
         edtavGttbus_fechacarga_Enabled = 0 ;
         edtavGttbus_rubrobien_Enabled = 0 ;
         edtavGttbus_rubrodesc_Enabled = 0 ;
         edtavGttbus_fechabaja_Enabled = 0 ;
         chkavGttbus_alquilado.Enabled = 0 ;
         edtavGttbus_codproveedor_Enabled = 0 ;
         edtavGttbus_desproveedor_Enabled = 0 ;
         cmbavGttbus_estado.Enabled = 0 ;
         edtavGttbus_codposicion_Enabled = 0 ;
         edtavGttbus_desposicion_Enabled = 0 ;
         edtavSec_cre_Enabled = 0 ;
         edtavSec_dre_Enabled = 0 ;
         imgprompt_Ttbus_rubrobien_Link = "javascript:"+"gx.popup.openPrompt('"+"htbus_rub.aspx"+"',["+"{Ctrl:gx.dom.el('"+"vTTBUS_RUBROBIEN"+"'), id:'"+"vTTBUS_RUBROBIEN"+"'"+",isOut:true,isKey:false,isLastKey:false}"+"],"+"null"+","+"'', false"+","+"false"+","+"false"+");" ;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_Grid1 ;
      private short nGXsfl_61_idx=1 ;
      private short AV15fTTBUS_Estado ;
      private short AV60TTBUS7_Pos ;
      private short AV30gTTBUS_Estado ;
      private short AV8band_2 ;
      private short A33TTBUS7_Pos ;
      private short A17TTBUS_RubroBien ;
      private short A23TTBUS_Estado ;
      private short A37TTBUS_CodPosicion ;
      private short A29TTBUS_Alquilado ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short GRID1_nEOF ;
      private short wbEnd ;
      private short wbStart ;
      private short AV34gTTBUS_RubroBien ;
      private short AV24gTTBUS_Alquilado ;
      private short AV25gTTBUS_CodPosicion ;
      private short nCmpId ;
      private short nDonePA ;
      private short subGrid1_Rows ;
      private short AV56TTBUS_RubroBien ;
      private short AV37inicio ;
      private short AV61usu_permiso ;
      private short AV50TTBUS_CodPosicion ;
      private short AV7band_1 ;
      private short AV19gBUS_RUB ;
      private short AV16gBUS_COD ;
      private short AV18gBUS_PAR ;
      private short AV20gHARDWARE_ID ;
      private short A26TTBUS2_EstadoEnvio ;
      private short AV6band ;
      private short A31W53POS ;
      private short AV64vTTBUS7_Pos ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short subGrid1_Collapsed ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int edtavEdicion_Visible ;
      private int edtavBaja_Visible ;
      private int edtavSec_dre_Enabled ;
      private int Grid1_PageSize61 ;
      private int edtavGididentificador_Enabled ;
      private int edtavGnumeroidentificador_Enabled ;
      private int edtavGttbus_id_Enabled ;
      private int edtavGttbus_descripcion_Enabled ;
      private int edtavGttbus_fechacarga_Enabled ;
      private int edtavGttbus_rubrobien_Enabled ;
      private int edtavGttbus_rubrodesc_Enabled ;
      private int edtavGttbus_fechabaja_Enabled ;
      private int edtavGttbus_codproveedor_Enabled ;
      private int edtavGttbus_desproveedor_Enabled ;
      private int edtavGttbus_codposicion_Enabled ;
      private int edtavGttbus_desposicion_Enabled ;
      private int edtavSec_cre_Enabled ;
      private int AV12fIdIdentificador ;
      private int A14IdIdentificador ;
      private int A11TTBUS_Id ;
      private int A27TTBUS_CodProveedor ;
      private int GRID1_nFirstRecordOnPage ;
      private int AV22gIdIdentificador ;
      private int AV33gTTBUS_ID ;
      private int AV26gTTBUS_CodProveedor ;
      private int gxdynajaxindex ;
      private int subGrid1_Islastpage ;
      private int AV55TTBUS_Id ;
      private int imgImg_alta_Visible ;
      private int tblTbl_movimientos_Visible ;
      private int A22TTBUS2_IdBien ;
      private int GRID1_nCurrentRecord ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int subGrid1_Selectioncolor ;
      private int subGrid1_Hoveringcolor ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private int edtavBaja_Enabled ;
      private int edtavEdicion_Enabled ;
      private int edtavVisualizacion_Enabled ;
      private int edtavVisualizacion_Visible ;
      private int edtavGididentificador_Visible ;
      private int edtavGnumeroidentificador_Visible ;
      private int edtavGttbus_id_Visible ;
      private int edtavGttbus_descripcion_Visible ;
      private int edtavGttbus_fechacarga_Visible ;
      private int edtavGttbus_rubrobien_Visible ;
      private int edtavGttbus_rubrodesc_Visible ;
      private int edtavGttbus_fechabaja_Visible ;
      private int edtavGttbus_codproveedor_Visible ;
      private int edtavGttbus_desproveedor_Visible ;
      private int edtavGttbus_codposicion_Visible ;
      private int edtavGttbus_desposicion_Visible ;
      private int edtavSec_cre_Visible ;
      private int edtavSec_dre_Visible ;
      private String AV45SISTEMA ;
      private String AV62USUARIO ;
      private String wcpOAV45SISTEMA ;
      private String wcpOAV62USUARIO ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_61_idx="0001" ;
      private String edtavEdicion_Internalname ;
      private String edtavBaja_Internalname ;
      private String edtavSec_dre_Internalname ;
      private String edtavGididentificador_Internalname ;
      private String edtavGnumeroidentificador_Internalname ;
      private String edtavGttbus_id_Internalname ;
      private String edtavGttbus_descripcion_Internalname ;
      private String edtavGttbus_fechacarga_Internalname ;
      private String edtavGttbus_rubrobien_Internalname ;
      private String edtavGttbus_rubrodesc_Internalname ;
      private String edtavGttbus_fechabaja_Internalname ;
      private String chkavGttbus_alquilado_Internalname ;
      private String edtavGttbus_codproveedor_Internalname ;
      private String edtavGttbus_desproveedor_Internalname ;
      private String cmbavGttbus_estado_Internalname ;
      private String edtavGttbus_codposicion_Internalname ;
      private String edtavGttbus_desposicion_Internalname ;
      private String edtavSec_cre_Internalname ;
      private String scmdbuf ;
      private String GXCCtl ;
      private String A7USU_DES ;
      private String A6USU_COD ;
      private String A25TTBUS2_RespHacia ;
      private String A24TTBUS2_RespDesde ;
      private String A36TTBUS7_DesResp ;
      private String A35TTBUS7_CodResp ;
      private String A18TTBUS_RubroDesc ;
      private String A30TTBUS_DesProveedor ;
      private String A38TTBUS_DesPosicion ;
      private String sDynURL ;
      private String FormProcess ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String OldWc_bienes_a_recibir ;
      private String WebComp_Wc_bienes_a_recibir_Component ;
      private String OldWc_bienes_enviados ;
      private String WebComp_Wc_bienes_enviados_Component ;
      private String OldWc_tabs ;
      private String WebComp_Wc_tabs_Component ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavVisualizacion_Internalname ;
      private String AV35gTTBUS_RubroDesc ;
      private String AV29gTTBUS_DesProveedor ;
      private String AV28gTTBUS_DesPosicion ;
      private String AV42SEC_CRE ;
      private String AV43SEC_DRE ;
      private String dynavFididentificador_Internalname ;
      private String gxwrpcisep ;
      private String imgprompt_Ttbus_rubrobien_Link ;
      private String edtavTtbus_id_Internalname ;
      private String edtavFnumeroidentificador_Internalname ;
      private String cmbavFttbus_estado_Internalname ;
      private String edtavFttbus_descripcion_Internalname ;
      private String edtavTtbus_rubrobien_Internalname ;
      private String cmbavTtbus7_pos_Internalname ;
      private String edtavTtbus_fechacarga_Internalname ;
      private String subGrid1_Internalname ;
      private String imgImg_alta_Internalname ;
      private String tblTbl_movimientos_Internalname ;
      private String lblTbxpantallacomp1_Link ;
      private String lblTbxpantallacomp1_Internalname ;
      private String lblTbxpantallacomp1_Linktarget ;
      private String lblTbxpantallacomp2_Link ;
      private String lblTbxpantallacomp2_Internalname ;
      private String lblTbxpantallacomp2_Linktarget ;
      private String AV17gBUS_EMP ;
      private String AV57TTBUS2_RespDesde ;
      private String AV58TTBUS2_RespHacia ;
      private String AV10dUSU_DES ;
      private String AV36hUSU_DES ;
      private String AV38NOMBRE_REPORTE ;
      private String A40TTBUS8_CodUsuario ;
      private String A32W53DES ;
      private String A34TTBUS7_Des ;
      private String A39TTBUS7_CodUsuario ;
      private String sStyleString ;
      private String tblTable1_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String TempTags ;
      private String imgImg_alta_Jsonclick ;
      private String subGrid1_Class ;
      private String subGrid1_Linesclass ;
      private String GXt_char3 ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String GXt_char4 ;
      private String GXt_char5 ;
      private String GXt_char6 ;
      private String GXt_char7 ;
      private String GXt_char8 ;
      private String GXt_char9 ;
      private String GXt_char10 ;
      private String GXt_char11 ;
      private String GXt_char12 ;
      private String GXt_char13 ;
      private String GXt_char14 ;
      private String GXt_char15 ;
      private String GXt_char16 ;
      private String GXt_char17 ;
      private String bttButton1_Internalname ;
      private String bttButton1_Jsonclick ;
      private String bttButton4_Internalname ;
      private String bttButton4_Jsonclick ;
      private String tblTbl_tabs_Internalname ;
      private String lblTextblock2_Internalname ;
      private String lblTextblock2_Jsonclick ;
      private String lblTextblock3_Internalname ;
      private String lblTextblock3_Jsonclick ;
      private String lblTbxpantallacomp1_Jsonclick ;
      private String lblTbxpantallacomp2_Jsonclick ;
      private String tblTable3_Internalname ;
      private String lblTextblock10_Internalname ;
      private String lblTextblock10_Jsonclick ;
      private String dynavFididentificador_Jsonclick ;
      private String lblTextblock1_Internalname ;
      private String lblTextblock1_Jsonclick ;
      private String edtavTtbus_id_Jsonclick ;
      private String lblTextblock9_Internalname ;
      private String lblTextblock9_Jsonclick ;
      private String edtavFnumeroidentificador_Jsonclick ;
      private String lblTextblock8_Internalname ;
      private String lblTextblock8_Jsonclick ;
      private String cmbavFttbus_estado_Jsonclick ;
      private String lblTextblock5_Internalname ;
      private String lblTextblock5_Jsonclick ;
      private String edtavFttbus_descripcion_Jsonclick ;
      private String lblTextblock7_Internalname ;
      private String lblTextblock7_Jsonclick ;
      private String edtavTtbus_rubrobien_Jsonclick ;
      private String imgprompt_Ttbus_rubrobien_Internalname ;
      private String lblTextblock4_Internalname ;
      private String lblTextblock4_Jsonclick ;
      private String cmbavTtbus7_pos_Jsonclick ;
      private String lblTextblock6_Internalname ;
      private String lblTextblock6_Jsonclick ;
      private String edtavTtbus_fechacarga_Jsonclick ;
      private String GXt_char18 ;
      private String bttButton3_Internalname ;
      private String bttButton3_Jsonclick ;
      private String edtavBaja_Jsonclick ;
      private String edtavEdicion_Jsonclick ;
      private String edtavVisualizacion_Jsonclick ;
      private String ROClassString ;
      private String edtavGididentificador_Jsonclick ;
      private String edtavGnumeroidentificador_Jsonclick ;
      private String edtavGttbus_id_Jsonclick ;
      private String edtavGttbus_descripcion_Jsonclick ;
      private String edtavGttbus_fechacarga_Jsonclick ;
      private String edtavGttbus_rubrobien_Jsonclick ;
      private String edtavGttbus_rubrodesc_Jsonclick ;
      private String edtavGttbus_fechabaja_Jsonclick ;
      private String edtavGttbus_codproveedor_Jsonclick ;
      private String edtavGttbus_desproveedor_Jsonclick ;
      private String cmbavGttbus_estado_Jsonclick ;
      private String edtavGttbus_codposicion_Jsonclick ;
      private String edtavGttbus_desposicion_Jsonclick ;
      private String edtavSec_cre_Jsonclick ;
      private String GXt_char19 ;
      private String edtavSec_dre_Jsonclick ;
      private String GXt_char20 ;
      private DateTime A13TTBUS_FechaCarga ;
      private DateTime A16TTBUS_FechaBaja ;
      private DateTime AV32gTTBUS_FechaCarga ;
      private DateTime AV31gTTBUS_FechaBaja ;
      private DateTime AV54TTBUS_FechaCarga ;
      private bool entryPointCalled ;
      private bool n36TTBUS7_DesResp ;
      private bool n35TTBUS7_CodResp ;
      private bool n18TTBUS_RubroDesc ;
      private bool n16TTBUS_FechaBaja ;
      private bool n30TTBUS_DesProveedor ;
      private bool n27TTBUS_CodProveedor ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private bool n34TTBUS7_Des ;
      private bool BRK1M13 ;
      private String A12TTBUS_Descripcion ;
      private String A15NumeroIdentificador ;
      private String AV13fNumeroIdentificador ;
      private String AV23gNumeroIdentificador ;
      private String AV27gTTBUS_Descripcion ;
      private String l12TTBUS_Descripcion ;
      private String AV14fTTBUS_Descripcion ;
      private String AV40NumeroIdentificador ;
      private String AV52TTBUS_Descripcion ;
      private String lV52TTBUS_Descripcion ;
      private String lV40NumeroIdentificador ;
      private String AV5baja ;
      private String AV11edicion ;
      private String AV63visualizacion ;
      private GxWebSession AV44SESION ;
      private GXWebComponent WebComp_Wc_bienes_a_recibir ;
      private GXWebComponent WebComp_Wc_bienes_enviados ;
      private GXWebComponent WebComp_Wc_tabs ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private String aP0_SISTEMA ;
      private String aP1_USUARIO ;
      private GXCombobox dynavFididentificador ;
      private GXCombobox cmbavFttbus_estado ;
      private GXCombobox cmbavTtbus7_pos ;
      private GXCheckbox chkavGttbus_alquilado ;
      private GXCombobox cmbavGttbus_estado ;
      private IDataStoreProvider pr_default ;
      private int[] H001M2_A20TTBUS5_IdIdentificador ;
      private String[] H001M2_A21TTBUS5_DescIdentificador ;
      private int[] H001M3_A20TTBUS5_IdIdentificador ;
      private String[] H001M3_A21TTBUS5_DescIdentificador ;
      private String[] H001M4_A12TTBUS_Descripcion ;
      private String[] H001M5_A12TTBUS_Descripcion ;
      private int[] H001M6_A11TTBUS_Id ;
      private short[] H001M6_A37TTBUS_CodPosicion ;
      private String[] H001M6_A35TTBUS7_CodResp ;
      private bool[] H001M6_n35TTBUS7_CodResp ;
      private String[] H001M6_A36TTBUS7_DesResp ;
      private bool[] H001M6_n36TTBUS7_DesResp ;
      private String[] H001M6_A15NumeroIdentificador ;
      private int[] H001M6_A14IdIdentificador ;
      private short[] H001M6_A23TTBUS_Estado ;
      private short[] H001M6_A17TTBUS_RubroBien ;
      private DateTime[] H001M6_A13TTBUS_FechaCarga ;
      private String[] H001M6_A12TTBUS_Descripcion ;
      private DateTime[] H001M6_A16TTBUS_FechaBaja ;
      private bool[] H001M6_n16TTBUS_FechaBaja ;
      private short[] H001M6_A29TTBUS_Alquilado ;
      private int[] H001M6_A27TTBUS_CodProveedor ;
      private bool[] H001M6_n27TTBUS_CodProveedor ;
      private String[] H001M6_A38TTBUS_DesPosicion ;
      private String[] H001M6_A30TTBUS_DesProveedor ;
      private bool[] H001M6_n30TTBUS_DesProveedor ;
      private String[] H001M6_A18TTBUS_RubroDesc ;
      private bool[] H001M6_n18TTBUS_RubroDesc ;
      private short[] H001M7_A33TTBUS7_Pos ;
      private long[] H001M8_A52TTBUS2_IdMovimiento ;
      private int[] H001M8_A22TTBUS2_IdBien ;
      private short[] H001M8_A26TTBUS2_EstadoEnvio ;
      private String[] H001M8_A24TTBUS2_RespDesde ;
      private String[] H001M8_A25TTBUS2_RespHacia ;
      private int[] H001M9_A11TTBUS_Id ;
      private short[] H001M9_A37TTBUS_CodPosicion ;
      private String[] H001M9_A35TTBUS7_CodResp ;
      private bool[] H001M9_n35TTBUS7_CodResp ;
      private String[] H001M9_A36TTBUS7_DesResp ;
      private bool[] H001M9_n36TTBUS7_DesResp ;
      private String[] H001M9_A15NumeroIdentificador ;
      private int[] H001M9_A14IdIdentificador ;
      private short[] H001M9_A23TTBUS_Estado ;
      private short[] H001M9_A17TTBUS_RubroBien ;
      private DateTime[] H001M9_A13TTBUS_FechaCarga ;
      private String[] H001M9_A12TTBUS_Descripcion ;
      private DateTime[] H001M9_A16TTBUS_FechaBaja ;
      private bool[] H001M9_n16TTBUS_FechaBaja ;
      private short[] H001M9_A29TTBUS_Alquilado ;
      private int[] H001M9_A27TTBUS_CodProveedor ;
      private bool[] H001M9_n27TTBUS_CodProveedor ;
      private String[] H001M9_A38TTBUS_DesPosicion ;
      private String[] H001M9_A30TTBUS_DesProveedor ;
      private bool[] H001M9_n30TTBUS_DesProveedor ;
      private String[] H001M9_A18TTBUS_RubroDesc ;
      private bool[] H001M9_n18TTBUS_RubroDesc ;
      private short[] H001M10_A33TTBUS7_Pos ;
      private long[] H001M11_A52TTBUS2_IdMovimiento ;
      private int[] H001M11_A22TTBUS2_IdBien ;
      private short[] H001M11_A26TTBUS2_EstadoEnvio ;
      private String[] H001M11_A24TTBUS2_RespDesde ;
      private String[] H001M11_A25TTBUS2_RespHacia ;
      private String[] H001M12_A40TTBUS8_CodUsuario ;
      private short[] H001M13_A31W53POS ;
      private String[] H001M13_A32W53DES ;
      private short[] H001M14_A33TTBUS7_Pos ;
      private String[] H001M14_A34TTBUS7_Des ;
      private bool[] H001M14_n34TTBUS7_Des ;
      private short[] H001M15_A31W53POS ;
      private String[] H001M15_A32W53DES ;
      private short[] H001M16_A33TTBUS7_Pos ;
      private String[] H001M16_A34TTBUS7_Des ;
      private bool[] H001M16_n34TTBUS7_Des ;
      private String[] H001M16_A35TTBUS7_CodResp ;
      private bool[] H001M16_n35TTBUS7_CodResp ;
      private String[] H001M17_A39TTBUS7_CodUsuario ;
      private short[] H001M17_A33TTBUS7_Pos ;
      private String[] H001M18_A6USU_COD ;
      private String[] H001M18_A7USU_DES ;
      private String[] H001M19_A6USU_COD ;
      private String[] H001M19_A7USU_DES ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXWebForm Form ;
      private GXWindow AV65window ;
      private SdtContext AV9Context ;
   }

   public class htbus001__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H001M6( short AV60TTBUS7_Pos ,
                                             String AV14fTTBUS_Descripcion ,
                                             DateTime AV54TTBUS_FechaCarga ,
                                             short AV56TTBUS_RubroBien ,
                                             short AV15fTTBUS_Estado ,
                                             String AV13fNumeroIdentificador ,
                                             short A37TTBUS_CodPosicion ,
                                             String A12TTBUS_Descripcion ,
                                             String AV52TTBUS_Descripcion ,
                                             DateTime A13TTBUS_FechaCarga ,
                                             short A17TTBUS_RubroBien ,
                                             short A23TTBUS_Estado ,
                                             String A15NumeroIdentificador ,
                                             String AV40NumeroIdentificador ,
                                             int A11TTBUS_Id ,
                                             int AV55TTBUS_Id ,
                                             DateTime A16TTBUS_FechaBaja ,
                                             int A14IdIdentificador ,
                                             int AV12fIdIdentificador )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int21 ;
         GXv_int21 = new short [8] ;
         Object[] GXv_Object22 ;
         GXv_Object22 = new Object [2] ;
         scmdbuf = "SELECT T1.[TTBUS_Id], T2.[TTBUS_CodPosicion] AS TTBUS_CodPosicion, T3.[TTBUS7_CodResp] AS TTBUS7_CodResp, T4.[USU_DES] AS TTBUS7_DesResp, T1.[NumeroIdentificador], T1.[IdIdentificador], T2.[TTBUS_Estado], T2.[TTBUS_RubroBien] AS TTBUS_RubroBien, T2.[TTBUS_FechaCarga], T2.[TTBUS_Descripcion], T2.[TTBUS_FechaBaja], T2.[TTBUS_Alquilado], T2.[TTBUS_CodProveedor] AS TTBUS_CodProveedor, T2.[TTBUS_DesPosicion], T6.[PV_DESC] AS TTBUS_DesProveedor, T5.[RBR_DES] AS TTBUS_RubroDesc FROM ((((([TTBUS000Identificadores] T1 WITH (NOLOCK) INNER JOIN [TTBUS000] T2 WITH (NOLOCK) ON T2.[TTBUS_Id] = T1.[TTBUS_Id]) INNER JOIN [TTBUS007] T3 WITH (NOLOCK) ON T3.[TTBUS7_Pos] = T2.[TTBUS_CodPosicion]) LEFT JOIN [SEG002] T4 WITH (NOLOCK) ON T4.[USU_COD] = T3.[TTBUS7_CodResp]) INNER JOIN [BUS002] T5 WITH (NOLOCK) ON T5.[RBR_COD] = T2.[TTBUS_RubroBien]) LEFT JOIN [M124FPROV] T6 WITH (NOLOCK) ON T6.[PV_NPRO] = T2.[TTBUS_CodProveedor])" ;
         scmdbuf = scmdbuf + " WHERE (T1.[TTBUS_Id] >= @AV55TTBUS_Id)" ;
         scmdbuf = scmdbuf + " and ((T2.[TTBUS_FechaBaja] = convert( DATETIME, '17530101', 112 )))" ;
         scmdbuf = scmdbuf + " and (T1.[IdIdentificador] = @AV12fIdIdentificador)" ;
         if ( AV60TTBUS7_Pos != -1 )
         {
            sWhereString = sWhereString + " and (T2.[TTBUS_CodPosicion] = @AV60TTBUS7_Pos)" ;
         }
         else
         {
            GXv_int21[2] = 1 ;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV14fTTBUS_Descripcion)) )
         {
            sWhereString = sWhereString + " and (T2.[TTBUS_Descripcion] like @AV52TTBUS_Descripcion)" ;
         }
         else
         {
            GXv_int21[3] = 1 ;
         }
         if ( ! (DateTime.MinValue==AV54TTBUS_FechaCarga) )
         {
            sWhereString = sWhereString + " and (T2.[TTBUS_FechaCarga] >= @AV54TTBUS_FechaCarga)" ;
         }
         else
         {
            GXv_int21[4] = 1 ;
         }
         if ( ! (0==AV56TTBUS_RubroBien) )
         {
            sWhereString = sWhereString + " and (T2.[TTBUS_RubroBien] = @AV56TTBUS_RubroBien)" ;
         }
         else
         {
            GXv_int21[5] = 1 ;
         }
         if ( (0==AV15fTTBUS_Estado) )
         {
            sWhereString = sWhereString + " and (T2.[TTBUS_Estado] <= 2)" ;
         }
         if ( ! (0==AV15fTTBUS_Estado) )
         {
            sWhereString = sWhereString + " and (T2.[TTBUS_Estado] = @AV15fTTBUS_Estado)" ;
         }
         else
         {
            GXv_int21[6] = 1 ;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV13fNumeroIdentificador)) )
         {
            sWhereString = sWhereString + " and (T1.[NumeroIdentificador] like @AV40NumeroIdentificador)" ;
         }
         else
         {
            GXv_int21[7] = 1 ;
         }
         scmdbuf = scmdbuf + sWhereString ;
         scmdbuf = scmdbuf + " ORDER BY T1.[NumeroIdentificador]" ;
         GXv_Object22[0] = scmdbuf ;
         GXv_Object22[1] = (Object)(GXv_int21) ;
         return GXv_Object22 ;
      }

      protected Object[] conditional_H001M9( String AV14fTTBUS_Descripcion ,
                                             DateTime AV54TTBUS_FechaCarga ,
                                             short AV56TTBUS_RubroBien ,
                                             short AV15fTTBUS_Estado ,
                                             String AV13fNumeroIdentificador ,
                                             String A12TTBUS_Descripcion ,
                                             String AV52TTBUS_Descripcion ,
                                             DateTime A13TTBUS_FechaCarga ,
                                             short A17TTBUS_RubroBien ,
                                             short A23TTBUS_Estado ,
                                             String A15NumeroIdentificador ,
                                             String AV40NumeroIdentificador ,
                                             int A11TTBUS_Id ,
                                             int AV55TTBUS_Id ,
                                             DateTime A16TTBUS_FechaBaja ,
                                             short A37TTBUS_CodPosicion ,
                                             int A14IdIdentificador ,
                                             int AV12fIdIdentificador )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int23 ;
         GXv_int23 = new short [7] ;
         Object[] GXv_Object24 ;
         GXv_Object24 = new Object [2] ;
         scmdbuf = "SELECT T1.[TTBUS_Id], T2.[TTBUS_CodPosicion] AS TTBUS_CodPosicion, T3.[TTBUS7_CodResp] AS TTBUS7_CodResp, T4.[USU_DES] AS TTBUS7_DesResp, T1.[NumeroIdentificador], T1.[IdIdentificador], T2.[TTBUS_Estado], T2.[TTBUS_RubroBien] AS TTBUS_RubroBien, T2.[TTBUS_FechaCarga], T2.[TTBUS_Descripcion], T2.[TTBUS_FechaBaja], T2.[TTBUS_Alquilado], T2.[TTBUS_CodProveedor] AS TTBUS_CodProveedor, T2.[TTBUS_DesPosicion], T6.[PV_DESC] AS TTBUS_DesProveedor, T5.[RBR_DES] AS TTBUS_RubroDesc FROM ((((([TTBUS000Identificadores] T1 WITH (NOLOCK) INNER JOIN [TTBUS000] T2 WITH (NOLOCK) ON T2.[TTBUS_Id] = T1.[TTBUS_Id]) INNER JOIN [TTBUS007] T3 WITH (NOLOCK) ON T3.[TTBUS7_Pos] = T2.[TTBUS_CodPosicion]) LEFT JOIN [SEG002] T4 WITH (NOLOCK) ON T4.[USU_COD] = T3.[TTBUS7_CodResp]) INNER JOIN [BUS002] T5 WITH (NOLOCK) ON T5.[RBR_COD] = T2.[TTBUS_RubroBien]) LEFT JOIN [M124FPROV] T6 WITH (NOLOCK) ON T6.[PV_NPRO] = T2.[TTBUS_CodProveedor])" ;
         scmdbuf = scmdbuf + " WHERE (T1.[TTBUS_Id] >= @AV55TTBUS_Id)" ;
         scmdbuf = scmdbuf + " and ((T2.[TTBUS_FechaBaja] = convert( DATETIME, '17530101', 112 )))" ;
         scmdbuf = scmdbuf + " and (T2.[TTBUS_CodPosicion] = 999)" ;
         scmdbuf = scmdbuf + " and (T1.[IdIdentificador] = @AV12fIdIdentificador)" ;
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV14fTTBUS_Descripcion)) )
         {
            sWhereString = sWhereString + " and (T2.[TTBUS_Descripcion] like @AV52TTBUS_Descripcion)" ;
         }
         else
         {
            GXv_int23[2] = 1 ;
         }
         if ( ! (DateTime.MinValue==AV54TTBUS_FechaCarga) )
         {
            sWhereString = sWhereString + " and (T2.[TTBUS_FechaCarga] >= @AV54TTBUS_FechaCarga)" ;
         }
         else
         {
            GXv_int23[3] = 1 ;
         }
         if ( ! (0==AV56TTBUS_RubroBien) )
         {
            sWhereString = sWhereString + " and (T2.[TTBUS_RubroBien] = @AV56TTBUS_RubroBien)" ;
         }
         else
         {
            GXv_int23[4] = 1 ;
         }
         if ( (0==AV15fTTBUS_Estado) )
         {
            sWhereString = sWhereString + " and (T2.[TTBUS_Estado] <= 2)" ;
         }
         if ( ! (0==AV15fTTBUS_Estado) )
         {
            sWhereString = sWhereString + " and (T2.[TTBUS_Estado] = @AV15fTTBUS_Estado)" ;
         }
         else
         {
            GXv_int23[5] = 1 ;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV13fNumeroIdentificador)) )
         {
            sWhereString = sWhereString + " and (T1.[NumeroIdentificador] = @AV40NumeroIdentificador)" ;
         }
         else
         {
            GXv_int23[6] = 1 ;
         }
         scmdbuf = scmdbuf + sWhereString ;
         scmdbuf = scmdbuf + " ORDER BY T1.[NumeroIdentificador]" ;
         GXv_Object24[0] = scmdbuf ;
         GXv_Object24[1] = (Object)(GXv_int23) ;
         return GXv_Object24 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 4 :
                     return conditional_H001M6( (short)dynConstraints[0] , (String)dynConstraints[1] , (DateTime)dynConstraints[2] , (short)dynConstraints[3] , (short)dynConstraints[4] , (String)dynConstraints[5] , (short)dynConstraints[6] , (String)dynConstraints[7] , (String)dynConstraints[8] , (DateTime)dynConstraints[9] , (short)dynConstraints[10] , (short)dynConstraints[11] , (String)dynConstraints[12] , (String)dynConstraints[13] , (int)dynConstraints[14] , (int)dynConstraints[15] , (DateTime)dynConstraints[16] , (int)dynConstraints[17] , (int)dynConstraints[18] );
               case 7 :
                     return conditional_H001M9( (String)dynConstraints[0] , (DateTime)dynConstraints[1] , (short)dynConstraints[2] , (short)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (DateTime)dynConstraints[7] , (short)dynConstraints[8] , (short)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (int)dynConstraints[12] , (int)dynConstraints[13] , (DateTime)dynConstraints[14] , (short)dynConstraints[15] , (int)dynConstraints[16] , (int)dynConstraints[17] );
         }
         return base.getDynamicStatement(cursor, dynConstraints);
      }

      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
         ,new ForEachCursor(def[3])
         ,new ForEachCursor(def[4])
         ,new ForEachCursor(def[5])
         ,new ForEachCursor(def[6])
         ,new ForEachCursor(def[7])
         ,new ForEachCursor(def[8])
         ,new ForEachCursor(def[9])
         ,new ForEachCursor(def[10])
         ,new ForEachCursor(def[11])
         ,new ForEachCursor(def[12])
         ,new ForEachCursor(def[13])
         ,new ForEachCursor(def[14])
         ,new ForEachCursor(def[15])
         ,new ForEachCursor(def[16])
         ,new ForEachCursor(def[17])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH001M2 ;
          prmH001M2 = new Object[] {
          } ;
          Object[] prmH001M3 ;
          prmH001M3 = new Object[] {
          } ;
          Object[] prmH001M4 ;
          prmH001M4 = new Object[] {
          new Object[] {"@TTBUS_Descripcion",SqlDbType.VarChar,50,0}
          } ;
          Object[] prmH001M5 ;
          prmH001M5 = new Object[] {
          new Object[] {"@TTBUS_Descripcion",SqlDbType.VarChar,50,0}
          } ;
          Object[] prmH001M7 ;
          prmH001M7 = new Object[] {
          new Object[] {"@TTBUS_CodPosicion",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmH001M8 ;
          prmH001M8 = new Object[] {
          new Object[] {"@TTBUS_Id",SqlDbType.Int,8,0}
          } ;
          Object[] prmH001M10 ;
          prmH001M10 = new Object[] {
          new Object[] {"@TTBUS_CodPosicion",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmH001M11 ;
          prmH001M11 = new Object[] {
          new Object[] {"@TTBUS_Id",SqlDbType.Int,8,0}
          } ;
          Object[] prmH001M12 ;
          prmH001M12 = new Object[] {
          new Object[] {"@AV62USUARIO",SqlDbType.Char,16,0}
          } ;
          Object[] prmH001M13 ;
          prmH001M13 = new Object[] {
          } ;
          Object[] prmH001M14 ;
          prmH001M14 = new Object[] {
          new Object[] {"@W53POS",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmH001M15 ;
          prmH001M15 = new Object[] {
          } ;
          Object[] prmH001M16 ;
          prmH001M16 = new Object[] {
          new Object[] {"@W53POS",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmH001M17 ;
          prmH001M17 = new Object[] {
          new Object[] {"@W53POS",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@AV62USUARIO",SqlDbType.Char,16,0} ,
          new Object[] {"@AV64vTTBUS7_Pos",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmH001M18 ;
          prmH001M18 = new Object[] {
          new Object[] {"@AV57TTBUS2_RespDesde",SqlDbType.Char,15,0}
          } ;
          Object[] prmH001M19 ;
          prmH001M19 = new Object[] {
          new Object[] {"@AV58TTBUS2_RespHacia",SqlDbType.Char,15,0}
          } ;
          Object[] prmH001M6 ;
          prmH001M6 = new Object[] {
          new Object[] {"@AV55TTBUS_Id",SqlDbType.Int,8,0} ,
          new Object[] {"@AV12fIdIdentificador",SqlDbType.Int,8,0} ,
          new Object[] {"@AV60TTBUS7_Pos",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@AV52TTBUS_Descripcion",SqlDbType.VarChar,50,0} ,
          new Object[] {"@AV54TTBUS_FechaCarga",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV56TTBUS_RubroBien",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV15fTTBUS_Estado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@AV40NumeroIdentificador",SqlDbType.VarChar,80,0}
          } ;
          Object[] prmH001M9 ;
          prmH001M9 = new Object[] {
          new Object[] {"@AV55TTBUS_Id",SqlDbType.Int,8,0} ,
          new Object[] {"@AV12fIdIdentificador",SqlDbType.Int,8,0} ,
          new Object[] {"@AV52TTBUS_Descripcion",SqlDbType.VarChar,50,0} ,
          new Object[] {"@AV54TTBUS_FechaCarga",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV56TTBUS_RubroBien",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV15fTTBUS_Estado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@AV40NumeroIdentificador",SqlDbType.VarChar,80,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H001M2", "SELECT [TTBUS5_IdIdentificador], [TTBUS5_DescIdentificador] FROM [TTBUS005] WITH (NOLOCK) ORDER BY [TTBUS5_DescIdentificador] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001M2,0,0,true,false )
             ,new CursorDef("H001M3", "SELECT [TTBUS5_IdIdentificador], [TTBUS5_DescIdentificador] FROM [TTBUS005] WITH (NOLOCK) ORDER BY [TTBUS5_DescIdentificador] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001M3,0,0,true,false )
             ,new CursorDef("H001M4", "SELECT DISTINCT TOP 5 [TTBUS_Descripcion] FROM [TTBUS000] WITH (NOLOCK) WHERE UPPER(CAST([TTBUS_Descripcion] AS char(50))) like UPPER(CAST(@TTBUS_Descripcion AS char(50))) ORDER BY [TTBUS_Descripcion] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001M4,0,0,true,false )
             ,new CursorDef("H001M5", "SELECT DISTINCT TOP 5 [TTBUS_Descripcion] FROM [TTBUS000] WITH (NOLOCK) WHERE UPPER(CAST([TTBUS_Descripcion] AS char(50))) like UPPER(CAST(@TTBUS_Descripcion AS char(50))) ORDER BY [TTBUS_Descripcion] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001M5,0,0,true,false )
             ,new CursorDef("H001M6", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001M6,100,0,true,false )
             ,new CursorDef("H001M7", "SELECT [TTBUS7_Pos] AS TTBUS7_Pos FROM [TTBUS007] WITH (NOLOCK) WHERE [TTBUS7_Pos] = @TTBUS_CodPosicion ORDER BY [TTBUS7_Pos] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001M7,1,0,true,true )
             ,new CursorDef("H001M8", "SELECT [TTBUS2_IdMovimiento], [TTBUS2_IdBien], [TTBUS2_EstadoEnvio], [TTBUS2_RespDesde], [TTBUS2_RespHacia] FROM [TTBUS002] WITH (NOLOCK) WHERE ([TTBUS2_IdBien] = @TTBUS_Id) AND ([TTBUS2_EstadoEnvio] = 1) ORDER BY [TTBUS2_IdMovimiento] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001M8,100,0,true,false )
             ,new CursorDef("H001M9", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001M9,100,0,true,false )
             ,new CursorDef("H001M10", "SELECT [TTBUS7_Pos] AS TTBUS7_Pos FROM [TTBUS007] WITH (NOLOCK) WHERE [TTBUS7_Pos] = @TTBUS_CodPosicion ORDER BY [TTBUS7_Pos] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001M10,1,0,true,true )
             ,new CursorDef("H001M11", "SELECT [TTBUS2_IdMovimiento], [TTBUS2_IdBien], [TTBUS2_EstadoEnvio], [TTBUS2_RespDesde], [TTBUS2_RespHacia] FROM [TTBUS002] WITH (NOLOCK) WHERE ([TTBUS2_IdBien] = @TTBUS_Id) AND ([TTBUS2_EstadoEnvio] = 1) ORDER BY [TTBUS2_IdMovimiento] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001M11,100,0,true,false )
             ,new CursorDef("H001M12", "SELECT [TTBUS8_CodUsuario] FROM [TTBUS008] WITH (NOLOCK) WHERE [TTBUS8_CodUsuario] = @AV62USUARIO ORDER BY [TTBUS8_CodUsuario] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001M12,1,0,true,true )
             ,new CursorDef("H001M13", "SELECT [W53POS], [W53DES] FROM [T53FPOS] WITH (NOLOCK) ORDER BY [W53DES] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001M13,100,0,true,false )
             ,new CursorDef("H001M14", "SELECT T1.[TTBUS7_Pos] AS TTBUS7_Pos, T2.[W53DES] AS TTBUS7_Des FROM ([TTBUS007] T1 WITH (NOLOCK) INNER JOIN [T53FPOS] T2 WITH (NOLOCK) ON T2.[W53POS] = T1.[TTBUS7_Pos]) WHERE (T1.[TTBUS7_Pos] = @W53POS) AND (T1.[TTBUS7_Pos] <> 998) ORDER BY T1.[TTBUS7_Pos] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001M14,1,0,true,true )
             ,new CursorDef("H001M15", "SELECT [W53POS], [W53DES] FROM [T53FPOS] WITH (NOLOCK) ORDER BY [W53DES] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001M15,100,0,true,false )
             ,new CursorDef("H001M16", "SELECT T1.[TTBUS7_Pos] AS TTBUS7_Pos, T2.[W53DES] AS TTBUS7_Des, T1.[TTBUS7_CodResp] AS TTBUS7_CodResp FROM ([TTBUS007] T1 WITH (NOLOCK) INNER JOIN [T53FPOS] T2 WITH (NOLOCK) ON T2.[W53POS] = T1.[TTBUS7_Pos]) WHERE (T1.[TTBUS7_Pos] = @W53POS) AND (T1.[TTBUS7_Pos] <> 998) ORDER BY T1.[TTBUS7_Pos] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001M16,100,0,true,false )
             ,new CursorDef("H001M17", "SELECT [TTBUS7_CodUsuario], [TTBUS7_Pos] AS TTBUS7_Pos FROM [TTBUS007Permisos] WITH (NOLOCK) WHERE ([TTBUS7_Pos] = @W53POS and [TTBUS7_CodUsuario] = @AV62USUARIO) AND ([TTBUS7_Pos] <> 998) AND ([TTBUS7_Pos] = @AV64vTTBUS7_Pos) ORDER BY [TTBUS7_Pos], [TTBUS7_CodUsuario] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001M17,1,0,true,true )
             ,new CursorDef("H001M18", "SELECT [USU_COD], [USU_DES] FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @AV57TTBUS2_RespDesde ORDER BY [USU_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001M18,1,0,true,true )
             ,new CursorDef("H001M19", "SELECT [USU_COD], [USU_DES] FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @AV58TTBUS2_RespHacia ORDER BY [USU_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001M19,1,0,true,true )
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
             case 0 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 60) ;
                break;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 60) ;
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 4 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 16) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                ((String[]) buf[4])[0] = rslt.getString(4, 50) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(4);
                ((String[]) buf[6])[0] = rslt.getVarchar(5) ;
                ((int[]) buf[7])[0] = rslt.getInt(6) ;
                ((short[]) buf[8])[0] = rslt.getShort(7) ;
                ((short[]) buf[9])[0] = rslt.getShort(8) ;
                ((DateTime[]) buf[10])[0] = rslt.getGXDate(9) ;
                ((String[]) buf[11])[0] = rslt.getVarchar(10) ;
                ((DateTime[]) buf[12])[0] = rslt.getGXDate(11) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(11);
                ((short[]) buf[14])[0] = rslt.getShort(12) ;
                ((int[]) buf[15])[0] = rslt.getInt(13) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(13);
                ((String[]) buf[17])[0] = rslt.getString(14, 50) ;
                ((String[]) buf[18])[0] = rslt.getString(15, 30) ;
                ((bool[]) buf[19])[0] = rslt.wasNull(15);
                ((String[]) buf[20])[0] = rslt.getString(16, 30) ;
                ((bool[]) buf[21])[0] = rslt.wasNull(16);
                break;
             case 5 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                break;
             case 6 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 15) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 15) ;
                break;
             case 7 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 16) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                ((String[]) buf[4])[0] = rslt.getString(4, 50) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(4);
                ((String[]) buf[6])[0] = rslt.getVarchar(5) ;
                ((int[]) buf[7])[0] = rslt.getInt(6) ;
                ((short[]) buf[8])[0] = rslt.getShort(7) ;
                ((short[]) buf[9])[0] = rslt.getShort(8) ;
                ((DateTime[]) buf[10])[0] = rslt.getGXDate(9) ;
                ((String[]) buf[11])[0] = rslt.getVarchar(10) ;
                ((DateTime[]) buf[12])[0] = rslt.getGXDate(11) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(11);
                ((short[]) buf[14])[0] = rslt.getShort(12) ;
                ((int[]) buf[15])[0] = rslt.getInt(13) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(13);
                ((String[]) buf[17])[0] = rslt.getString(14, 50) ;
                ((String[]) buf[18])[0] = rslt.getString(15, 30) ;
                ((bool[]) buf[19])[0] = rslt.wasNull(15);
                ((String[]) buf[20])[0] = rslt.getString(16, 30) ;
                ((bool[]) buf[21])[0] = rslt.wasNull(16);
                break;
             case 8 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                break;
             case 9 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 15) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 15) ;
                break;
             case 10 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                break;
             case 11 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                break;
             case 12 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                break;
             case 13 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                break;
             case 14 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getString(3, 16) ;
                break;
             case 15 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                break;
             case 16 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                break;
             case 17 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                break;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       short sIdx ;
       switch ( cursor )
       {
             case 2 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 3 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 4 :
                sIdx = 0 ;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1) ;
                   stmt.SetParameter(sIdx, (int)parms[8]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1) ;
                   stmt.SetParameter(sIdx, (int)parms[9]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1) ;
                   stmt.SetParameter(sIdx, (short)parms[10]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1) ;
                   stmt.SetParameter(sIdx, (String)parms[11]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1) ;
                   stmt.SetParameter(sIdx, (DateTime)parms[12]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1) ;
                   stmt.SetParameter(sIdx, (short)parms[13]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1) ;
                   stmt.SetParameter(sIdx, (short)parms[14]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1) ;
                   stmt.SetParameter(sIdx, (String)parms[15]);
                }
                break;
             case 5 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 6 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 7 :
                sIdx = 0 ;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1) ;
                   stmt.SetParameter(sIdx, (int)parms[7]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1) ;
                   stmt.SetParameter(sIdx, (int)parms[8]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1) ;
                   stmt.SetParameter(sIdx, (String)parms[9]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1) ;
                   stmt.SetParameter(sIdx, (DateTime)parms[10]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1) ;
                   stmt.SetParameter(sIdx, (short)parms[11]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1) ;
                   stmt.SetParameter(sIdx, (short)parms[12]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1) ;
                   stmt.SetParameter(sIdx, (String)parms[13]);
                }
                break;
             case 8 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 9 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 10 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 12 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 14 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 15 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                break;
             case 16 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 17 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
       }
    }

 }

}
