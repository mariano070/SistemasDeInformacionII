/*
               File: HTBUS020
        Description: Administrador de Cambio de Posiciones
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 4/2/2014 19:29:31.63
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
   public class htbus020 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public htbus020( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public htbus020( IGxContext context )
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
         this.AV10SISTEMA = aP0_SISTEMA;
         this.AV16USUARIO = aP1_USUARIO;
         executePrivate();
         aP0_SISTEMA=this.AV10SISTEMA;
         aP1_USUARIO=this.AV16USUARIO;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbavTtbus7_pos = new GXCombobox();
         cmbavPosicionhacia = new GXCombobox();
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxSuggest"+"_"+"TTBUS_DESCRIPCION") == 0 )
            {
               A12TTBUS_Descripcion = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12TTBUS_Descripcion", A12TTBUS_Descripcion);
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               GXSGATTBUS_DESCRIPCION1E0( A12TTBUS_Descripcion) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxSuggest"+"_"+"vTTBUS2_MOTIVOENVIO") == 0 )
            {
               A47TTBUS2_MotivoEnvio = GetNextPar( ) ;
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               GXSGVvTTBUS2_MOTIVOENVIO1E0( A47TTBUS2_MotivoEnvio) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxSuggest"+"_"+"vTTBUS2_OBSERVACIONES") == 0 )
            {
               A87TTBUS2_Observaciones = GetNextPar( ) ;
               n87TTBUS2_Observaciones = false ;
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               GXSGVvTTBUS2_OBSERVACIONES1E0( A87TTBUS2_Observaciones) ;
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
               nGXsfl_24_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               sGXsfl_24_idx = GetNextPar( ) ;
               edtavTtbus2_plazorecepcion_Enabled = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTtbus2_plazorecepcion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTtbus2_plazorecepcion_Enabled), 5, 0)));
               edtavTtbus2_observaciones_Enabled = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTtbus2_observaciones_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTtbus2_observaciones_Enabled), 5, 0)));
               edtavTtbus2_motivoenvio_Enabled = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTtbus2_motivoenvio_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTtbus2_motivoenvio_Enabled), 5, 0)));
               cmbavPosicionhacia.Enabled = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavPosicionhacia_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavPosicionhacia.Enabled), 5, 0)));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxnrGrid1_newrow( nRC_Grid1, nGXsfl_24_idx, sGXsfl_24_idx) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid1") == 0 )
            {
               /* GeneXus formulas. */
               Gx_date = DateTimeUtil.Today( ) ;
               context.Gx_err = 0 ;
               edtavSec_dre_Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSec_dre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavSec_dre_Enabled), 5, 0)));
               edtavGnumeroidentificador_Enabled = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGnumeroidentificador_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGnumeroidentificador_Enabled), 5, 0)));
               cmbavTtbus7_pos.Name = "vTTBUS7_POS" ;
               cmbavTtbus7_pos.WebTags = "" ;
               cmbavTtbus7_pos.addItem(StringUtil.Str( (decimal)(0), 3, 0), "SELECCIONAR", 0);
               if ( ( cmbavTtbus7_pos.ItemCount > 0 ) && (0==AV15TTBUS7_Pos) )
               {
                  AV15TTBUS7_Pos = (short)(NumberUtil.Val( cmbavTtbus7_pos.getItemValue(1), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15TTBUS7_Pos), 3, 0)));
               }
               GXCCtl = "vPOSICIONHACIA_" + sGXsfl_24_idx ;
               cmbavPosicionhacia.Name = GXCCtl ;
               cmbavPosicionhacia.WebTags = "" ;
               if ( ( cmbavPosicionhacia.ItemCount > 0 ) && (0==AV8PosicionHacia) )
               {
                  AV8PosicionHacia = (short)(NumberUtil.Val( cmbavPosicionhacia.getItemValue(1), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8PosicionHacia", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8PosicionHacia), 3, 0)));
               }
               AV15TTBUS7_Pos = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15TTBUS7_Pos), 3, 0)));
               edtavTtbus2_plazorecepcion_Enabled = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTtbus2_plazorecepcion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTtbus2_plazorecepcion_Enabled), 5, 0)));
               edtavTtbus2_observaciones_Enabled = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTtbus2_observaciones_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTtbus2_observaciones_Enabled), 5, 0)));
               edtavTtbus2_motivoenvio_Enabled = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTtbus2_motivoenvio_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTtbus2_motivoenvio_Enabled), 5, 0)));
               cmbavPosicionhacia.Enabled = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavPosicionhacia_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavPosicionhacia.Enabled), 5, 0)));
               ajax_req_read_hidden_sdt(GetNextPar( ), (Object)(AV38Sdt_Posiciones));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxgrGrid1_refresh( AV15TTBUS7_Pos, AV38Sdt_Posiciones) ;
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
               AV10SISTEMA = gxfirstwebparm ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10SISTEMA", AV10SISTEMA);
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV16USUARIO = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16USUARIO", AV16USUARIO);
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
         PA1E2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START1E2( ) ;
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
         FormProcess = ((nGXWrapped==0) ? " onkeyup=\"gx.evt.onkeyup(event)\" onkeypress=\"gx.evt.onkeypress(event,false,false)\" onkeydown=\"gx.evt.onkeypress(null,false,false)\"" : "") ;
         context.WriteHtmlText( "<body") ;
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            context.WriteHtmlText( " background=\""+context.convertURL( Form.Background)+"\"") ;
         }
         context.WriteHtmlText( " "+"class=\"Form\""+" "+" style=\"-moz-opacity:0;opacity:0;"+"background-color:"+context.BuildHTMLColor( Form.Backcolor)+"\""+FormProcess+">") ;
         context.skipLines(1);
         if ( nGXWrapped != 1 )
         {
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("htbus020.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV10SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV16USUARIO))+"\" class=\""+"Form"+"\">") ;
            GxWebStd.gx_hidden_field( context, "_EventName", "");
            GxWebStd.gx_hidden_field( context, "_EventGridId", "");
            GxWebStd.gx_hidden_field( context, "_EventRowId", "");
         }
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, "GXH_vTTBUS7_POS", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV15TTBUS7_Pos), 3, 0, ",", "")));
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_Grid1", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid1), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vUSUARIO", StringUtil.RTrim( AV16USUARIO));
         GxWebStd.gx_hidden_field( context, "vSISTEMA", StringUtil.RTrim( AV10SISTEMA));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vSDT_POSICIONES", (Object)(AV38Sdt_Posiciones));
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vSDT_POSICIONES", (Object)(AV38Sdt_Posiciones));
         }
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendComponentObjects();
         SendServerCommands();
         SendState();
         if ( nGXWrapped != 1 )
         {
            context.WriteHtmlTextNl( "</form>") ;
         }
         include_jscripts( ) ;
      }

      public override void RenderHtmlContent( )
      {
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            WE1E2( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT1E2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return false ;
      }

      public override String GetPgmname( )
      {
         return "HTBUS020" ;
      }

      public override String GetPgmdesc( )
      {
         return "Administrador de Cambio de Posiciones" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("htbus020.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV10SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV16USUARIO)) ;
      }

      protected void WB1E0( )
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
            wb_table1_2_1E2( true) ;
         }
         else
         {
            wb_table1_2_1E2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_1E2e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START1E2( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "Administrador de Cambio de Posiciones", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP1E0( ) ;
      }

      protected void WS1E2( )
      {
         START1E2( ) ;
         EVT1E2( ) ;
      }

      protected void EVT1E2( )
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
                           else if ( StringUtil.StrCmp(sEvt, "VTTBUS7_POS.ISVALID") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E111E2 */
                              E111E2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'CONFIRMAR CAMBIOS'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E121E2 */
                              E121E2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                           }
                        }
                        else
                        {
                           sEvtType = StringUtil.Right( sEvt, 4) ;
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4)) ;
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 10), "GRID1.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 19), "'CONFIRMAR CAMBIOS'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) )
                           {
                              nGXsfl_24_idx = (short)(NumberUtil.Val( sEvtType, ".")) ;
                              sGXsfl_24_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_24_idx), 4, 0)), 4, "0") ;
                              edtavDetalle_Internalname = "vDETALLE_"+sGXsfl_24_idx ;
                              edtavGnumeroidentificador_Internalname = "vGNUMEROIDENTIFICADOR_"+sGXsfl_24_idx ;
                              edtTTBUS_Id_Internalname = "TTBUS_ID_"+sGXsfl_24_idx ;
                              edtTTBUS_Descripcion_Internalname = "TTBUS_DESCRIPCION_"+sGXsfl_24_idx ;
                              edtTTBUS_CodPosicion_Internalname = "TTBUS_CODPOSICION_"+sGXsfl_24_idx ;
                              cmbavPosicionhacia_Internalname = "vPOSICIONHACIA_"+sGXsfl_24_idx ;
                              edtavTtbus2_motivoenvio_Internalname = "vTTBUS2_MOTIVOENVIO_"+sGXsfl_24_idx ;
                              edtavTtbus2_plazorecepcion_Internalname = "vTTBUS2_PLAZORECEPCION_"+sGXsfl_24_idx ;
                              edtavTtbus2_observaciones_Internalname = "vTTBUS2_OBSERVACIONES_"+sGXsfl_24_idx ;
                              AV31detalle = cgiGet( "GXimg"+edtavDetalle_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDetalle_Internalname, "Bitmap", context.convertURL( AV31detalle));
                              AV32gNumeroIdentificador = cgiGet( edtavGnumeroidentificador_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32gNumeroIdentificador", AV32gNumeroIdentificador);
                              A11TTBUS_Id = (int)(context.localUtil.CToN( cgiGet( edtTTBUS_Id_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
                              A12TTBUS_Descripcion = StringUtil.Upper( cgiGet( edtTTBUS_Descripcion_Internalname)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12TTBUS_Descripcion", A12TTBUS_Descripcion);
                              A37TTBUS_CodPosicion = (short)(context.localUtil.CToN( cgiGet( edtTTBUS_CodPosicion_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37TTBUS_CodPosicion", StringUtil.LTrim( StringUtil.Str( (decimal)(A37TTBUS_CodPosicion), 3, 0)));
                              cmbavPosicionhacia.Name = cmbavPosicionhacia_Internalname ;
                              cmbavPosicionhacia.CurrentValue = cgiGet( cmbavPosicionhacia_Internalname) ;
                              AV8PosicionHacia = (short)(NumberUtil.Val( cgiGet( cmbavPosicionhacia_Internalname), ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8PosicionHacia", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8PosicionHacia), 3, 0)));
                              AV13TTBUS2_MotivoEnvio = StringUtil.Upper( cgiGet( edtavTtbus2_motivoenvio_Internalname)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13TTBUS2_MotivoEnvio", AV13TTBUS2_MotivoEnvio);
                              if ( context.localUtil.VCDate( cgiGet( edtavTtbus2_plazorecepcion_Internalname), 4) == 0 )
                              {
                                 GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"TTBUS2_ Plazo Recepcion"}), 1, "vTTBUS2_PLAZORECEPCION");
                                 GX_FocusControl = edtavTtbus2_plazorecepcion_Internalname ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                                 wbErr = true ;
                                 AV33TTBUS2_PlazoRecepcion = DateTime.MinValue ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33TTBUS2_PlazoRecepcion", context.localUtil.Format(AV33TTBUS2_PlazoRecepcion, "99/99/9999"));
                              }
                              else
                              {
                                 AV33TTBUS2_PlazoRecepcion = context.localUtil.CToD( cgiGet( edtavTtbus2_plazorecepcion_Internalname), 4) ;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33TTBUS2_PlazoRecepcion", context.localUtil.Format(AV33TTBUS2_PlazoRecepcion, "99/99/9999"));
                              }
                              AV14TTBUS2_Observaciones = StringUtil.Upper( cgiGet( edtavTtbus2_observaciones_Internalname)) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14TTBUS2_Observaciones", AV14TTBUS2_Observaciones);
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E131E2 */
                                    E131E2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID1.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E141E2 */
                                    E141E2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'CONFIRMAR CAMBIOS'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E121E2 */
                                    E121E2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false ;
                                       /* Set Refresh If Ttbus7_pos Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTTBUS7_POS"), ",", ".") != Convert.ToDecimal( AV15TTBUS7_Pos )) )
                                       {
                                          Rfr0gs = true ;
                                       }
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
                     context.wbHandled = 1 ;
                  }
               }
            }
         }
      }

      protected void WE1E2( )
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

      protected void PA1E2( )
      {
         if ( nDonePA == 0 )
         {
            cmbavTtbus7_pos.Name = "vTTBUS7_POS" ;
            cmbavTtbus7_pos.WebTags = "" ;
            cmbavTtbus7_pos.addItem(StringUtil.Str( (decimal)(0), 3, 0), "SELECCIONAR", 0);
            if ( ( cmbavTtbus7_pos.ItemCount > 0 ) && (0==AV15TTBUS7_Pos) )
            {
               AV15TTBUS7_Pos = (short)(NumberUtil.Val( cmbavTtbus7_pos.getItemValue(1), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15TTBUS7_Pos), 3, 0)));
            }
            GXCCtl = "vPOSICIONHACIA_" + sGXsfl_24_idx ;
            cmbavPosicionhacia.Name = GXCCtl ;
            cmbavPosicionhacia.WebTags = "" ;
            if ( ( cmbavPosicionhacia.ItemCount > 0 ) && (0==AV8PosicionHacia) )
            {
               AV8PosicionHacia = (short)(NumberUtil.Val( cmbavPosicionhacia.getItemValue(1), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8PosicionHacia", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8PosicionHacia), 3, 0)));
            }
            GX_FocusControl = cmbavTtbus7_pos_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void GXSGATTBUS_DESCRIPCION1E0( String A12TTBUS_Descripcion )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
         }
         context.GX_webresponse.AddString("(new Array( new Array(");
         GXSGATTBUS_DESCRIPCION_data1E0( A12TTBUS_Descripcion) ;
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

      protected void GXSGATTBUS_DESCRIPCION_data1E0( String A12TTBUS_Descripcion )
      {
         l12TTBUS_Descripcion = StringUtil.PadR( StringUtil.RTrim( A12TTBUS_Descripcion), 50, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12TTBUS_Descripcion", A12TTBUS_Descripcion);
         /* Using cursor H001E2 */
         pr_default.execute(0, new Object[] {l12TTBUS_Descripcion});
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         while ( (pr_default.getStatus(0) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.RTrim( H001E2_A12TTBUS_Descripcion[0]));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( H001E2_A12TTBUS_Descripcion[0]));
            pr_default.readNext(0);
         }
         pr_default.close(0);
      }

      protected void GXSGVvTTBUS2_MOTIVOENVIO1E0( String A47TTBUS2_MotivoEnvio )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
         }
         context.GX_webresponse.AddString("(new Array( new Array(");
         GXSGVvTTBUS2_MOTIVOENVIO_data1E0( A47TTBUS2_MotivoEnvio) ;
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

      protected void GXSGVvTTBUS2_MOTIVOENVIO_data1E0( String A47TTBUS2_MotivoEnvio )
      {
         l47TTBUS2_MotivoEnvio = StringUtil.PadR( StringUtil.RTrim( A47TTBUS2_MotivoEnvio), 100, "%") ;
         /* Using cursor H001E3 */
         pr_default.execute(1, new Object[] {l47TTBUS2_MotivoEnvio});
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         while ( (pr_default.getStatus(1) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.RTrim( H001E3_A47TTBUS2_MotivoEnvio[0]));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( H001E3_A47TTBUS2_MotivoEnvio[0]));
            pr_default.readNext(1);
         }
         pr_default.close(1);
      }

      protected void GXSGVvTTBUS2_OBSERVACIONES1E0( String A87TTBUS2_Observaciones )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
         }
         context.GX_webresponse.AddString("(new Array( new Array(");
         GXSGVvTTBUS2_OBSERVACIONES_data1E0( A87TTBUS2_Observaciones) ;
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

      protected void GXSGVvTTBUS2_OBSERVACIONES_data1E0( String A87TTBUS2_Observaciones )
      {
         l87TTBUS2_Observaciones = StringUtil.PadR( StringUtil.RTrim( A87TTBUS2_Observaciones), 400, "%") ;
         n87TTBUS2_Observaciones = false ;
         /* Using cursor H001E4 */
         pr_default.execute(2, new Object[] {n87TTBUS2_Observaciones, l87TTBUS2_Observaciones});
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         while ( (pr_default.getStatus(2) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.RTrim( H001E4_A87TTBUS2_Observaciones[0]));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( H001E4_A87TTBUS2_Observaciones[0]));
            pr_default.readNext(2);
         }
         pr_default.close(2);
      }

      protected void gxnrGrid1_newrow( short nRC_Grid1 ,
                                       short nGXsfl_24_idx ,
                                       String sGXsfl_24_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         edtavDetalle_Internalname = "vDETALLE_"+sGXsfl_24_idx ;
         edtavGnumeroidentificador_Internalname = "vGNUMEROIDENTIFICADOR_"+sGXsfl_24_idx ;
         edtTTBUS_Id_Internalname = "TTBUS_ID_"+sGXsfl_24_idx ;
         edtTTBUS_Descripcion_Internalname = "TTBUS_DESCRIPCION_"+sGXsfl_24_idx ;
         edtTTBUS_CodPosicion_Internalname = "TTBUS_CODPOSICION_"+sGXsfl_24_idx ;
         cmbavPosicionhacia_Internalname = "vPOSICIONHACIA_"+sGXsfl_24_idx ;
         edtavTtbus2_motivoenvio_Internalname = "vTTBUS2_MOTIVOENVIO_"+sGXsfl_24_idx ;
         edtavTtbus2_plazorecepcion_Internalname = "vTTBUS2_PLAZORECEPCION_"+sGXsfl_24_idx ;
         edtavTtbus2_observaciones_Internalname = "vTTBUS2_OBSERVACIONES_"+sGXsfl_24_idx ;
         while ( nGXsfl_24_idx <= nRC_Grid1 )
         {
            sendrow_242( ) ;
            nGXsfl_24_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_24_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_24_idx+1)) ;
            sGXsfl_24_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_24_idx), 4, 0)), 4, "0") ;
            edtavDetalle_Internalname = "vDETALLE_"+sGXsfl_24_idx ;
            edtavGnumeroidentificador_Internalname = "vGNUMEROIDENTIFICADOR_"+sGXsfl_24_idx ;
            edtTTBUS_Id_Internalname = "TTBUS_ID_"+sGXsfl_24_idx ;
            edtTTBUS_Descripcion_Internalname = "TTBUS_DESCRIPCION_"+sGXsfl_24_idx ;
            edtTTBUS_CodPosicion_Internalname = "TTBUS_CODPOSICION_"+sGXsfl_24_idx ;
            cmbavPosicionhacia_Internalname = "vPOSICIONHACIA_"+sGXsfl_24_idx ;
            edtavTtbus2_motivoenvio_Internalname = "vTTBUS2_MOTIVOENVIO_"+sGXsfl_24_idx ;
            edtavTtbus2_plazorecepcion_Internalname = "vTTBUS2_PLAZORECEPCION_"+sGXsfl_24_idx ;
            edtavTtbus2_observaciones_Internalname = "vTTBUS2_OBSERVACIONES_"+sGXsfl_24_idx ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( short AV15TTBUS7_Pos ,
                                        IGxCollection AV38Sdt_Posiciones )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         disableOutput();
         RF1E2( ) ;
         enableOutput();
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxgrGrid1_refresh */
      }

      protected void Refresh( )
      {
         RF1E2( ) ;
         /* End function Refresh */
      }

      protected void RF1E2( )
      {
         Grid1Container.PageSize = subGrid1_Recordsperpage( ) ;
         wbStart = 24 ;
         nGXsfl_24_idx = 1 ;
         sGXsfl_24_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_24_idx), 4, 0)), 4, "0") ;
         edtavDetalle_Internalname = "vDETALLE_"+sGXsfl_24_idx ;
         edtavGnumeroidentificador_Internalname = "vGNUMEROIDENTIFICADOR_"+sGXsfl_24_idx ;
         edtTTBUS_Id_Internalname = "TTBUS_ID_"+sGXsfl_24_idx ;
         edtTTBUS_Descripcion_Internalname = "TTBUS_DESCRIPCION_"+sGXsfl_24_idx ;
         edtTTBUS_CodPosicion_Internalname = "TTBUS_CODPOSICION_"+sGXsfl_24_idx ;
         cmbavPosicionhacia_Internalname = "vPOSICIONHACIA_"+sGXsfl_24_idx ;
         edtavTtbus2_motivoenvio_Internalname = "vTTBUS2_MOTIVOENVIO_"+sGXsfl_24_idx ;
         edtavTtbus2_plazorecepcion_Internalname = "vTTBUS2_PLAZORECEPCION_"+sGXsfl_24_idx ;
         edtavTtbus2_observaciones_Internalname = "vTTBUS2_OBSERVACIONES_"+sGXsfl_24_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtavDetalle_Internalname = "vDETALLE_"+sGXsfl_24_idx ;
            edtavGnumeroidentificador_Internalname = "vGNUMEROIDENTIFICADOR_"+sGXsfl_24_idx ;
            edtTTBUS_Id_Internalname = "TTBUS_ID_"+sGXsfl_24_idx ;
            edtTTBUS_Descripcion_Internalname = "TTBUS_DESCRIPCION_"+sGXsfl_24_idx ;
            edtTTBUS_CodPosicion_Internalname = "TTBUS_CODPOSICION_"+sGXsfl_24_idx ;
            cmbavPosicionhacia_Internalname = "vPOSICIONHACIA_"+sGXsfl_24_idx ;
            edtavTtbus2_motivoenvio_Internalname = "vTTBUS2_MOTIVOENVIO_"+sGXsfl_24_idx ;
            edtavTtbus2_plazorecepcion_Internalname = "vTTBUS2_PLAZORECEPCION_"+sGXsfl_24_idx ;
            edtavTtbus2_observaciones_Internalname = "vTTBUS2_OBSERVACIONES_"+sGXsfl_24_idx ;
            /* Using cursor H001E5 */
            pr_default.execute(3, new Object[] {AV15TTBUS7_Pos});
            while ( (pr_default.getStatus(3) != 101) )
            {
               A23TTBUS_Estado = H001E5_A23TTBUS_Estado[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23TTBUS_Estado", StringUtil.Str( (decimal)(A23TTBUS_Estado), 1, 0));
               A37TTBUS_CodPosicion = H001E5_A37TTBUS_CodPosicion[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37TTBUS_CodPosicion", StringUtil.LTrim( StringUtil.Str( (decimal)(A37TTBUS_CodPosicion), 3, 0)));
               A12TTBUS_Descripcion = H001E5_A12TTBUS_Descripcion[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12TTBUS_Descripcion", A12TTBUS_Descripcion);
               A11TTBUS_Id = H001E5_A11TTBUS_Id[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
               /* Execute user event: E141E2 */
               E141E2 ();
               pr_default.readNext(3);
            }
            pr_default.close(3);
            wbEnd = 24 ;
            WB1E0( ) ;
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
         return (int)(-1) ;
      }

      protected int subGrid1_Currentpage( )
      {
         return (int)(-1) ;
      }

      protected void STRUP1E0( )
      {
         /* Before Start, stand alone formulas. */
         Gx_date = DateTimeUtil.Today( ) ;
         context.Gx_err = 0 ;
         edtavSec_dre_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSec_dre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavSec_dre_Enabled), 5, 0)));
         edtavGnumeroidentificador_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavGnumeroidentificador_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavGnumeroidentificador_Enabled), 5, 0)));
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E131E2 */
         E131E2 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            cmbavTtbus7_pos.Name = cmbavTtbus7_pos_Internalname ;
            cmbavTtbus7_pos.CurrentValue = cgiGet( cmbavTtbus7_pos_Internalname) ;
            AV15TTBUS7_Pos = (short)(NumberUtil.Val( cgiGet( cmbavTtbus7_pos_Internalname), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15TTBUS7_Pos), 3, 0)));
            AV9SEC_DRE = cgiGet( edtavSec_dre_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9SEC_DRE", AV9SEC_DRE);
            /* Read saved values. */
            nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ",", ".")) ;
            AV16USUARIO = cgiGet( "vUSUARIO") ;
            AV10SISTEMA = cgiGet( "vSISTEMA") ;
            /* Read subfile selected row values. */
            /* Read hidden variables. */
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: E131E2 */
         E131E2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E131E2( )
      {
         /* Start Routine */
         AV9SEC_DRE = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9SEC_DRE", AV9SEC_DRE);
         new loadcontext(context ).execute( out  AV30Context) ;
         AV16USUARIO = AV30Context.gxTpr_User ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16USUARIO", AV16USUARIO);
         /* Execute user subroutine: S112 */
         S112 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         cmbavPosicionhacia.Enabled = 1 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavPosicionhacia_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbavPosicionhacia.Enabled), 5, 0)));
         edtavTtbus2_motivoenvio_Enabled = 1 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTtbus2_motivoenvio_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTtbus2_motivoenvio_Enabled), 5, 0)));
         edtavTtbus2_observaciones_Enabled = 1 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTtbus2_observaciones_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTtbus2_observaciones_Enabled), 5, 0)));
         edtavTtbus2_plazorecepcion_Enabled = 1 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTtbus2_plazorecepcion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTtbus2_plazorecepcion_Enabled), 5, 0)));
      }

      private void E141E2( )
      {
         /* Grid1_Load Routine */
         AV31detalle = context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", "Modern") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDetalle_Internalname, "Bitmap", context.convertURL( AV31detalle));
         new ptbus009(context ).execute(  A11TTBUS_Id,  1, out  AV32gNumeroIdentificador) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32gNumeroIdentificador", AV32gNumeroIdentificador);
         cmbavPosicionhacia.addItem("  0", "SELECCIONAR POSICIÓN DESTINO", 0);
         /* Execute user subroutine: S122 */
         S122 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 24 ;
         }
         sendrow_242( ) ;
      }

      protected void E111E2( )
      {
         /* Ttbus7_pos_Isvalid Routine */
         new ptbus020_a(context ).execute(  AV15TTBUS7_Pos, out  AV6dSEC_CRE, out  AV9SEC_DRE) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15TTBUS7_Pos), 3, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9SEC_DRE", AV9SEC_DRE);
         if ( ! (0==AV15TTBUS7_Pos) )
         {
            new ptbus020_c(context ).execute(  AV15TTBUS7_Pos, out  AV38Sdt_Posiciones) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15TTBUS7_Pos), 3, 0)));
         }
      }

      protected void E121E2( )
      {
         /* 'Confirmar Cambios' Routine */
         AV6dSEC_CRE = AV18SESION.Get("RespEnvio") ;
         AV25band_ = 0 ;
         /* Start For Each Line */
         nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ",", ".")) ;
         nGXsfl_24_fel_idx = 0 ;
         while ( nGXsfl_24_fel_idx < nRC_Grid1 )
         {
            nGXsfl_24_fel_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_24_fel_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_24_fel_idx+1)) ;
            sGXsfl_24_fel_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_24_fel_idx), 4, 0)), 4, "0") ;
            edtavDetalle_Internalname = "vDETALLE_"+sGXsfl_24_fel_idx ;
            edtavGnumeroidentificador_Internalname = "vGNUMEROIDENTIFICADOR_"+sGXsfl_24_fel_idx ;
            edtTTBUS_Id_Internalname = "TTBUS_ID_"+sGXsfl_24_fel_idx ;
            edtTTBUS_Descripcion_Internalname = "TTBUS_DESCRIPCION_"+sGXsfl_24_fel_idx ;
            edtTTBUS_CodPosicion_Internalname = "TTBUS_CODPOSICION_"+sGXsfl_24_fel_idx ;
            cmbavPosicionhacia_Internalname = "vPOSICIONHACIA_"+sGXsfl_24_fel_idx ;
            edtavTtbus2_motivoenvio_Internalname = "vTTBUS2_MOTIVOENVIO_"+sGXsfl_24_fel_idx ;
            edtavTtbus2_plazorecepcion_Internalname = "vTTBUS2_PLAZORECEPCION_"+sGXsfl_24_fel_idx ;
            edtavTtbus2_observaciones_Internalname = "vTTBUS2_OBSERVACIONES_"+sGXsfl_24_fel_idx ;
            AV31detalle = cgiGet( "GXimg"+edtavDetalle_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDetalle_Internalname, "Bitmap", context.convertURL( AV31detalle));
            AV32gNumeroIdentificador = cgiGet( edtavGnumeroidentificador_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32gNumeroIdentificador", AV32gNumeroIdentificador);
            A11TTBUS_Id = (int)(context.localUtil.CToN( cgiGet( edtTTBUS_Id_Internalname), ",", ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
            A12TTBUS_Descripcion = StringUtil.Upper( cgiGet( edtTTBUS_Descripcion_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12TTBUS_Descripcion", A12TTBUS_Descripcion);
            A37TTBUS_CodPosicion = (short)(context.localUtil.CToN( cgiGet( edtTTBUS_CodPosicion_Internalname), ",", ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A37TTBUS_CodPosicion", StringUtil.LTrim( StringUtil.Str( (decimal)(A37TTBUS_CodPosicion), 3, 0)));
            cmbavPosicionhacia.Name = cmbavPosicionhacia_Internalname ;
            cmbavPosicionhacia.CurrentValue = cgiGet( cmbavPosicionhacia_Internalname) ;
            AV8PosicionHacia = (short)(NumberUtil.Val( cgiGet( cmbavPosicionhacia_Internalname), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8PosicionHacia", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8PosicionHacia), 3, 0)));
            AV13TTBUS2_MotivoEnvio = StringUtil.Upper( cgiGet( edtavTtbus2_motivoenvio_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13TTBUS2_MotivoEnvio", AV13TTBUS2_MotivoEnvio);
            if ( context.localUtil.VCDate( cgiGet( edtavTtbus2_plazorecepcion_Internalname), 4) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"TTBUS2_ Plazo Recepcion"}), 1, "vTTBUS2_PLAZORECEPCION");
               GX_FocusControl = edtavTtbus2_plazorecepcion_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV33TTBUS2_PlazoRecepcion = DateTime.MinValue ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33TTBUS2_PlazoRecepcion", context.localUtil.Format(AV33TTBUS2_PlazoRecepcion, "99/99/9999"));
            }
            else
            {
               AV33TTBUS2_PlazoRecepcion = context.localUtil.CToD( cgiGet( edtavTtbus2_plazorecepcion_Internalname), 4) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33TTBUS2_PlazoRecepcion", context.localUtil.Format(AV33TTBUS2_PlazoRecepcion, "99/99/9999"));
            }
            AV14TTBUS2_Observaciones = StringUtil.Upper( cgiGet( edtavTtbus2_observaciones_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14TTBUS2_Observaciones", AV14TTBUS2_Observaciones);
            if ( AV8PosicionHacia != 0 )
            {
               AV27TTBUS20_MotivoEnvio = "" ;
               AV28TTBUS20_Observaciones = "" ;
               AV34TTBUS20_PlazoRecepcion = DateTime.MinValue ;
               AV36validado = 1 ;
               /* Execute user subroutine: S132 */
               S132 ();
               if ( returnInSub )
               {
                  returnInSub = true;
                  if (true) return;
               }
               if ( AV36validado == 1 )
               {
                  new ptbus020_b(context ).execute(  AV8PosicionHacia, out  AV21TTBUS7_Des) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8PosicionHacia", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8PosicionHacia), 3, 0)));
                  new ptbus020_d(context ).execute(  AV8PosicionHacia, out  AV7hSEC_CRE) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8PosicionHacia", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8PosicionHacia), 3, 0)));
                  AV11TTBUS2_FechaEnvio = DateTimeUtil.Now( ) ;
                  AV12TTBUS2_FechaRecepcion = (DateTime)(DateTime.MinValue) ;
                  GXt_int3 = 1 ;
                  GXt_char2 = "UPD" ;
                  new pttbus000_1(context ).execute( ref  A11TTBUS_Id, ref  AV15TTBUS7_Pos, ref  AV6dSEC_CRE, ref  AV11TTBUS2_FechaEnvio, ref  AV8PosicionHacia, ref  AV7hSEC_CRE, ref  AV12TTBUS2_FechaRecepcion, ref  GXt_int3, ref  AV13TTBUS2_MotivoEnvio, ref  AV14TTBUS2_Observaciones, ref  GXt_char2, ref  AV16USUARIO, ref  AV33TTBUS2_PlazoRecepcion) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15TTBUS7_Pos), 3, 0)));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8PosicionHacia", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8PosicionHacia), 3, 0)));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13TTBUS2_MotivoEnvio", AV13TTBUS2_MotivoEnvio);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14TTBUS2_Observaciones", AV14TTBUS2_Observaciones);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16USUARIO", AV16USUARIO);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33TTBUS2_PlazoRecepcion", context.localUtil.Format(AV33TTBUS2_PlazoRecepcion, "99/99/9999"));
                  AV19TTBUS20_Mensaje = "Cambiando a posición \"" + StringUtil.Trim( AV21TTBUS7_Des) + "\"." ;
                  AV27TTBUS20_MotivoEnvio = "Motivo Envío: " + StringUtil.Trim( AV13TTBUS2_MotivoEnvio) + "." ;
                  AV34TTBUS20_PlazoRecepcion = AV33TTBUS2_PlazoRecepcion ;
                  if ( StringUtil.StrCmp(StringUtil.Trim( AV14TTBUS2_Observaciones), "") != 0 )
                  {
                     AV28TTBUS20_Observaciones = "Obs.: " + StringUtil.Trim( AV14TTBUS2_Observaciones) + "." ;
                  }
                  AV25band_ = 1 ;
                  new ptbus020_(context ).execute( ref  A11TTBUS_Id, ref  A12TTBUS_Descripcion, ref  AV19TTBUS20_Mensaje, ref  AV27TTBUS20_MotivoEnvio, ref  AV28TTBUS20_Observaciones, ref  AV16USUARIO, ref  AV34TTBUS20_PlazoRecepcion) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12TTBUS_Descripcion", A12TTBUS_Descripcion);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16USUARIO", AV16USUARIO);
               }
            }
            /* End For Each Line */
         }
         if ( nGXsfl_24_fel_idx == 0 )
         {
            nGXsfl_24_idx = 1 ;
            sGXsfl_24_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_24_idx), 4, 0)), 4, "0") ;
            edtavDetalle_Internalname = "vDETALLE_"+sGXsfl_24_idx ;
            edtavGnumeroidentificador_Internalname = "vGNUMEROIDENTIFICADOR_"+sGXsfl_24_idx ;
            edtTTBUS_Id_Internalname = "TTBUS_ID_"+sGXsfl_24_idx ;
            edtTTBUS_Descripcion_Internalname = "TTBUS_DESCRIPCION_"+sGXsfl_24_idx ;
            edtTTBUS_CodPosicion_Internalname = "TTBUS_CODPOSICION_"+sGXsfl_24_idx ;
            cmbavPosicionhacia_Internalname = "vPOSICIONHACIA_"+sGXsfl_24_idx ;
            edtavTtbus2_motivoenvio_Internalname = "vTTBUS2_MOTIVOENVIO_"+sGXsfl_24_idx ;
            edtavTtbus2_plazorecepcion_Internalname = "vTTBUS2_PLAZORECEPCION_"+sGXsfl_24_idx ;
            edtavTtbus2_observaciones_Internalname = "vTTBUS2_OBSERVACIONES_"+sGXsfl_24_idx ;
         }
         nGXsfl_24_fel_idx = 1 ;
         if ( AV25band_ == 1 )
         {
            GXt_char2 = "pdf" ;
            new prep000(context ).execute( ref  AV26NOMBRE_REPORTE, ref  GXt_char2) ;
            AV24TTBUS20_Estacion = GXUtil.WrkSt( context) ;
            /* Window Datatype Object Property */
            AV29ventanapop.Url = formatLink("aptbus020.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV26NOMBRE_REPORTE)) + "," + UrlEncode(StringUtil.RTrim(AV24TTBUS20_Estacion)) + "," + UrlEncode(StringUtil.RTrim(AV16USUARIO)) ;
            AV29ventanapop.SetReturnParms(new Object[] {"AV26NOMBRE_REPORTE","AV24TTBUS20_Estacion","AV16USUARIO"});
            AV29ventanapop.Height = 500 ;
            AV29ventanapop.Width = 1000 ;
            context.NewWindow(AV29ventanapop);
         }
      }

      protected void S112( )
      {
         /* 'CARGA POSICIONES' Routine */
         AV5band = 0 ;
         /* Using cursor H001E6 */
         pr_default.execute(4, new Object[] {AV16USUARIO});
         while ( (pr_default.getStatus(4) != 101) )
         {
            A40TTBUS8_CodUsuario = H001E6_A40TTBUS8_CodUsuario[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A40TTBUS8_CodUsuario", A40TTBUS8_CodUsuario);
            AV5band = 1 ;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(4);
         if ( ( ( AV5band == 1 ) ) || ( ( StringUtil.StrCmp(AV16USUARIO, "SUPERVISOR") == 0 ) ) )
         {
            /* Using cursor H001E7 */
            pr_default.execute(5);
            while ( (pr_default.getStatus(5) != 101) )
            {
               A31W53POS = H001E7_A31W53POS[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A31W53POS", StringUtil.LTrim( StringUtil.Str( (decimal)(A31W53POS), 3, 0)));
               A32W53DES = H001E7_A32W53DES[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32W53DES", A32W53DES);
               /* Using cursor H001E8 */
               pr_default.execute(6, new Object[] {A31W53POS});
               while ( (pr_default.getStatus(6) != 101) )
               {
                  A33TTBUS7_Pos = H001E8_A33TTBUS7_Pos[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
                  A34TTBUS7_Des = H001E8_A34TTBUS7_Des[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34TTBUS7_Des", A34TTBUS7_Des);
                  n34TTBUS7_Des = H001E8_n34TTBUS7_Des[0] ;
                  A34TTBUS7_Des = H001E8_A34TTBUS7_Des[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34TTBUS7_Des", A34TTBUS7_Des);
                  n34TTBUS7_Des = H001E8_n34TTBUS7_Des[0] ;
                  cmbavTtbus7_pos.addItem(StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0), A34TTBUS7_Des, 0);
                  /* Exiting from a For First loop. */
                  if (true) break;
               }
               pr_default.close(6);
               pr_default.readNext(5);
            }
            pr_default.close(5);
         }
         else
         {
            /* Using cursor H001E9 */
            pr_default.execute(7);
            while ( (pr_default.getStatus(7) != 101) )
            {
               A31W53POS = H001E9_A31W53POS[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A31W53POS", StringUtil.LTrim( StringUtil.Str( (decimal)(A31W53POS), 3, 0)));
               A32W53DES = H001E9_A32W53DES[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32W53DES", A32W53DES);
               /* Using cursor H001E10 */
               pr_default.execute(8, new Object[] {A31W53POS});
               while ( (pr_default.getStatus(8) != 101) )
               {
                  A33TTBUS7_Pos = H001E10_A33TTBUS7_Pos[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
                  A35TTBUS7_CodResp = H001E10_A35TTBUS7_CodResp[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35TTBUS7_CodResp", A35TTBUS7_CodResp);
                  A34TTBUS7_Des = H001E10_A34TTBUS7_Des[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34TTBUS7_Des", A34TTBUS7_Des);
                  n34TTBUS7_Des = H001E10_n34TTBUS7_Des[0] ;
                  A34TTBUS7_Des = H001E10_A34TTBUS7_Des[0] ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34TTBUS7_Des", A34TTBUS7_Des);
                  n34TTBUS7_Des = H001E10_n34TTBUS7_Des[0] ;
                  AV17vTTBUS7_Pos = A33TTBUS7_Pos ;
                  if ( StringUtil.StrCmp(A35TTBUS7_CodResp, AV16USUARIO) == 0 )
                  {
                     cmbavTtbus7_pos.addItem(StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0), A34TTBUS7_Des, 0);
                  }
                  else
                  {
                     /* Execute user subroutine: S147 */
                     S147 ();
                     if ( returnInSub )
                     {
                        pr_default.close(8);
                        returnInSub = true;
                        if (true) return;
                     }
                  }
                  /* Exiting from a For First loop. */
                  if (true) break;
               }
               pr_default.close(8);
               pr_default.readNext(7);
            }
            pr_default.close(7);
         }
      }

      protected void S132( )
      {
         /* 'VALIDACIONES' Routine */
         if ( StringUtil.StrCmp(StringUtil.Trim( AV13TTBUS2_MotivoEnvio), "") == 0 )
         {
            AV36validado = 0 ;
            AV25band_ = 1 ;
            AV19TTBUS20_Mensaje = "No hubo cambio de posición por falta de motivo de envío." ;
            new ptbus020_(context ).execute( ref  A11TTBUS_Id, ref  A12TTBUS_Descripcion, ref  AV19TTBUS20_Mensaje, ref  AV27TTBUS20_MotivoEnvio, ref  AV28TTBUS20_Observaciones, ref  AV16USUARIO, ref  AV34TTBUS20_PlazoRecepcion) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12TTBUS_Descripcion", A12TTBUS_Descripcion);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16USUARIO", AV16USUARIO);
         }
         if ( AV36validado == 1 )
         {
            if ( (DateTime.MinValue==AV33TTBUS2_PlazoRecepcion) )
            {
               AV36validado = 0 ;
               AV25band_ = 1 ;
               AV19TTBUS20_Mensaje = "No hubo cambio de posición por falta de plazo límite para recepción." ;
               new ptbus020_(context ).execute( ref  A11TTBUS_Id, ref  A12TTBUS_Descripcion, ref  AV19TTBUS20_Mensaje, ref  AV27TTBUS20_MotivoEnvio, ref  AV28TTBUS20_Observaciones, ref  AV16USUARIO, ref  AV34TTBUS20_PlazoRecepcion) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12TTBUS_Descripcion", A12TTBUS_Descripcion);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16USUARIO", AV16USUARIO);
            }
         }
         if ( AV36validado == 1 )
         {
            if ( AV33TTBUS2_PlazoRecepcion <= Gx_date )
            {
               AV36validado = 0 ;
               AV25band_ = 1 ;
               AV19TTBUS20_Mensaje = "No hubo cambio de posición. El plazo de recepción debe ser una fecha mayor que hoy." ;
               new ptbus020_(context ).execute( ref  A11TTBUS_Id, ref  A12TTBUS_Descripcion, ref  AV19TTBUS20_Mensaje, ref  AV27TTBUS20_MotivoEnvio, ref  AV28TTBUS20_Observaciones, ref  AV16USUARIO, ref  AV34TTBUS20_PlazoRecepcion) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11TTBUS_Id", StringUtil.LTrim( StringUtil.Str( (decimal)(A11TTBUS_Id), 8, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12TTBUS_Descripcion", A12TTBUS_Descripcion);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16USUARIO", AV16USUARIO);
            }
         }
      }

      protected void S122( )
      {
         /* 'POSICIONES DESTINO' Routine */
         AV39item_posicion.gxTpr_W53pos = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV39item_posicion", (Object)(AV39item_posicion));
         AV39item_posicion.gxTpr_W53des = "" ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV39item_posicion", (Object)(AV39item_posicion));
         AV49GXV1 = 1 ;
         while ( AV49GXV1 <= AV38Sdt_Posiciones.Count )
         {
            AV39item_posicion = ((SdtSDT_Posiciones)AV38Sdt_Posiciones.Item(AV49GXV1)) ;
            cmbavPosicionhacia.addItem(StringUtil.Str( (decimal)(AV39item_posicion.gxTpr_W53pos), 3, 0), AV39item_posicion.gxTpr_W53des, 0);
            AV49GXV1 = (int)(AV49GXV1+1) ;
         }
      }

      protected void S147( )
      {
         /* 'POSICIONES GRILLA' Routine */
         /* Using cursor H001E11 */
         pr_default.execute(9);
         while ( (pr_default.getStatus(9) != 101) )
         {
            A31W53POS = H001E11_A31W53POS[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A31W53POS", StringUtil.LTrim( StringUtil.Str( (decimal)(A31W53POS), 3, 0)));
            A32W53DES = H001E11_A32W53DES[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32W53DES", A32W53DES);
            AV37W53POS = A31W53POS ;
            /* Using cursor H001E12 */
            pr_default.execute(10, new Object[] {AV37W53POS, AV16USUARIO, AV17vTTBUS7_Pos});
            while ( (pr_default.getStatus(10) != 101) )
            {
               A39TTBUS7_CodUsuario = H001E12_A39TTBUS7_CodUsuario[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39TTBUS7_CodUsuario", A39TTBUS7_CodUsuario);
               A33TTBUS7_Pos = H001E12_A33TTBUS7_Pos[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33TTBUS7_Pos", StringUtil.LTrim( StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0)));
               A51TTBUS7_RespAux = H001E12_A51TTBUS7_RespAux[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A51TTBUS7_RespAux", StringUtil.Str( (decimal)(A51TTBUS7_RespAux), 1, 0));
               A34TTBUS7_Des = H001E12_A34TTBUS7_Des[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34TTBUS7_Des", A34TTBUS7_Des);
               n34TTBUS7_Des = H001E12_n34TTBUS7_Des[0] ;
               A34TTBUS7_Des = H001E12_A34TTBUS7_Des[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34TTBUS7_Des", A34TTBUS7_Des);
               n34TTBUS7_Des = H001E12_n34TTBUS7_Des[0] ;
               if ( A51TTBUS7_RespAux == 1 )
               {
                  cmbavTtbus7_pos.addItem(StringUtil.Str( (decimal)(A33TTBUS7_Pos), 3, 0), A34TTBUS7_Des, 0);
               }
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(10);
            pr_default.readNext(9);
         }
         pr_default.close(9);
      }

      protected void wb_table1_2_1E2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            sStyleString = sStyleString + " height: " + StringUtil.LTrim( StringUtil.Str( (decimal)(87), 10, 0)) + "px" + ";" ;
            sStyleString = sStyleString + " width: " + StringUtil.LTrim( StringUtil.Str( (decimal)(724), 10, 0)) + "px" + ";" ;
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+"\">") ;
            ClassString = "ErrorViewer" ;
            StyleString = "" ;
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "Label" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, 1, 1, 0, "SE MUESTRAN LOS BIENES DE LA POSICIÓN SELECCIONADA", "", "", "", 0, lblTextblock1_Jsonclick, "", StyleString, ClassString, "HLP_HTBUS020.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_11_1E2( true) ;
         }
         else
         {
            wb_table2_11_1E2( false) ;
         }
         return  ;
      }

      protected void wb_table2_11_1E2e( bool wbgen )
      {
         if ( wbgen )
         {
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
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Nº Etiqueta") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Nº Bien") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" width="+StringUtil.LTrim( StringUtil.Str( (decimal)(260), 4, 0))+"px"+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Descripción") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Cod. Posición Actual Bien") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Posición Destino") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" width="+StringUtil.LTrim( StringUtil.Str( (decimal)(230), 4, 0))+"px"+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Motivo Envío") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Plazo Límite Recepción") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" width="+StringUtil.LTrim( StringUtil.Str( (decimal)(410), 4, 0))+"px"+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Observaciones") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlTextNl( "</tr>") ;
            }
            else
            {
               Grid1Container.Clear();
               Grid1Container.SetWrapped(nGXWrapped);
               Grid1Container.AddObjectProperty("GridName", "Grid1");
               Grid1Container.AddObjectProperty("Class", "Grid");
               Grid1Container.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Backcolorstyle), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("CmpContext", "");
               Grid1Container.AddObjectProperty("InMasterPage", "false");
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", context.convertURL( AV31detalle));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( AV32gNumeroIdentificador));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavGnumeroidentificador_Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A11TTBUS_Id), 8, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A12TTBUS_Descripcion));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A37TTBUS_CodPosicion), 3, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8PosicionHacia), 3, 0, ".", "")));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbavPosicionhacia.Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( AV13TTBUS2_MotivoEnvio));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavTtbus2_motivoenvio_Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", context.localUtil.Format(AV33TTBUS2_PlazoRecepcion, "99/99/9999"));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavTtbus2_plazorecepcion_Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( AV14TTBUS2_Observaciones));
               Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavTtbus2_observaciones_Enabled), 5, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Container.AddObjectProperty("Allowselection", "false");
               Grid1Container.AddObjectProperty("Allowcollapsing", "false");
               Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 9, 0, ".", "")));
            }
         }
         if ( wbEnd == 24 )
         {
            wbEnd = 0 ;
            nRC_Grid1 = (short)(nGXsfl_24_idx-1) ;
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
            }
            else
            {
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
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 36,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttButton1_Internalname, "Confirmar Cambios", "Confirmar Cambios", "", StyleString, ClassString, 1, 1, "rounded", 5, bttButton1_Jsonclick, "E\\'CONFIRMAR CAMBIOS\\'.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(24), 3, 0)+","+"null"+");", "", "HLP_HTBUS020.htm");
            context.WriteHtmlText( "&nbsp;&nbsp; ") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_1E2e( true) ;
         }
         else
         {
            wb_table1_2_1E2e( false) ;
         }
      }

      protected void wb_table2_11_1E2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable2_Internalname, tblTable2_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock2_Internalname, 1, 1, 0, "Posición de Origen:", "", "", "", 0, lblTextblock2_Jsonclick, "", StyleString, ClassString, "HLP_HTBUS020.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'" + sGXsfl_24_idx + "',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavTtbus7_pos, cmbavTtbus7_pos_Internalname, StringUtil.Str( (decimal)(AV15TTBUS7_Pos), 3, 0), "", "int", 1, 1, 0, 1, 0, 3, "chr", 0, "", StyleString, ClassString, "", 0, cmbavTtbus7_pos_Jsonclick, "", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(16);\"", true, "HLP_HTBUS020.htm");
            cmbavTtbus7_pos.CurrentValue = StringUtil.Str( (decimal)(AV15TTBUS7_Pos), 3, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavTtbus7_pos_Internalname, "Values", (String)(cmbavTtbus7_pos.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock3_Internalname, 1, 1, 0, "Responsable:", "", "", "", 0, lblTextblock3_Jsonclick, "", StyleString, ClassString, "HLP_HTBUS020.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'" + sGXsfl_24_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavSec_dre_Internalname, StringUtil.RTrim( AV9SEC_DRE), "", 50, "chr", 1, "row", 50, 1, edtavSec_dre_Enabled, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV9SEC_DRE, "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(21);\"", 0, edtavSec_dre_Jsonclick, "", 0, 1, 1, true, "left", "HLP_HTBUS020.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_11_1E2e( true) ;
         }
         else
         {
            wb_table2_11_1E2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV10SISTEMA = (String)getParm(obj,0) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10SISTEMA", AV10SISTEMA);
         AV16USUARIO = (String)getParm(obj,1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16USUARIO", AV16USUARIO);
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
         PA1E2( ) ;
         WS1E2( ) ;
         WE1E2( ) ;
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
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?19293239");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         if ( nGXWrapped != 1 )
         {
            context.AddJavascriptSource("messages.spa.js", "?42940");
            context.AddJavascriptSource("htbus020.js", "?19293239");
         }
         /* End function include_jscripts */
      }

      protected void sendrow_242( )
      {
         WB1E0( ) ;
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
            if ( ((int)(nGXsfl_24_idx) % (2)) == 0 )
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
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<tr ") ;
            context.WriteHtmlText( " class=\""+subGrid1_Linesclass+"\" style=\""+""+"\"") ;
            context.WriteHtmlText( ">") ;
         }
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Active Bitmap Variable */
         TempTags = " " + ((edtavDetalle_Enabled!=0)&&(edtavDetalle_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 25,'',false,'',24)\"" : " ") ;
         ClassString = "Image" ;
         StyleString = "" ;
         Grid1Row.AddColumnProperties("bitmap", 2, isAjaxCallMode( ), new Object[] {(String)edtavDetalle_Internalname,(String)"",(String)AV31detalle,(String)"Modern",(short)-1,(short)1,(String)"",(String)"Ver Identificadores",(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"",(short)0,(short)0,(String)"",(String)"",(short)7,(String)edtavDetalle_Jsonclick,(String)"'"+""+"'"+",false,"+"'"+"e151e2_client"+"'",(String)StyleString,(String)ClassString,(String)"",(String)""+TempTags,(String)"''",(String)""});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         TempTags = " " + ((edtavGnumeroidentificador_Enabled!=0)&&(edtavGnumeroidentificador_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 26,'',false,'"+sGXsfl_24_idx+"',24)\"" : " ") ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavGnumeroidentificador_Internalname,StringUtil.RTrim( AV32gNumeroIdentificador),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)80,(short)-1,(int)edtavGnumeroidentificador_Enabled,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( AV32gNumeroIdentificador, "")),TempTags+((edtavGnumeroidentificador_Enabled!=0)&&(edtavGnumeroidentificador_Visible!=0) ? " onchange=\"gx.evt.onchange(this)\" " : " ")+((edtavGnumeroidentificador_Enabled!=0)&&(edtavGnumeroidentificador_Visible!=0) ? " onblur=\""+""+";gx.evt.onblur(26);\"" : " "),(short)0,(String)edtavGnumeroidentificador_Jsonclick,(String)"",(short)24,(short)1,(short)1,(bool)true,(String)"left"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS_Id_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A11TTBUS_Id), 8, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)8,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A11TTBUS_Id), "ZZZZZZZ9"),(String)"",(short)0,(String)edtTTBUS_Id_Jsonclick,(String)"",(short)24,(short)1,(short)1,(bool)true,(String)"right"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS_Descripcion_Internalname,StringUtil.RTrim( A12TTBUS_Descripcion),(String)"",(short)260,(String)"px",(short)17,(String)"",(short)50,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A12TTBUS_Descripcion, "@!")),(String)"",(short)0,(String)edtTTBUS_Descripcion_Jsonclick,(String)"",(short)24,(short)1,(short)0,(bool)true,(String)"left"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTTBUS_CodPosicion_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A37TTBUS_CodPosicion), 3, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)3,(short)0,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A37TTBUS_CodPosicion), "ZZ9"),(String)"",(short)0,(String)edtTTBUS_CodPosicion_Jsonclick,(String)"",(short)24,(short)1,(short)1,(bool)true,(String)"right"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         ClassString = "Attribute" ;
         StyleString = "" ;
         TempTags = " " + ((cmbavPosicionhacia.Enabled!=0)&&(cmbavPosicionhacia.Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 30,'',false,'"+sGXsfl_24_idx+"',24)\"" : " ") ;
         GXCCtl = "vPOSICIONHACIA_" + sGXsfl_24_idx ;
         cmbavPosicionhacia.Name = GXCCtl ;
         cmbavPosicionhacia.WebTags = "" ;
         gxdynajaxctrlcodr.Add(StringUtil.Str( (decimal)(0), 1, 0));
         gxdynajaxctrldescr.Add("SELECCIONAR POSICIÓN DESTINO");
         if ( ( cmbavPosicionhacia.ItemCount > 0 ) && (0==AV8PosicionHacia) )
         {
            AV8PosicionHacia = (short)(NumberUtil.Val( cmbavPosicionhacia.getItemValue(1), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8PosicionHacia", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8PosicionHacia), 3, 0)));
         }
         /* ComboBox */
         Grid1Row.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbavPosicionhacia,(String)cmbavPosicionhacia_Internalname,StringUtil.Str( (decimal)(AV8PosicionHacia), 3, 0),(String)"",(String)"int",(short)-1,cmbavPosicionhacia.Enabled,(short)1,(short)1,(short)0,(short)0,(String)"px",(short)0,(String)"",(String)StyleString,(String)ClassString,(String)"",(short)0,(String)cmbavPosicionhacia_Jsonclick,(String)"",TempTags+((cmbavPosicionhacia.Enabled!=0)&&(cmbavPosicionhacia.Visible!=0) ? " onchange=\"gx.evt.onchange(this)\" " : " ")+((cmbavPosicionhacia.Enabled!=0)&&(cmbavPosicionhacia.Visible!=0) ? " onblur=\""+""+";gx.evt.onblur(30);\"" : " "),(bool)true});
         cmbavPosicionhacia.CurrentValue = StringUtil.Str( (decimal)(AV8PosicionHacia), 3, 0) ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavPosicionhacia_Internalname, "Values", (String)(cmbavPosicionhacia.ToJavascriptSource()));
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         TempTags = " " + ((edtavTtbus2_motivoenvio_Enabled!=0)&&(edtavTtbus2_motivoenvio_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 31,'',false,'"+sGXsfl_24_idx+"',24)\"" : " ") ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavTtbus2_motivoenvio_Internalname,StringUtil.RTrim( AV13TTBUS2_MotivoEnvio),(String)"",(short)230,(String)"px",(short)17,(String)"",(short)100,(short)-1,(int)edtavTtbus2_motivoenvio_Enabled,(short)1,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( AV13TTBUS2_MotivoEnvio, "@!")),TempTags+((edtavTtbus2_motivoenvio_Enabled!=0)&&(edtavTtbus2_motivoenvio_Visible!=0) ? " onchange=\"gx.evt.onchange(this)\" " : " ")+((edtavTtbus2_motivoenvio_Enabled!=0)&&(edtavTtbus2_motivoenvio_Visible!=0) ? " onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(31);\"" : " "),(short)0,(String)edtavTtbus2_motivoenvio_Jsonclick,(String)"",(short)24,(short)1,(short)0,(bool)true,(String)"left"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         TempTags = " " + ((edtavTtbus2_plazorecepcion_Enabled!=0)&&(edtavTtbus2_plazorecepcion_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 32,'',false,'"+sGXsfl_24_idx+"',24)\"" : " ") ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavTtbus2_plazorecepcion_Internalname,context.localUtil.Format(AV33TTBUS2_PlazoRecepcion, "99/99/9999"),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)10,(short)-1,(int)edtavTtbus2_plazorecepcion_Enabled,(short)1,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( AV33TTBUS2_PlazoRecepcion, "99/99/9999"),TempTags+((edtavTtbus2_plazorecepcion_Enabled!=0)&&(edtavTtbus2_plazorecepcion_Visible!=0) ? " onchange=\"gx.evt.onchange(this)\" " : " ")+((edtavTtbus2_plazorecepcion_Enabled!=0)&&(edtavTtbus2_plazorecepcion_Visible!=0) ? " onblur=\""+"gx.date.valid_date(this, 10,'DMY',0,24,'spa',false,0);"+";gx.evt.onblur(32);\"" : " "),(short)0,(String)edtavTtbus2_plazorecepcion_Jsonclick,(String)"",(short)24,(short)1,(short)-1,(bool)true,(String)"right"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         TempTags = " " + ((edtavTtbus2_observaciones_Enabled!=0)&&(edtavTtbus2_observaciones_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 33,'',false,'"+sGXsfl_24_idx+"',24)\"" : " ") ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavTtbus2_observaciones_Internalname,StringUtil.RTrim( AV14TTBUS2_Observaciones),(String)"",(short)410,(String)"px",(short)17,(String)"",(short)400,(short)-1,(int)edtavTtbus2_observaciones_Enabled,(short)1,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( AV14TTBUS2_Observaciones, "@!")),TempTags+((edtavTtbus2_observaciones_Enabled!=0)&&(edtavTtbus2_observaciones_Visible!=0) ? " onchange=\"gx.evt.onchange(this)\" " : " ")+((edtavTtbus2_observaciones_Enabled!=0)&&(edtavTtbus2_observaciones_Visible!=0) ? " onblur=\""+"this.value=this.value.toUpperCase();"+";gx.evt.onblur(33);\"" : " "),(short)0,(String)edtavTtbus2_observaciones_Jsonclick,(String)"",(short)24,(short)1,(short)0,(bool)true,(String)"left"});
         Grid1Container.AddRow(Grid1Row);
         nGXsfl_24_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_24_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_24_idx+1)) ;
         sGXsfl_24_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_24_idx), 4, 0)), 4, "0") ;
         edtavDetalle_Internalname = "vDETALLE_"+sGXsfl_24_idx ;
         edtavGnumeroidentificador_Internalname = "vGNUMEROIDENTIFICADOR_"+sGXsfl_24_idx ;
         edtTTBUS_Id_Internalname = "TTBUS_ID_"+sGXsfl_24_idx ;
         edtTTBUS_Descripcion_Internalname = "TTBUS_DESCRIPCION_"+sGXsfl_24_idx ;
         edtTTBUS_CodPosicion_Internalname = "TTBUS_CODPOSICION_"+sGXsfl_24_idx ;
         cmbavPosicionhacia_Internalname = "vPOSICIONHACIA_"+sGXsfl_24_idx ;
         edtavTtbus2_motivoenvio_Internalname = "vTTBUS2_MOTIVOENVIO_"+sGXsfl_24_idx ;
         edtavTtbus2_plazorecepcion_Internalname = "vTTBUS2_PLAZORECEPCION_"+sGXsfl_24_idx ;
         edtavTtbus2_observaciones_Internalname = "vTTBUS2_OBSERVACIONES_"+sGXsfl_24_idx ;
         /* End function sendrow_242 */
      }

      protected void init_default_properties( )
      {
         lblTextblock1_Internalname = "TEXTBLOCK1" ;
         lblTextblock2_Internalname = "TEXTBLOCK2" ;
         cmbavTtbus7_pos_Internalname = "vTTBUS7_POS" ;
         lblTextblock3_Internalname = "TEXTBLOCK3" ;
         edtavSec_dre_Internalname = "vSEC_DRE" ;
         tblTable2_Internalname = "TABLE2" ;
         bttButton1_Internalname = "BUTTON1" ;
         tblTable1_Internalname = "TABLE1" ;
         Form.Internalname = "FORM" ;
         subGrid1_Internalname = "GRID1" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         edtavTtbus2_observaciones_Jsonclick = "" ;
         edtavTtbus2_observaciones_Visible = -1 ;
         edtavTtbus2_plazorecepcion_Jsonclick = "" ;
         edtavTtbus2_plazorecepcion_Visible = -1 ;
         edtavTtbus2_motivoenvio_Jsonclick = "" ;
         edtavTtbus2_motivoenvio_Visible = -1 ;
         cmbavPosicionhacia_Jsonclick = "" ;
         cmbavPosicionhacia.Visible = -1 ;
         edtTTBUS_CodPosicion_Jsonclick = "" ;
         edtTTBUS_Descripcion_Jsonclick = "" ;
         edtTTBUS_Id_Jsonclick = "" ;
         edtavGnumeroidentificador_Jsonclick = "" ;
         edtavGnumeroidentificador_Visible = -1 ;
         edtavDetalle_Jsonclick = "" ;
         edtavDetalle_Visible = -1 ;
         edtavDetalle_Enabled = 1 ;
         edtavSec_dre_Jsonclick = "" ;
         edtavSec_dre_Enabled = 1 ;
         cmbavTtbus7_pos_Jsonclick = "" ;
         edtavGnumeroidentificador_Enabled = 1 ;
         subGrid1_Class = "Grid" ;
         subGrid1_Backcolorstyle = 3 ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Administrador de Cambio de Posiciones" ;
         cmbavPosicionhacia.Enabled = 1 ;
         edtavTtbus2_motivoenvio_Enabled = 1 ;
         edtavTtbus2_observaciones_Enabled = 1 ;
         edtavTtbus2_plazorecepcion_Enabled = 1 ;
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
         wcpOAV10SISTEMA = "" ;
         wcpOAV16USUARIO = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         A12TTBUS_Descripcion = "" ;
         A47TTBUS2_MotivoEnvio = "" ;
         A87TTBUS2_Observaciones = "" ;
         edtavTtbus2_plazorecepcion_Internalname = "" ;
         edtavTtbus2_observaciones_Internalname = "" ;
         edtavTtbus2_motivoenvio_Internalname = "" ;
         cmbavPosicionhacia_Internalname = "" ;
         Gx_date = DateTime.MinValue ;
         edtavGnumeroidentificador_Internalname = "" ;
         GXCCtl = "" ;
         AV38Sdt_Posiciones = new GxObjectCollection( context, "SDT_Posiciones", "MarianoTesis", "SdtSDT_Posiciones", "GeneXus.Programs");
         sDynURL = "" ;
         FormProcess = "" ;
         GX_FocusControl = "" ;
         Form = new GXWebForm();
         sPrefix = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         edtavDetalle_Internalname = "" ;
         edtTTBUS_Id_Internalname = "" ;
         edtTTBUS_Descripcion_Internalname = "" ;
         edtTTBUS_CodPosicion_Internalname = "" ;
         AV31detalle = "" ;
         AV32gNumeroIdentificador = "" ;
         AV13TTBUS2_MotivoEnvio = "" ;
         AV33TTBUS2_PlazoRecepcion = DateTime.MinValue ;
         AV14TTBUS2_Observaciones = "" ;
         gxdynajaxctrlcodr = new GeneXus.Utils.GxStringCollection();
         gxdynajaxctrldescr = new GeneXus.Utils.GxStringCollection();
         gxwrpcisep = "" ;
         scmdbuf = "" ;
         l12TTBUS_Descripcion = "" ;
         H001E2_A12TTBUS_Descripcion = new String[] {""} ;
         l47TTBUS2_MotivoEnvio = "" ;
         H001E3_A47TTBUS2_MotivoEnvio = new String[] {""} ;
         l87TTBUS2_Observaciones = "" ;
         H001E4_A87TTBUS2_Observaciones = new String[] {""} ;
         H001E4_n87TTBUS2_Observaciones = new bool[] {false} ;
         Grid1Container = new GXWebGrid( context);
         H001E5_A23TTBUS_Estado = new short[1] ;
         H001E5_A37TTBUS_CodPosicion = new short[1] ;
         H001E5_A12TTBUS_Descripcion = new String[] {""} ;
         H001E5_A11TTBUS_Id = new int[1] ;
         AV9SEC_DRE = "" ;
         AV30Context = new SdtContext(context);
         AV6dSEC_CRE = "" ;
         AV18SESION = new GxWebSession( context);
         AV27TTBUS20_MotivoEnvio = "" ;
         AV28TTBUS20_Observaciones = "" ;
         AV34TTBUS20_PlazoRecepcion = DateTime.MinValue ;
         AV21TTBUS7_Des = "" ;
         AV7hSEC_CRE = "" ;
         AV11TTBUS2_FechaEnvio = (DateTime)(DateTime.MinValue) ;
         AV12TTBUS2_FechaRecepcion = (DateTime)(DateTime.MinValue) ;
         AV19TTBUS20_Mensaje = "" ;
         AV26NOMBRE_REPORTE = "" ;
         AV24TTBUS20_Estacion = "" ;
         AV29ventanapop = new GXWindow();
         H001E6_A40TTBUS8_CodUsuario = new String[] {""} ;
         A40TTBUS8_CodUsuario = "" ;
         H001E7_A31W53POS = new short[1] ;
         H001E7_A32W53DES = new String[] {""} ;
         A32W53DES = "" ;
         H001E8_A33TTBUS7_Pos = new short[1] ;
         H001E8_A34TTBUS7_Des = new String[] {""} ;
         H001E8_n34TTBUS7_Des = new bool[] {false} ;
         A34TTBUS7_Des = "" ;
         H001E9_A31W53POS = new short[1] ;
         H001E9_A32W53DES = new String[] {""} ;
         H001E10_A33TTBUS7_Pos = new short[1] ;
         H001E10_A35TTBUS7_CodResp = new String[] {""} ;
         H001E10_A34TTBUS7_Des = new String[] {""} ;
         H001E10_n34TTBUS7_Des = new bool[] {false} ;
         A35TTBUS7_CodResp = "" ;
         AV39item_posicion = new SdtSDT_Posiciones(context);
         H001E11_A31W53POS = new short[1] ;
         H001E11_A32W53DES = new String[] {""} ;
         H001E12_A39TTBUS7_CodUsuario = new String[] {""} ;
         H001E12_A33TTBUS7_Pos = new short[1] ;
         H001E12_A51TTBUS7_RespAux = new short[1] ;
         H001E12_A34TTBUS7_Des = new String[] {""} ;
         H001E12_n34TTBUS7_Des = new bool[] {false} ;
         A39TTBUS7_CodUsuario = "" ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         lblTextblock1_Jsonclick = "" ;
         subGrid1_Linesclass = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GXt_char4 = "" ;
         GXt_char5 = "" ;
         GXt_char6 = "" ;
         GXt_char7 = "" ;
         GXt_char8 = "" ;
         GXt_char9 = "" ;
         Grid1Column = new GXWebColumn();
         TempTags = "" ;
         bttButton1_Jsonclick = "" ;
         lblTextblock2_Jsonclick = "" ;
         lblTextblock3_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         Grid1Row = new GXWebRow();
         ROClassString = "" ;
         GXt_char10 = "" ;
         GXt_char11 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.htbus020__default(),
            new Object[][] {
                new Object[] {
               H001E2_A12TTBUS_Descripcion
               }
               , new Object[] {
               H001E3_A47TTBUS2_MotivoEnvio
               }
               , new Object[] {
               H001E4_A87TTBUS2_Observaciones, H001E4_n87TTBUS2_Observaciones
               }
               , new Object[] {
               H001E5_A23TTBUS_Estado, H001E5_A37TTBUS_CodPosicion, H001E5_A12TTBUS_Descripcion, H001E5_A11TTBUS_Id
               }
               , new Object[] {
               H001E6_A40TTBUS8_CodUsuario
               }
               , new Object[] {
               H001E7_A31W53POS, H001E7_A32W53DES
               }
               , new Object[] {
               H001E8_A33TTBUS7_Pos, H001E8_A34TTBUS7_Des, H001E8_n34TTBUS7_Des
               }
               , new Object[] {
               H001E9_A31W53POS, H001E9_A32W53DES
               }
               , new Object[] {
               H001E10_A33TTBUS7_Pos, H001E10_A35TTBUS7_CodResp, H001E10_A34TTBUS7_Des, H001E10_n34TTBUS7_Des
               }
               , new Object[] {
               H001E11_A31W53POS, H001E11_A32W53DES
               }
               , new Object[] {
               H001E12_A39TTBUS7_CodUsuario, H001E12_A33TTBUS7_Pos, H001E12_A51TTBUS7_RespAux, H001E12_A34TTBUS7_Des, H001E12_n34TTBUS7_Des
               }
            }
         );
         Gx_date = DateTimeUtil.Today( ) ;
         /* GeneXus formulas. */
         Gx_date = DateTimeUtil.Today( ) ;
         context.Gx_err = 0 ;
         edtavSec_dre_Enabled = 0 ;
         edtavGnumeroidentificador_Enabled = 0 ;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_Grid1 ;
      private short nGXsfl_24_idx=1 ;
      private short AV15TTBUS7_Pos ;
      private short AV8PosicionHacia ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short nGXWrapped ;
      private short wbEnd ;
      private short wbStart ;
      private short A37TTBUS_CodPosicion ;
      private short nDonePA ;
      private short A23TTBUS_Estado ;
      private short AV25band_ ;
      private short nGXsfl_24_fel_idx=1 ;
      private short AV36validado ;
      private short GXt_int3 ;
      private short AV5band ;
      private short A31W53POS ;
      private short A33TTBUS7_Pos ;
      private short AV17vTTBUS7_Pos ;
      private short AV37W53POS ;
      private short A51TTBUS7_RespAux ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short subGrid1_Collapsed ;
      private short subGrid1_Backstyle ;
      private int edtavTtbus2_plazorecepcion_Enabled ;
      private int edtavTtbus2_observaciones_Enabled ;
      private int edtavTtbus2_motivoenvio_Enabled ;
      private int edtavSec_dre_Enabled ;
      private int edtavGnumeroidentificador_Enabled ;
      private int A11TTBUS_Id ;
      private int gxdynajaxindex ;
      private int subGrid1_Islastpage ;
      private int GRID1_nFirstRecordOnPage ;
      private int GRID1_nCurrentRecord ;
      private int AV49GXV1 ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private int edtavDetalle_Enabled ;
      private int edtavDetalle_Visible ;
      private int edtavGnumeroidentificador_Visible ;
      private int edtavTtbus2_motivoenvio_Visible ;
      private int edtavTtbus2_plazorecepcion_Visible ;
      private int edtavTtbus2_observaciones_Visible ;
      private String AV10SISTEMA ;
      private String AV16USUARIO ;
      private String wcpOAV10SISTEMA ;
      private String wcpOAV16USUARIO ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_24_idx="0001" ;
      private String edtavTtbus2_plazorecepcion_Internalname ;
      private String edtavTtbus2_observaciones_Internalname ;
      private String edtavTtbus2_motivoenvio_Internalname ;
      private String cmbavPosicionhacia_Internalname ;
      private String edtavSec_dre_Internalname ;
      private String edtavGnumeroidentificador_Internalname ;
      private String GXCCtl ;
      private String sDynURL ;
      private String FormProcess ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavDetalle_Internalname ;
      private String edtTTBUS_Id_Internalname ;
      private String edtTTBUS_Descripcion_Internalname ;
      private String edtTTBUS_CodPosicion_Internalname ;
      private String cmbavTtbus7_pos_Internalname ;
      private String gxwrpcisep ;
      private String scmdbuf ;
      private String AV9SEC_DRE ;
      private String AV6dSEC_CRE ;
      private String sGXsfl_24_fel_idx="0001" ;
      private String AV21TTBUS7_Des ;
      private String AV7hSEC_CRE ;
      private String AV26NOMBRE_REPORTE ;
      private String AV24TTBUS20_Estacion ;
      private String A40TTBUS8_CodUsuario ;
      private String A32W53DES ;
      private String A34TTBUS7_Des ;
      private String A35TTBUS7_CodResp ;
      private String A39TTBUS7_CodUsuario ;
      private String sStyleString ;
      private String tblTable1_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String lblTextblock1_Internalname ;
      private String lblTextblock1_Jsonclick ;
      private String subGrid1_Internalname ;
      private String subGrid1_Class ;
      private String subGrid1_Linesclass ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String GXt_char4 ;
      private String GXt_char5 ;
      private String GXt_char6 ;
      private String GXt_char7 ;
      private String GXt_char8 ;
      private String GXt_char9 ;
      private String TempTags ;
      private String bttButton1_Internalname ;
      private String bttButton1_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblock2_Internalname ;
      private String lblTextblock2_Jsonclick ;
      private String cmbavTtbus7_pos_Jsonclick ;
      private String lblTextblock3_Internalname ;
      private String lblTextblock3_Jsonclick ;
      private String edtavSec_dre_Jsonclick ;
      private String edtavDetalle_Jsonclick ;
      private String ROClassString ;
      private String edtavGnumeroidentificador_Jsonclick ;
      private String edtTTBUS_Id_Jsonclick ;
      private String edtTTBUS_Descripcion_Jsonclick ;
      private String edtTTBUS_CodPosicion_Jsonclick ;
      private String cmbavPosicionhacia_Jsonclick ;
      private String edtavTtbus2_motivoenvio_Jsonclick ;
      private String edtavTtbus2_plazorecepcion_Jsonclick ;
      private String GXt_char10 ;
      private String edtavTtbus2_observaciones_Jsonclick ;
      private String GXt_char11 ;
      private DateTime AV11TTBUS2_FechaEnvio ;
      private DateTime AV12TTBUS2_FechaRecepcion ;
      private DateTime Gx_date ;
      private DateTime AV33TTBUS2_PlazoRecepcion ;
      private DateTime AV34TTBUS20_PlazoRecepcion ;
      private bool entryPointCalled ;
      private bool n87TTBUS2_Observaciones ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private bool n34TTBUS7_Des ;
      private String A12TTBUS_Descripcion ;
      private String A47TTBUS2_MotivoEnvio ;
      private String A87TTBUS2_Observaciones ;
      private String AV32gNumeroIdentificador ;
      private String AV13TTBUS2_MotivoEnvio ;
      private String AV14TTBUS2_Observaciones ;
      private String l12TTBUS_Descripcion ;
      private String l47TTBUS2_MotivoEnvio ;
      private String l87TTBUS2_Observaciones ;
      private String AV27TTBUS20_MotivoEnvio ;
      private String AV28TTBUS20_Observaciones ;
      private String AV19TTBUS20_Mensaje ;
      private String AV31detalle ;
      private GxWebSession AV18SESION ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private String aP0_SISTEMA ;
      private String aP1_USUARIO ;
      private GXCombobox cmbavTtbus7_pos ;
      private GXCombobox cmbavPosicionhacia ;
      private IDataStoreProvider pr_default ;
      private String[] H001E2_A12TTBUS_Descripcion ;
      private String[] H001E3_A47TTBUS2_MotivoEnvio ;
      private String[] H001E4_A87TTBUS2_Observaciones ;
      private bool[] H001E4_n87TTBUS2_Observaciones ;
      private short[] H001E5_A23TTBUS_Estado ;
      private short[] H001E5_A37TTBUS_CodPosicion ;
      private String[] H001E5_A12TTBUS_Descripcion ;
      private int[] H001E5_A11TTBUS_Id ;
      private String[] H001E6_A40TTBUS8_CodUsuario ;
      private short[] H001E7_A31W53POS ;
      private String[] H001E7_A32W53DES ;
      private short[] H001E8_A33TTBUS7_Pos ;
      private String[] H001E8_A34TTBUS7_Des ;
      private bool[] H001E8_n34TTBUS7_Des ;
      private short[] H001E9_A31W53POS ;
      private String[] H001E9_A32W53DES ;
      private short[] H001E10_A33TTBUS7_Pos ;
      private String[] H001E10_A35TTBUS7_CodResp ;
      private String[] H001E10_A34TTBUS7_Des ;
      private bool[] H001E10_n34TTBUS7_Des ;
      private short[] H001E11_A31W53POS ;
      private String[] H001E11_A32W53DES ;
      private String[] H001E12_A39TTBUS7_CodUsuario ;
      private short[] H001E12_A33TTBUS7_Pos ;
      private short[] H001E12_A51TTBUS7_RespAux ;
      private String[] H001E12_A34TTBUS7_Des ;
      private bool[] H001E12_n34TTBUS7_Des ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      [ObjectCollection(ItemType=typeof( SdtSDT_Posiciones ))]
      private IGxCollection AV38Sdt_Posiciones ;
      private GXWebForm Form ;
      private GXWindow AV29ventanapop ;
      private SdtContext AV30Context ;
      private SdtSDT_Posiciones AV39item_posicion ;
   }

   public class htbus020__default : DataStoreHelperBase, IDataStoreHelper
   {
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
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH001E2 ;
          prmH001E2 = new Object[] {
          new Object[] {"@TTBUS_Descripcion",SqlDbType.VarChar,50,0}
          } ;
          Object[] prmH001E3 ;
          prmH001E3 = new Object[] {
          new Object[] {"@TTBUS2_MotivoEnvio",SqlDbType.VarChar,100,0}
          } ;
          Object[] prmH001E4 ;
          prmH001E4 = new Object[] {
          new Object[] {"@TTBUS2_Observaciones",SqlDbType.VarChar,400,0}
          } ;
          Object[] prmH001E5 ;
          prmH001E5 = new Object[] {
          new Object[] {"@AV15TTBUS7_Pos",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmH001E6 ;
          prmH001E6 = new Object[] {
          new Object[] {"@AV16USUARIO",SqlDbType.Char,16,0}
          } ;
          Object[] prmH001E7 ;
          prmH001E7 = new Object[] {
          } ;
          Object[] prmH001E8 ;
          prmH001E8 = new Object[] {
          new Object[] {"@W53POS",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmH001E9 ;
          prmH001E9 = new Object[] {
          } ;
          Object[] prmH001E10 ;
          prmH001E10 = new Object[] {
          new Object[] {"@W53POS",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmH001E11 ;
          prmH001E11 = new Object[] {
          } ;
          Object[] prmH001E12 ;
          prmH001E12 = new Object[] {
          new Object[] {"@AV37W53POS",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@AV16USUARIO",SqlDbType.Char,16,0} ,
          new Object[] {"@AV17vTTBUS7_Pos",SqlDbType.SmallInt,3,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H001E2", "SELECT DISTINCT TOP 5 [TTBUS_Descripcion] FROM [TTBUS000] WITH (NOLOCK) WHERE UPPER(CAST([TTBUS_Descripcion] AS char(50))) like UPPER(CAST(@TTBUS_Descripcion AS char(50))) ORDER BY [TTBUS_Descripcion] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001E2,0,0,true,false )
             ,new CursorDef("H001E3", "SELECT DISTINCT TOP 5 [TTBUS2_MotivoEnvio] FROM [TTBUS002] WITH (NOLOCK) WHERE UPPER(CAST([TTBUS2_MotivoEnvio] AS char(100))) like '%' + UPPER(CAST(@TTBUS2_MotivoEnvio AS char(100))) ORDER BY [TTBUS2_MotivoEnvio] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001E3,0,0,true,false )
             ,new CursorDef("H001E4", "SELECT DISTINCT TOP 5 [TTBUS2_Observaciones] FROM [TTBUS002] WITH (NOLOCK) WHERE UPPER(CAST([TTBUS2_Observaciones] AS char(400))) like UPPER(CAST(@TTBUS2_Observaciones AS char(400))) ORDER BY [TTBUS2_Observaciones] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001E4,0,0,true,false )
             ,new CursorDef("H001E5", "SELECT [TTBUS_Estado], [TTBUS_CodPosicion], [TTBUS_Descripcion], [TTBUS_Id] FROM [TTBUS000] WITH (NOLOCK) WHERE ([TTBUS_CodPosicion] = @AV15TTBUS7_Pos) AND ([TTBUS_Estado] = 1) ORDER BY [TTBUS_Id] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001E5,11,0,true,false )
             ,new CursorDef("H001E6", "SELECT [TTBUS8_CodUsuario] FROM [TTBUS008] WITH (NOLOCK) WHERE [TTBUS8_CodUsuario] = @AV16USUARIO ORDER BY [TTBUS8_CodUsuario] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001E6,1,0,false,true )
             ,new CursorDef("H001E7", "SELECT [W53POS], [W53DES] FROM [T53FPOS] WITH (NOLOCK) ORDER BY [W53DES] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001E7,100,0,true,false )
             ,new CursorDef("H001E8", "SELECT T1.[TTBUS7_Pos] AS TTBUS7_Pos, T2.[W53DES] AS TTBUS7_Des FROM ([TTBUS007] T1 WITH (NOLOCK) INNER JOIN [T53FPOS] T2 WITH (NOLOCK) ON T2.[W53POS] = T1.[TTBUS7_Pos]) WHERE (T1.[TTBUS7_Pos] = @W53POS) AND (T1.[TTBUS7_Pos] <> 998) ORDER BY T1.[TTBUS7_Pos] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001E8,1,0,false,true )
             ,new CursorDef("H001E9", "SELECT [W53POS], [W53DES] FROM [T53FPOS] WITH (NOLOCK) ORDER BY [W53DES] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001E9,100,0,true,false )
             ,new CursorDef("H001E10", "SELECT T1.[TTBUS7_Pos] AS TTBUS7_Pos, T1.[TTBUS7_CodResp], T2.[W53DES] AS TTBUS7_Des FROM ([TTBUS007] T1 WITH (NOLOCK) INNER JOIN [T53FPOS] T2 WITH (NOLOCK) ON T2.[W53POS] = T1.[TTBUS7_Pos]) WHERE (T1.[TTBUS7_Pos] = @W53POS) AND (T1.[TTBUS7_Pos] <> 998) ORDER BY T1.[TTBUS7_Pos] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001E10,1,0,true,true )
             ,new CursorDef("H001E11", "SELECT [W53POS], [W53DES] FROM [T53FPOS] WITH (NOLOCK) ORDER BY [W53DES] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001E11,100,0,true,false )
             ,new CursorDef("H001E12", "SELECT T1.[TTBUS7_CodUsuario], T1.[TTBUS7_Pos] AS TTBUS7_Pos, T1.[TTBUS7_RespAux], T2.[W53DES] AS TTBUS7_Des FROM ([TTBUS007Permisos] T1 WITH (NOLOCK) INNER JOIN [T53FPOS] T2 WITH (NOLOCK) ON T2.[W53POS] = T1.[TTBUS7_Pos]) WHERE (T1.[TTBUS7_Pos] = @AV37W53POS and T1.[TTBUS7_CodUsuario] = @AV16USUARIO) AND (T1.[TTBUS7_Pos] <> 998) AND (T1.[TTBUS7_Pos] = @AV17vTTBUS7_Pos) ORDER BY T1.[TTBUS7_Pos], T1.[TTBUS7_CodUsuario] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001E12,1,0,false,true )
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
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                break;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((int[]) buf[3])[0] = rslt.getInt(4) ;
                break;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                break;
             case 5 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                break;
             case 6 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                break;
             case 7 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                break;
             case 8 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 16) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 50) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                break;
             case 9 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                break;
             case 10 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 50) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(4);
                break;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 0 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 2 :
                if ( (bool)parms[0] )
                {
                   stmt.setNull( 1 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(1, (String)parms[1]);
                }
                break;
             case 3 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 4 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
             case 6 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 8 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 10 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                break;
       }
    }

 }

}
