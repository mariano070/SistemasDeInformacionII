/*
               File: Gx00N0
        Description: Selection List HARDWARE
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:18:9.62
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
   public class gx00n0 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx00n0( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public gx00n0( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( out short aP0_pHARDWARE_ID )
      {
         this.AV13pHARDWARE_ID = 0 ;
         executePrivate();
         aP0_pHARDWARE_ID=this.AV13pHARDWARE_ID;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbavCth_direc = new GXCombobox();
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
               nGXsfl_51_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               sGXsfl_51_idx = GetNextPar( ) ;
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxnrGrid1_newrow( nRC_Grid1, nGXsfl_51_idx, sGXsfl_51_idx) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid1") == 0 )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0 ;
               cmbavCth_direc.Name = "vCTH_DIREC" ;
               cmbavCth_direc.WebTags = "" ;
               cmbavCth_direc.addItem(" 1", "NINGUNO", 0);
               cmbavCth_direc.addItem(" 2", "IP", 0);
               if ( ( cmbavCth_direc.ItemCount > 0 ) && (0==AV11cTH_DIREC) )
               {
                  AV11cTH_DIREC = (short)(NumberUtil.Val( cmbavCth_direc.getItemValue(1), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cTH_DIREC", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11cTH_DIREC), 2, 0)));
               }
               Grid1_PageSize51 = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               AV6cHARDWARE_ID = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cHARDWARE_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cHARDWARE_ID), 4, 0)));
               AV7cTIPOS_DE_HARDWARE_ID = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cTIPOS_DE_HARDWARE_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7cTIPOS_DE_HARDWARE_ID), 4, 0)));
               AV8cHARDWARE_DESCRIPCION = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cHARDWARE_DESCRIPCION", AV8cHARDWARE_DESCRIPCION);
               AV9cfecha_alta = context.localUtil.ParseDTimeParm( GetNextPar( )) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cfecha_alta", context.localUtil.TToC( AV9cfecha_alta, 10, 8, 0, 3, "/", ":", " "));
               AV10cNOMBRE_DEL_TIPO_DE_HD = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cNOMBRE_DEL_TIPO_DE_HD", AV10cNOMBRE_DEL_TIPO_DE_HD);
               AV11cTH_DIREC = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cTH_DIREC", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11cTH_DIREC), 2, 0)));
               AV12cMODELO_DE_COMPONENTES_ID = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cMODELO_DE_COMPONENTES_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12cMODELO_DE_COMPONENTES_ID), 4, 0)));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxgrGrid1_refresh( Grid1_PageSize51, AV6cHARDWARE_ID, AV7cTIPOS_DE_HARDWARE_ID, AV8cHARDWARE_DESCRIPCION, AV9cfecha_alta, AV10cNOMBRE_DEL_TIPO_DE_HD, AV11cTH_DIREC, AV12cMODELO_DE_COMPONENTES_ID) ;
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
               AV13pHARDWARE_ID = (short)(NumberUtil.Val( gxfirstwebparm, ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pHARDWARE_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pHARDWARE_ID), 4, 0)));
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
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("promptmasterpage", "GeneXus.Programs.promptmasterpage", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
            MasterPageObj.setDataArea(this,true);
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
         PA4L2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START4L2( ) ;
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
         FormProcess = " onkeyup=\"gx.evt.onkeyup(event)\" onkeypress=\"gx.evt.onkeypress(event,true,false)\" onkeydown=\"gx.evt.onkeypress(null,true,false)\"" ;
         context.WriteHtmlText( "<body") ;
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            context.WriteHtmlText( " background=\""+context.convertURL( Form.Background)+"\"") ;
         }
         context.WriteHtmlText( " "+"class=\"Form\""+" "+" style=\"-moz-opacity:0;opacity:0;"+"background-color:"+context.BuildHTMLColor( Form.Backcolor)+"\""+FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("gx00n0.aspx") + "?" + UrlEncode("" +AV13pHARDWARE_ID)+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, "GXH_vCHARDWARE_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cHARDWARE_ID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCTIPOS_DE_HARDWARE_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7cTIPOS_DE_HARDWARE_ID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCHARDWARE_DESCRIPCION", StringUtil.RTrim( AV8cHARDWARE_DESCRIPCION));
         GxWebStd.gx_hidden_field( context, "GXH_vCFECHA_ALTA", context.localUtil.Format(AV9cfecha_alta, "99/99/9999 99:99:99"));
         GxWebStd.gx_hidden_field( context, "GXH_vCNOMBRE_DEL_TIPO_DE_HD", StringUtil.RTrim( AV10cNOMBRE_DEL_TIPO_DE_HD));
         GxWebStd.gx_hidden_field( context, "GXH_vCTH_DIREC", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11cTH_DIREC), 2, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCMODELO_DE_COMPONENTES_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12cMODELO_DE_COMPONENTES_ID), 4, 0, ",", "")));
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_Grid1", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid1), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPHARDWARE_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13pHARDWARE_ID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 6, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendComponentObjects();
         SendServerCommands();
         SendState();
         context.WriteHtmlTextNl( "</form>") ;
         include_jscripts( ) ;
      }

      public override void RenderHtmlContent( )
      {
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            WE4L2( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT4L2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override String GetPgmname( )
      {
         return "Gx00N0" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List HARDWARE" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("gx00n0.aspx") + "?" + UrlEncode("" +AV13pHARDWARE_ID) ;
      }

      protected void WB4L0( )
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
            wb_table1_2_4L2( true) ;
         }
         else
         {
            wb_table1_2_4L2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_4L2e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START4L2( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "Selection List HARDWARE", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP4L0( ) ;
      }

      protected void WS4L2( )
      {
         START4L2( ) ;
         EVT4L2( ) ;
      }

      protected void EVT4L2( )
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
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCHARDWARE_ID"), ",", ".") != Convert.ToDecimal( AV6cHARDWARE_ID )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCTIPOS_DE_HARDWARE_ID"), ",", ".") != Convert.ToDecimal( AV7cTIPOS_DE_HARDWARE_ID )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCHARDWARE_DESCRIPCION"), AV8cHARDWARE_DESCRIPCION) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( context.localUtil.CToT( cgiGet( "GXH_vCFECHA_ALTA")) != AV9cfecha_alta )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCNOMBRE_DEL_TIPO_DE_HD"), AV10cNOMBRE_DEL_TIPO_DE_HD) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCTH_DIREC"), ",", ".") != Convert.ToDecimal( AV11cTH_DIREC )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCMODELO_DE_COMPONENTES_ID"), ",", ".") != Convert.ToDecimal( AV12cMODELO_DE_COMPONENTES_ID )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
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
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 4), "LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) )
                           {
                              nGXsfl_51_idx = (short)(NumberUtil.Val( sEvtType, ".")) ;
                              sGXsfl_51_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_51_idx), 4, 0)), 4, "0") ;
                              edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
                              edtHARDWARE_ID_Internalname = "HARDWARE_ID_"+sGXsfl_51_idx ;
                              edtTIPOS_DE_HARDWARE_ID_Internalname = "TIPOS_DE_HARDWARE_ID_"+sGXsfl_51_idx ;
                              edtHARDWARE_DESCRIPCION_Internalname = "HARDWARE_DESCRIPCION_"+sGXsfl_51_idx ;
                              edtfecha_alta_Internalname = "FECHA_ALTA_"+sGXsfl_51_idx ;
                              edtNOMBRE_DEL_TIPO_DE_HD_Internalname = "NOMBRE_DEL_TIPO_DE_HD_"+sGXsfl_51_idx ;
                              edtMODELO_DE_COMPONENTES_ID_Internalname = "MODELO_DE_COMPONENTES_ID_"+sGXsfl_51_idx ;
                              edtMODELO_DE_COMPONENTES_NOMBRE_Internalname = "MODELO_DE_COMPONENTES_NOMBRE_"+sGXsfl_51_idx ;
                              edtMARCAS_ID_Internalname = "MARCAS_ID_"+sGXsfl_51_idx ;
                              edtHARDWARE_NRO_BIEN_Internalname = "HARDWARE_NRO_BIEN_"+sGXsfl_51_idx ;
                              AV5LinkSelection = cgiGet( "GXimg"+edtavLinkselection_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Bitmap", context.convertURL( AV5LinkSelection));
                              A10HARDWARE_ID = (short)(context.localUtil.CToN( cgiGet( edtHARDWARE_ID_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10HARDWARE_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A10HARDWARE_ID), 4, 0)));
                              A181TIPOS_DE_HARDWARE_ID = (short)(context.localUtil.CToN( cgiGet( edtTIPOS_DE_HARDWARE_ID_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A181TIPOS_DE_HARDWARE_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A181TIPOS_DE_HARDWARE_ID), 4, 0)));
                              A58HARDWARE_DESCRIPCION = cgiGet( edtHARDWARE_DESCRIPCION_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A58HARDWARE_DESCRIPCION", A58HARDWARE_DESCRIPCION);
                              A182fecha_alta = context.localUtil.CToT( cgiGet( edtfecha_alta_Internalname)) ;
                              n182fecha_alta = false ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A182fecha_alta", context.localUtil.TToC( A182fecha_alta, 10, 8, 0, 3, "/", ":", " "));
                              A187NOMBRE_DEL_TIPO_DE_HD = cgiGet( edtNOMBRE_DEL_TIPO_DE_HD_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A187NOMBRE_DEL_TIPO_DE_HD", A187NOMBRE_DEL_TIPO_DE_HD);
                              A183MODELO_DE_COMPONENTES_ID = (short)(context.localUtil.CToN( cgiGet( edtMODELO_DE_COMPONENTES_ID_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A183MODELO_DE_COMPONENTES_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A183MODELO_DE_COMPONENTES_ID), 4, 0)));
                              A188MODELO_DE_COMPONENTES_NOMBRE = cgiGet( edtMODELO_DE_COMPONENTES_NOMBRE_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A188MODELO_DE_COMPONENTES_NOMBRE", A188MODELO_DE_COMPONENTES_NOMBRE);
                              A189MARCAS_ID = (short)(context.localUtil.CToN( cgiGet( edtMARCAS_ID_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A189MARCAS_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A189MARCAS_ID), 4, 0)));
                              A184HARDWARE_NRO_BIEN = (long)(context.localUtil.CToN( cgiGet( edtHARDWARE_NRO_BIEN_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A184HARDWARE_NRO_BIEN", StringUtil.LTrim( StringUtil.Str( (decimal)(A184HARDWARE_NRO_BIEN), 10, 0)));
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E114L2 */
                                    E114L2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E124L2 */
                                    E124L2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false ;
                                       /* Set Refresh If Chardware_id Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCHARDWARE_ID"), ",", ".") != Convert.ToDecimal( AV6cHARDWARE_ID )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Ctipos_de_hardware_id Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCTIPOS_DE_HARDWARE_ID"), ",", ".") != Convert.ToDecimal( AV7cTIPOS_DE_HARDWARE_ID )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Chardware_descripcion Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCHARDWARE_DESCRIPCION"), AV8cHARDWARE_DESCRIPCION) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cfecha_alta Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vCFECHA_ALTA")) != AV9cfecha_alta )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cnombre_del_tipo_de_hd Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCNOMBRE_DEL_TIPO_DE_HD"), AV10cNOMBRE_DEL_TIPO_DE_HD) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cth_direc Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCTH_DIREC"), ",", ".") != Convert.ToDecimal( AV11cTH_DIREC )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cmodelo_de_componentes_id Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCMODELO_DE_COMPONENTES_ID"), ",", ".") != Convert.ToDecimal( AV12cMODELO_DE_COMPONENTES_ID )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: E134L2 */
                                          E134L2 ();
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

      protected void WE4L2( )
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

      protected void PA4L2( )
      {
         if ( nDonePA == 0 )
         {
            cmbavCth_direc.Name = "vCTH_DIREC" ;
            cmbavCth_direc.WebTags = "" ;
            cmbavCth_direc.addItem(" 1", "NINGUNO", 0);
            cmbavCth_direc.addItem(" 2", "IP", 0);
            if ( ( cmbavCth_direc.ItemCount > 0 ) && (0==AV11cTH_DIREC) )
            {
               AV11cTH_DIREC = (short)(NumberUtil.Val( cmbavCth_direc.getItemValue(1), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cTH_DIREC", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11cTH_DIREC), 2, 0)));
            }
            GX_FocusControl = edtavChardware_id_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGrid1_newrow( short nRC_Grid1 ,
                                       short nGXsfl_51_idx ,
                                       String sGXsfl_51_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
         edtHARDWARE_ID_Internalname = "HARDWARE_ID_"+sGXsfl_51_idx ;
         edtTIPOS_DE_HARDWARE_ID_Internalname = "TIPOS_DE_HARDWARE_ID_"+sGXsfl_51_idx ;
         edtHARDWARE_DESCRIPCION_Internalname = "HARDWARE_DESCRIPCION_"+sGXsfl_51_idx ;
         edtfecha_alta_Internalname = "FECHA_ALTA_"+sGXsfl_51_idx ;
         edtNOMBRE_DEL_TIPO_DE_HD_Internalname = "NOMBRE_DEL_TIPO_DE_HD_"+sGXsfl_51_idx ;
         edtMODELO_DE_COMPONENTES_ID_Internalname = "MODELO_DE_COMPONENTES_ID_"+sGXsfl_51_idx ;
         edtMODELO_DE_COMPONENTES_NOMBRE_Internalname = "MODELO_DE_COMPONENTES_NOMBRE_"+sGXsfl_51_idx ;
         edtMARCAS_ID_Internalname = "MARCAS_ID_"+sGXsfl_51_idx ;
         edtHARDWARE_NRO_BIEN_Internalname = "HARDWARE_NRO_BIEN_"+sGXsfl_51_idx ;
         while ( nGXsfl_51_idx <= nRC_Grid1 )
         {
            sendrow_512( ) ;
            nGXsfl_51_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_51_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_51_idx+1)) ;
            sGXsfl_51_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_51_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
            edtHARDWARE_ID_Internalname = "HARDWARE_ID_"+sGXsfl_51_idx ;
            edtTIPOS_DE_HARDWARE_ID_Internalname = "TIPOS_DE_HARDWARE_ID_"+sGXsfl_51_idx ;
            edtHARDWARE_DESCRIPCION_Internalname = "HARDWARE_DESCRIPCION_"+sGXsfl_51_idx ;
            edtfecha_alta_Internalname = "FECHA_ALTA_"+sGXsfl_51_idx ;
            edtNOMBRE_DEL_TIPO_DE_HD_Internalname = "NOMBRE_DEL_TIPO_DE_HD_"+sGXsfl_51_idx ;
            edtMODELO_DE_COMPONENTES_ID_Internalname = "MODELO_DE_COMPONENTES_ID_"+sGXsfl_51_idx ;
            edtMODELO_DE_COMPONENTES_NOMBRE_Internalname = "MODELO_DE_COMPONENTES_NOMBRE_"+sGXsfl_51_idx ;
            edtMARCAS_ID_Internalname = "MARCAS_ID_"+sGXsfl_51_idx ;
            edtHARDWARE_NRO_BIEN_Internalname = "HARDWARE_NRO_BIEN_"+sGXsfl_51_idx ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int Grid1_PageSize51 ,
                                        short AV6cHARDWARE_ID ,
                                        short AV7cTIPOS_DE_HARDWARE_ID ,
                                        String AV8cHARDWARE_DESCRIPCION ,
                                        DateTime AV9cfecha_alta ,
                                        String AV10cNOMBRE_DEL_TIPO_DE_HD ,
                                        short AV11cTH_DIREC ,
                                        short AV12cMODELO_DE_COMPONENTES_ID )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         disableOutput();
         subGrid1_Rows = (short)(Grid1_PageSize51) ;
         RF4L2( ) ;
         enableOutput();
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxgrGrid1_refresh */
      }

      protected void Refresh( )
      {
         RF4L2( ) ;
         /* End function Refresh */
      }

      protected void RF4L2( )
      {
         Grid1Container.PageSize = subGrid1_Recordsperpage( ) ;
         wbStart = 51 ;
         nGXsfl_51_idx = 1 ;
         sGXsfl_51_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_51_idx), 4, 0)), 4, "0") ;
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
         edtHARDWARE_ID_Internalname = "HARDWARE_ID_"+sGXsfl_51_idx ;
         edtTIPOS_DE_HARDWARE_ID_Internalname = "TIPOS_DE_HARDWARE_ID_"+sGXsfl_51_idx ;
         edtHARDWARE_DESCRIPCION_Internalname = "HARDWARE_DESCRIPCION_"+sGXsfl_51_idx ;
         edtfecha_alta_Internalname = "FECHA_ALTA_"+sGXsfl_51_idx ;
         edtNOMBRE_DEL_TIPO_DE_HD_Internalname = "NOMBRE_DEL_TIPO_DE_HD_"+sGXsfl_51_idx ;
         edtMODELO_DE_COMPONENTES_ID_Internalname = "MODELO_DE_COMPONENTES_ID_"+sGXsfl_51_idx ;
         edtMODELO_DE_COMPONENTES_NOMBRE_Internalname = "MODELO_DE_COMPONENTES_NOMBRE_"+sGXsfl_51_idx ;
         edtMARCAS_ID_Internalname = "MARCAS_ID_"+sGXsfl_51_idx ;
         edtHARDWARE_NRO_BIEN_Internalname = "HARDWARE_NRO_BIEN_"+sGXsfl_51_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
            edtHARDWARE_ID_Internalname = "HARDWARE_ID_"+sGXsfl_51_idx ;
            edtTIPOS_DE_HARDWARE_ID_Internalname = "TIPOS_DE_HARDWARE_ID_"+sGXsfl_51_idx ;
            edtHARDWARE_DESCRIPCION_Internalname = "HARDWARE_DESCRIPCION_"+sGXsfl_51_idx ;
            edtfecha_alta_Internalname = "FECHA_ALTA_"+sGXsfl_51_idx ;
            edtNOMBRE_DEL_TIPO_DE_HD_Internalname = "NOMBRE_DEL_TIPO_DE_HD_"+sGXsfl_51_idx ;
            edtMODELO_DE_COMPONENTES_ID_Internalname = "MODELO_DE_COMPONENTES_ID_"+sGXsfl_51_idx ;
            edtMODELO_DE_COMPONENTES_NOMBRE_Internalname = "MODELO_DE_COMPONENTES_NOMBRE_"+sGXsfl_51_idx ;
            edtMARCAS_ID_Internalname = "MARCAS_ID_"+sGXsfl_51_idx ;
            edtHARDWARE_NRO_BIEN_Internalname = "HARDWARE_NRO_BIEN_"+sGXsfl_51_idx ;
            lV8cHARDWARE_DESCRIPCION = StringUtil.PadR( StringUtil.RTrim( AV8cHARDWARE_DESCRIPCION), 40, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cHARDWARE_DESCRIPCION", AV8cHARDWARE_DESCRIPCION);
            lV10cNOMBRE_DEL_TIPO_DE_HD = StringUtil.PadR( StringUtil.RTrim( AV10cNOMBRE_DEL_TIPO_DE_HD), 20, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cNOMBRE_DEL_TIPO_DE_HD", AV10cNOMBRE_DEL_TIPO_DE_HD);
            /* Using cursor H004L2 */
            pr_default.execute(0, new Object[] {AV6cHARDWARE_ID, AV7cTIPOS_DE_HARDWARE_ID, lV8cHARDWARE_DESCRIPCION, AV9cfecha_alta, lV10cNOMBRE_DEL_TIPO_DE_HD, AV11cTH_DIREC, AV12cMODELO_DE_COMPONENTES_ID});
            nGXsfl_51_idx = 1 ;
            GRID1_nEOF = 0 ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) ) )
            {
               A313TH_DIREC = H004L2_A313TH_DIREC[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A313TH_DIREC", StringUtil.LTrim( StringUtil.Str( (decimal)(A313TH_DIREC), 2, 0)));
               A184HARDWARE_NRO_BIEN = H004L2_A184HARDWARE_NRO_BIEN[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A184HARDWARE_NRO_BIEN", StringUtil.LTrim( StringUtil.Str( (decimal)(A184HARDWARE_NRO_BIEN), 10, 0)));
               A189MARCAS_ID = H004L2_A189MARCAS_ID[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A189MARCAS_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A189MARCAS_ID), 4, 0)));
               A188MODELO_DE_COMPONENTES_NOMBRE = H004L2_A188MODELO_DE_COMPONENTES_NOMBRE[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A188MODELO_DE_COMPONENTES_NOMBRE", A188MODELO_DE_COMPONENTES_NOMBRE);
               A183MODELO_DE_COMPONENTES_ID = H004L2_A183MODELO_DE_COMPONENTES_ID[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A183MODELO_DE_COMPONENTES_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A183MODELO_DE_COMPONENTES_ID), 4, 0)));
               A187NOMBRE_DEL_TIPO_DE_HD = H004L2_A187NOMBRE_DEL_TIPO_DE_HD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A187NOMBRE_DEL_TIPO_DE_HD", A187NOMBRE_DEL_TIPO_DE_HD);
               A182fecha_alta = H004L2_A182fecha_alta[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A182fecha_alta", context.localUtil.TToC( A182fecha_alta, 10, 8, 0, 3, "/", ":", " "));
               n182fecha_alta = H004L2_n182fecha_alta[0] ;
               A58HARDWARE_DESCRIPCION = H004L2_A58HARDWARE_DESCRIPCION[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A58HARDWARE_DESCRIPCION", A58HARDWARE_DESCRIPCION);
               A181TIPOS_DE_HARDWARE_ID = H004L2_A181TIPOS_DE_HARDWARE_ID[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A181TIPOS_DE_HARDWARE_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A181TIPOS_DE_HARDWARE_ID), 4, 0)));
               A10HARDWARE_ID = H004L2_A10HARDWARE_ID[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10HARDWARE_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A10HARDWARE_ID), 4, 0)));
               /* Execute user event: E124L2 */
               E124L2 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0)) ;
            pr_default.close(0);
            wbEnd = 51 ;
            WB4L0( ) ;
         }
      }

      protected int subGrid1_Pagecount( )
      {
         GRID1_nRecordCount = subGrid1_Recordcount( ) ;
         if ( ((int)(GRID1_nRecordCount) % (subGrid1_Recordsperpage( ))) == 0 )
         {
            return (int)(NumberUtil.Int( (long)(GRID1_nRecordCount/ (decimal)(subGrid1_Recordsperpage( ))))) ;
         }
         return (int)(NumberUtil.Int( (long)(GRID1_nRecordCount/ (decimal)(subGrid1_Recordsperpage( ))))+1) ;
      }

      protected int subGrid1_Recordcount( )
      {
         lV8cHARDWARE_DESCRIPCION = StringUtil.PadR( StringUtil.RTrim( AV8cHARDWARE_DESCRIPCION), 40, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cHARDWARE_DESCRIPCION", AV8cHARDWARE_DESCRIPCION);
         lV10cNOMBRE_DEL_TIPO_DE_HD = StringUtil.PadR( StringUtil.RTrim( AV10cNOMBRE_DEL_TIPO_DE_HD), 20, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cNOMBRE_DEL_TIPO_DE_HD", AV10cNOMBRE_DEL_TIPO_DE_HD);
         /* Using cursor H004L3 */
         pr_default.execute(1, new Object[] {AV6cHARDWARE_ID, AV7cTIPOS_DE_HARDWARE_ID, lV8cHARDWARE_DESCRIPCION, AV9cfecha_alta, lV10cNOMBRE_DEL_TIPO_DE_HD, AV11cTH_DIREC, AV12cMODELO_DE_COMPONENTES_ID});
         GRID1_nRecordCount = H004L3_AGRID1_nRecordCount[0] ;
         pr_default.close(1);
         return GRID1_nRecordCount ;
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
         return (int)(NumberUtil.Int( (long)(GRID1_nFirstRecordOnPage/ (decimal)(subGrid1_Recordsperpage( ))))+1) ;
      }

      protected short subgrid1_firstpage( )
      {
         GRID1_nFirstRecordOnPage = 0 ;
         return 0 ;
      }

      protected short subgrid1_nextpage( )
      {
         GRID1_nRecordCount = subGrid1_Recordcount( ) ;
         if ( ( GRID1_nRecordCount >= subGrid1_Recordsperpage( ) ) && ( GRID1_nEOF == 0 ) )
         {
            GRID1_nFirstRecordOnPage = (int)(GRID1_nFirstRecordOnPage+subGrid1_Recordsperpage( )) ;
         }
         else
         {
            return 2 ;
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
         GRID1_nRecordCount = subGrid1_Recordcount( ) ;
         if ( GRID1_nRecordCount > subGrid1_Recordsperpage( ) )
         {
            if ( ((int)(GRID1_nRecordCount) % (subGrid1_Recordsperpage( ))) == 0 )
            {
               GRID1_nFirstRecordOnPage = (int)(GRID1_nRecordCount-subGrid1_Recordsperpage( )) ;
            }
            else
            {
               GRID1_nFirstRecordOnPage = (int)(GRID1_nRecordCount-((int)(GRID1_nRecordCount) % (subGrid1_Recordsperpage( )))) ;
            }
         }
         else
         {
            GRID1_nFirstRecordOnPage = 0 ;
         }
         return 0 ;
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

      protected void STRUP4L0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E114L2 */
         E114L2 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( ! context.localUtil.VCNumber( cgiGet( edtavChardware_id_Internalname), "ZZZ9") || ( context.localUtil.CToN( cgiGet( edtavChardware_id_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavChardware_id_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vCHARDWARE_ID");
               GX_FocusControl = edtavChardware_id_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV6cHARDWARE_ID = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cHARDWARE_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cHARDWARE_ID), 4, 0)));
            }
            else
            {
               AV6cHARDWARE_ID = (short)(context.localUtil.CToN( cgiGet( edtavChardware_id_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cHARDWARE_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cHARDWARE_ID), 4, 0)));
            }
            if ( ! context.localUtil.VCNumber( cgiGet( edtavCtipos_de_hardware_id_Internalname), "ZZZ9") || ( context.localUtil.CToN( cgiGet( edtavCtipos_de_hardware_id_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavCtipos_de_hardware_id_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vCTIPOS_DE_HARDWARE_ID");
               GX_FocusControl = edtavCtipos_de_hardware_id_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV7cTIPOS_DE_HARDWARE_ID = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cTIPOS_DE_HARDWARE_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7cTIPOS_DE_HARDWARE_ID), 4, 0)));
            }
            else
            {
               AV7cTIPOS_DE_HARDWARE_ID = (short)(context.localUtil.CToN( cgiGet( edtavCtipos_de_hardware_id_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cTIPOS_DE_HARDWARE_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7cTIPOS_DE_HARDWARE_ID), 4, 0)));
            }
            AV8cHARDWARE_DESCRIPCION = cgiGet( edtavChardware_descripcion_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cHARDWARE_DESCRIPCION", AV8cHARDWARE_DESCRIPCION);
            if ( context.localUtil.VCDateTime( cgiGet( edtavCfecha_alta_Internalname), 4, 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"fecha_alta"}), 1, "vCFECHA_ALTA");
               GX_FocusControl = edtavCfecha_alta_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV9cfecha_alta = (DateTime)(DateTime.MinValue) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cfecha_alta", context.localUtil.TToC( AV9cfecha_alta, 10, 8, 0, 3, "/", ":", " "));
            }
            else
            {
               AV9cfecha_alta = context.localUtil.CToT( cgiGet( edtavCfecha_alta_Internalname)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cfecha_alta", context.localUtil.TToC( AV9cfecha_alta, 10, 8, 0, 3, "/", ":", " "));
            }
            AV10cNOMBRE_DEL_TIPO_DE_HD = cgiGet( edtavCnombre_del_tipo_de_hd_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cNOMBRE_DEL_TIPO_DE_HD", AV10cNOMBRE_DEL_TIPO_DE_HD);
            cmbavCth_direc.Name = cmbavCth_direc_Internalname ;
            cmbavCth_direc.CurrentValue = cgiGet( cmbavCth_direc_Internalname) ;
            AV11cTH_DIREC = (short)(NumberUtil.Val( cgiGet( cmbavCth_direc_Internalname), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cTH_DIREC", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11cTH_DIREC), 2, 0)));
            if ( ! context.localUtil.VCNumber( cgiGet( edtavCmodelo_de_componentes_id_Internalname), "ZZZ9") || ( context.localUtil.CToN( cgiGet( edtavCmodelo_de_componentes_id_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavCmodelo_de_componentes_id_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vCMODELO_DE_COMPONENTES_ID");
               GX_FocusControl = edtavCmodelo_de_componentes_id_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV12cMODELO_DE_COMPONENTES_ID = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cMODELO_DE_COMPONENTES_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12cMODELO_DE_COMPONENTES_ID), 4, 0)));
            }
            else
            {
               AV12cMODELO_DE_COMPONENTES_ID = (short)(context.localUtil.CToN( cgiGet( edtavCmodelo_de_componentes_id_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cMODELO_DE_COMPONENTES_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12cMODELO_DE_COMPONENTES_ID), 4, 0)));
            }
            /* Read saved values. */
            nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ",", ".")) ;
            AV13pHARDWARE_ID = (short)(context.localUtil.CToN( cgiGet( "vPHARDWARE_ID"), ",", ".")) ;
            GRID1_nFirstRecordOnPage = (int)(context.localUtil.CToN( cgiGet( "GRID1_nFirstRecordOnPage"), ",", ".")) ;
            GRID1_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID1_nEOF"), ",", ".")) ;
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
         /* Execute user event: E114L2 */
         E114L2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E114L2( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Lista de Selección %1", "HARDWARE", "", "", "", "", "", "", "", "") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption);
      }

      private void E124L2( )
      {
         /* Load Routine */
         AV5LinkSelection = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", "Modern") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Bitmap", context.convertURL( AV5LinkSelection));
         if ( ( subGrid1_Islastpage == 1 ) || ( 10 == 0 ) || ( ( GRID1_nCurrentRecord >= GRID1_nFirstRecordOnPage ) && ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) )
         {
            sendrow_512( ) ;
         }
         GRID1_nCurrentRecord = (int)(GRID1_nCurrentRecord+1) ;
      }

      public void GXEnter( )
      {
         /* Execute user event: E134L2 */
         E134L2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E134L2( )
      {
         /* Enter Routine */
         AV13pHARDWARE_ID = A10HARDWARE_ID ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pHARDWARE_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pHARDWARE_ID), 4, 0)));
         context.setWebReturnParms(new Object[] {(short)AV13pHARDWARE_ID});
         context.nUserReturn = 1 ;
         returnInSub = true;
         if (true) return;
      }

      protected void wb_table1_2_4L2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
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
            /* Control Group */
            ClassString = "FieldSet" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroup1_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Filters"+"</legend>") ;
            wb_table2_9_4L2( true) ;
         }
         else
         {
            wb_table2_9_4L2( false) ;
         }
         return  ;
      }

      protected void wb_table2_9_4L2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Control Group */
            ClassString = "FieldSet" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroup2_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Lista de Selección"+"</legend>") ;
            wb_table3_48_4L2( true) ;
         }
         else
         {
            wb_table3_48_4L2( false) ;
         }
         return  ;
      }

      protected void wb_table3_48_4L2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_4L2e( true) ;
         }
         else
         {
            wb_table1_2_4L2e( false) ;
         }
      }

      protected void wb_table3_48_4L2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable3_Internalname, tblTable3_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"3\" >") ;
            /*  Grid Control  */
            Grid1Container.SetWrapped(nGXWrapped);
            if ( Grid1Container.GetWrapped() == 1 )
            {
               sStyleString = "" ;
               GxWebStd.gx_table_start( context, subGrid1_Internalname, subGrid1_Internalname, "", "Grid", 0, "", "", 1, 0, sStyleString, "", 0);
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
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "ID") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "ID") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "HARDWARE") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "fecha_alta") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "TIPO DE HW") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "ID") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "MODELO") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "ID") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "NRO. BIEN") ;
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
               Grid1Container.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(0), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Backcolorstyle), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("CmpContext", "");
               Grid1Container.AddObjectProperty("InMasterPage", "false");
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", context.convertURL( AV5LinkSelection));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtavLinkselection_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A10HARDWARE_ID), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A181TIPOS_DE_HARDWARE_ID), 4, 0, ".", "")));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtTIPOS_DE_HARDWARE_ID_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A58HARDWARE_DESCRIPCION));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", context.localUtil.Format(A182fecha_alta, "99/99/9999 99:99:99"));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A187NOMBRE_DEL_TIPO_DE_HD));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A183MODELO_DE_COMPONENTES_ID), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A188MODELO_DE_COMPONENTES_NOMBRE));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A189MARCAS_ID), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A184HARDWARE_NRO_BIEN), 10, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Container.AddObjectProperty("Allowselection", "false");
               Grid1Container.AddObjectProperty("Allowcollapsing", "false");
               Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 9, 0, ".", "")));
            }
         }
         if ( wbEnd == 51 )
         {
            wbEnd = 0 ;
            nRC_Grid1 = (short)(nGXsfl_51_idx-1) ;
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
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "right")+"\">") ;
            wb_table4_64_4L2( true) ;
         }
         else
         {
            wb_table4_64_4L2( false) ;
         }
         return  ;
      }

      protected void wb_table4_64_4L2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_48_4L2e( true) ;
         }
         else
         {
            wb_table3_48_4L2e( false) ;
         }
      }

      protected void wb_table4_64_4L2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable4_Internalname, tblTable4_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 67,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttBtn_cancel_Internalname, "Cancelar", "Cancelar", "", StyleString, ClassString, 1, 1, "rounded", 1, bttBtn_cancel_Jsonclick, "ECANCEL.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(51), 3, 0)+","+"null"+");", "", "HLP_Gx00N0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_64_4L2e( true) ;
         }
         else
         {
            wb_table4_64_4L2e( false) ;
         }
      }

      protected void wb_table2_9_4L2( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockhardware_id_Internalname, 1, 1, 0, "ID", "", "", "", 0, lblTextblockhardware_id_Jsonclick, "", StyleString, ClassString, "HLP_Gx00N0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavChardware_id_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cHARDWARE_ID), 4, 0, ",", "")), "", 4, "chr", 1, "row", 4, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(AV6cHARDWARE_ID), "ZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(14);\"", 0, edtavChardware_id_Jsonclick, "", 0, 1, -1, true, "right", "HLP_Gx00N0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocktipos_de_hardware_id_Internalname, 1, 1, 0, "ID", "", "", "", 0, lblTextblocktipos_de_hardware_id_Jsonclick, "", StyleString, ClassString, "HLP_Gx00N0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCtipos_de_hardware_id_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7cTIPOS_DE_HARDWARE_ID), 4, 0, ",", "")), "", 4, "chr", 1, "row", 4, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(AV7cTIPOS_DE_HARDWARE_ID), "ZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(19);\"", 0, edtavCtipos_de_hardware_id_Jsonclick, "", 0, 1, -1, true, "right", "HLP_Gx00N0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockhardware_descripcion_Internalname, 1, 1, 0, "HARDWARE", "", "", "", 0, lblTextblockhardware_descripcion_Jsonclick, "", StyleString, ClassString, "HLP_Gx00N0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 24,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavChardware_descripcion_Internalname, StringUtil.RTrim( AV8cHARDWARE_DESCRIPCION), "", 40, "chr", 1, "row", 40, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV8cHARDWARE_DESCRIPCION, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(24);\"", 0, edtavChardware_descripcion_Jsonclick, "", 0, 1, -1, true, "left", "HLP_Gx00N0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockfecha_alta_Internalname, 1, 1, 0, "fecha_alta", "", "", "", 0, lblTextblockfecha_alta_Jsonclick, "", StyleString, ClassString, "HLP_Gx00N0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtavCfecha_alta_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavCfecha_alta_Internalname, context.localUtil.Format(AV9cfecha_alta, "99/99/9999 99:99:99"), "", 19, "chr", 1, "row", 19, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( AV9cfecha_alta, "99/99/9999 99:99:99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 10,'DMY',8,24,'spa',false,0);"+";gx.evt.onblur(29);\"", 0, edtavCfecha_alta_Jsonclick, "", 0, 1, -1, true, "right", "HLP_Gx00N0.htm");
            GxWebStd.gx_bitmap( context, edtavCfecha_alta_Internalname+"_dp_trigger", "", "calendar-img.gif", "", ((1==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, "", "", 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_Gx00N0.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocknombre_del_tipo_de_hd_Internalname, 1, 1, 0, "TIPO DE HW", "", "", "", 0, lblTextblocknombre_del_tipo_de_hd_Jsonclick, "", StyleString, ClassString, "HLP_Gx00N0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCnombre_del_tipo_de_hd_Internalname, StringUtil.RTrim( AV10cNOMBRE_DEL_TIPO_DE_HD), "", 20, "chr", 1, "row", 20, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV10cNOMBRE_DEL_TIPO_DE_HD, "XXXXXXXXXXXXXXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(34);\"", 0, edtavCnombre_del_tipo_de_hd_Jsonclick, "", 0, 1, -1, true, "left", "HLP_Gx00N0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockth_direc_Internalname, 1, 1, 0, "Tipo de Direccionamiento de un tipo de hardware", "", "", "", 0, lblTextblockth_direc_Jsonclick, "", StyleString, ClassString, "HLP_Gx00N0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavCth_direc, cmbavCth_direc_Internalname, StringUtil.Str( (decimal)(AV11cTH_DIREC), 2, 0), "", "int", 1, 1, 0, 1, 0, 2, "chr", 0, "", StyleString, ClassString, "", 0, cmbavCth_direc_Jsonclick, "", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(39);\"", true, "HLP_Gx00N0.htm");
            cmbavCth_direc.CurrentValue = StringUtil.Str( (decimal)(AV11cTH_DIREC), 2, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavCth_direc_Internalname, "Values", (String)(cmbavCth_direc.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockmodelo_de_componentes_id_Internalname, 1, 1, 0, "ID", "", "", "", 0, lblTextblockmodelo_de_componentes_id_Jsonclick, "", StyleString, ClassString, "HLP_Gx00N0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCmodelo_de_componentes_id_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12cMODELO_DE_COMPONENTES_ID), 4, 0, ",", "")), "", 4, "chr", 1, "row", 4, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(AV12cMODELO_DE_COMPONENTES_ID), "ZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(44);\"", 0, edtavCmodelo_de_componentes_id_Jsonclick, "", 0, 1, -1, true, "right", "HLP_Gx00N0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_9_4L2e( true) ;
         }
         else
         {
            wb_table2_9_4L2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV13pHARDWARE_ID = Convert.ToInt16(getParm(obj,0)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pHARDWARE_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pHARDWARE_ID), 4, 0)));
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
         PA4L2( ) ;
         WS4L2( ) ;
         WE4L2( ) ;
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
         AddThemeStyleSheetFile("", "Modern.css", "?19542497");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?11181042");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?42940");
         context.AddJavascriptSource("gx00n0.js", "?11181043");
         /* End function include_jscripts */
      }

      protected void sendrow_512( )
      {
         WB4L0( ) ;
         if ( ( 10 * 1 == 0 ) || ( nGXsfl_51_idx <= subGrid1_Recordsperpage( ) * 1 ) )
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
               if ( ((int)(nGXsfl_51_idx) % (2)) == 0 )
               {
                  subGrid1_Backcolor = (int)(0x0) ;
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
            /* Static Bitmap Variable */
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A10HARDWARE_ID), 4, 0, ",", "")))+"'"+"]);" ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Link", edtavLinkselection_Link);
            ClassString = "Image" ;
            StyleString = "" ;
            Grid1Row.AddColumnProperties("bitmap", 2, isAjaxCallMode( ), new Object[] {(String)edtavLinkselection_Internalname,(String)"",(String)AV5LinkSelection,(String)"Modern",(short)-1,(short)1,(String)"",(String)"Seleccionar",(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"",(short)0,(short)0,(String)edtavLinkselection_Link,(String)"",(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"''",(String)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtHARDWARE_ID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A10HARDWARE_ID), 4, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)4,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A10HARDWARE_ID), "ZZZ9"),(String)"",(short)0,(String)edtHARDWARE_ID_Jsonclick,(String)"",(short)51,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            edtTIPOS_DE_HARDWARE_ID_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A10HARDWARE_ID), 4, 0, ",", "")))+"'"+"]);" ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTIPOS_DE_HARDWARE_ID_Internalname, "Link", edtTIPOS_DE_HARDWARE_ID_Link);
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTIPOS_DE_HARDWARE_ID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A181TIPOS_DE_HARDWARE_ID), 4, 0, ",", "")),(String)"Seleccionar",(short)0,(String)"px",(short)17,(String)"",(short)4,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)edtTIPOS_DE_HARDWARE_ID_Link,(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A181TIPOS_DE_HARDWARE_ID), "ZZZ9"),(String)"",(short)0,(String)edtTIPOS_DE_HARDWARE_ID_Jsonclick,(String)"",(short)51,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtHARDWARE_DESCRIPCION_Internalname,StringUtil.RTrim( A58HARDWARE_DESCRIPCION),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)40,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A58HARDWARE_DESCRIPCION, "")),(String)"",(short)0,(String)edtHARDWARE_DESCRIPCION_Jsonclick,(String)"",(short)51,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtfecha_alta_Internalname,context.localUtil.Format(A182fecha_alta, "99/99/9999 99:99:99"),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)19,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( A182fecha_alta, "99/99/9999 99:99:99"),(String)"",(short)0,(String)edtfecha_alta_Jsonclick,(String)"",(short)51,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtNOMBRE_DEL_TIPO_DE_HD_Internalname,StringUtil.RTrim( A187NOMBRE_DEL_TIPO_DE_HD),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)20,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A187NOMBRE_DEL_TIPO_DE_HD, "XXXXXXXXXXXXXXXXXXXX")),(String)"",(short)0,(String)edtNOMBRE_DEL_TIPO_DE_HD_Jsonclick,(String)"",(short)51,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtMODELO_DE_COMPONENTES_ID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A183MODELO_DE_COMPONENTES_ID), 4, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)4,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A183MODELO_DE_COMPONENTES_ID), "ZZZ9"),(String)"",(short)0,(String)edtMODELO_DE_COMPONENTES_ID_Jsonclick,(String)"",(short)51,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtMODELO_DE_COMPONENTES_NOMBRE_Internalname,StringUtil.RTrim( A188MODELO_DE_COMPONENTES_NOMBRE),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)20,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A188MODELO_DE_COMPONENTES_NOMBRE, "XXXXXXXXXXXXXXXXXXXX")),(String)"",(short)0,(String)edtMODELO_DE_COMPONENTES_NOMBRE_Jsonclick,(String)"",(short)51,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtMARCAS_ID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A189MARCAS_ID), 4, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)4,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A189MARCAS_ID), "ZZZ9"),(String)"",(short)0,(String)edtMARCAS_ID_Jsonclick,(String)"",(short)51,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtHARDWARE_NRO_BIEN_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A184HARDWARE_NRO_BIEN), 10, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)10,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A184HARDWARE_NRO_BIEN), "ZZZZZZZZZ9"),(String)"",(short)0,(String)edtHARDWARE_NRO_BIEN_Jsonclick,(String)"",(short)51,(short)1,(short)1,(bool)true,(String)"right"});
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_51_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_51_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_51_idx+1)) ;
            sGXsfl_51_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_51_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
            edtHARDWARE_ID_Internalname = "HARDWARE_ID_"+sGXsfl_51_idx ;
            edtTIPOS_DE_HARDWARE_ID_Internalname = "TIPOS_DE_HARDWARE_ID_"+sGXsfl_51_idx ;
            edtHARDWARE_DESCRIPCION_Internalname = "HARDWARE_DESCRIPCION_"+sGXsfl_51_idx ;
            edtfecha_alta_Internalname = "FECHA_ALTA_"+sGXsfl_51_idx ;
            edtNOMBRE_DEL_TIPO_DE_HD_Internalname = "NOMBRE_DEL_TIPO_DE_HD_"+sGXsfl_51_idx ;
            edtMODELO_DE_COMPONENTES_ID_Internalname = "MODELO_DE_COMPONENTES_ID_"+sGXsfl_51_idx ;
            edtMODELO_DE_COMPONENTES_NOMBRE_Internalname = "MODELO_DE_COMPONENTES_NOMBRE_"+sGXsfl_51_idx ;
            edtMARCAS_ID_Internalname = "MARCAS_ID_"+sGXsfl_51_idx ;
            edtHARDWARE_NRO_BIEN_Internalname = "HARDWARE_NRO_BIEN_"+sGXsfl_51_idx ;
         }
         /* End function sendrow_512 */
      }

      protected void init_default_properties( )
      {
         lblTextblockhardware_id_Internalname = "TEXTBLOCKHARDWARE_ID" ;
         edtavChardware_id_Internalname = "vCHARDWARE_ID" ;
         lblTextblocktipos_de_hardware_id_Internalname = "TEXTBLOCKTIPOS_DE_HARDWARE_ID" ;
         edtavCtipos_de_hardware_id_Internalname = "vCTIPOS_DE_HARDWARE_ID" ;
         lblTextblockhardware_descripcion_Internalname = "TEXTBLOCKHARDWARE_DESCRIPCION" ;
         edtavChardware_descripcion_Internalname = "vCHARDWARE_DESCRIPCION" ;
         lblTextblockfecha_alta_Internalname = "TEXTBLOCKFECHA_ALTA" ;
         edtavCfecha_alta_Internalname = "vCFECHA_ALTA" ;
         lblTextblocknombre_del_tipo_de_hd_Internalname = "TEXTBLOCKNOMBRE_DEL_TIPO_DE_HD" ;
         edtavCnombre_del_tipo_de_hd_Internalname = "vCNOMBRE_DEL_TIPO_DE_HD" ;
         lblTextblockth_direc_Internalname = "TEXTBLOCKTH_DIREC" ;
         cmbavCth_direc_Internalname = "vCTH_DIREC" ;
         lblTextblockmodelo_de_componentes_id_Internalname = "TEXTBLOCKMODELO_DE_COMPONENTES_ID" ;
         edtavCmodelo_de_componentes_id_Internalname = "vCMODELO_DE_COMPONENTES_ID" ;
         tblTable2_Internalname = "TABLE2" ;
         grpGroup1_Internalname = "GROUP1" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         tblTable4_Internalname = "TABLE4" ;
         tblTable3_Internalname = "TABLE3" ;
         grpGroup2_Internalname = "GROUP2" ;
         tblTable1_Internalname = "TABLE1" ;
         Form.Internalname = "FORM" ;
         subGrid1_Internalname = "GRID1" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         edtHARDWARE_NRO_BIEN_Jsonclick = "" ;
         edtMARCAS_ID_Jsonclick = "" ;
         edtMODELO_DE_COMPONENTES_NOMBRE_Jsonclick = "" ;
         edtMODELO_DE_COMPONENTES_ID_Jsonclick = "" ;
         edtNOMBRE_DEL_TIPO_DE_HD_Jsonclick = "" ;
         edtfecha_alta_Jsonclick = "" ;
         edtHARDWARE_DESCRIPCION_Jsonclick = "" ;
         edtTIPOS_DE_HARDWARE_ID_Jsonclick = "" ;
         edtHARDWARE_ID_Jsonclick = "" ;
         edtavCmodelo_de_componentes_id_Jsonclick = "" ;
         cmbavCth_direc_Jsonclick = "" ;
         edtavCnombre_del_tipo_de_hd_Jsonclick = "" ;
         edtavCfecha_alta_Jsonclick = "" ;
         edtavChardware_descripcion_Jsonclick = "" ;
         edtavCtipos_de_hardware_id_Jsonclick = "" ;
         edtavChardware_id_Jsonclick = "" ;
         edtTIPOS_DE_HARDWARE_ID_Link = "" ;
         edtavLinkselection_Link = "" ;
         subGrid1_Class = "Grid" ;
         subGrid1_Backcolorstyle = 2 ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Selection List HARDWARE" ;
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
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         AV8cHARDWARE_DESCRIPCION = "" ;
         AV9cfecha_alta = (DateTime)(DateTime.MinValue) ;
         AV10cNOMBRE_DEL_TIPO_DE_HD = "" ;
         sDynURL = "" ;
         FormProcess = "" ;
         GX_FocusControl = "" ;
         Form = new GXWebForm();
         sPrefix = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         edtavLinkselection_Internalname = "" ;
         edtHARDWARE_ID_Internalname = "" ;
         edtTIPOS_DE_HARDWARE_ID_Internalname = "" ;
         edtHARDWARE_DESCRIPCION_Internalname = "" ;
         edtfecha_alta_Internalname = "" ;
         edtNOMBRE_DEL_TIPO_DE_HD_Internalname = "" ;
         edtMODELO_DE_COMPONENTES_ID_Internalname = "" ;
         edtMODELO_DE_COMPONENTES_NOMBRE_Internalname = "" ;
         edtMARCAS_ID_Internalname = "" ;
         edtHARDWARE_NRO_BIEN_Internalname = "" ;
         AV5LinkSelection = "" ;
         A58HARDWARE_DESCRIPCION = "" ;
         A182fecha_alta = (DateTime)(DateTime.MinValue) ;
         A187NOMBRE_DEL_TIPO_DE_HD = "" ;
         A188MODELO_DE_COMPONENTES_NOMBRE = "" ;
         Grid1Container = new GXWebGrid( context);
         scmdbuf = "" ;
         lV8cHARDWARE_DESCRIPCION = "" ;
         lV10cNOMBRE_DEL_TIPO_DE_HD = "" ;
         H004L2_A313TH_DIREC = new short[1] ;
         H004L2_A184HARDWARE_NRO_BIEN = new long[1] ;
         H004L2_A189MARCAS_ID = new short[1] ;
         H004L2_A188MODELO_DE_COMPONENTES_NOMBRE = new String[] {""} ;
         H004L2_A183MODELO_DE_COMPONENTES_ID = new short[1] ;
         H004L2_A187NOMBRE_DEL_TIPO_DE_HD = new String[] {""} ;
         H004L2_A182fecha_alta = new DateTime[] {DateTime.MinValue} ;
         H004L2_n182fecha_alta = new bool[] {false} ;
         H004L2_A58HARDWARE_DESCRIPCION = new String[] {""} ;
         H004L2_A181TIPOS_DE_HARDWARE_ID = new short[1] ;
         H004L2_A10HARDWARE_ID = new short[1] ;
         H004L3_AGRID1_nRecordCount = new int[1] ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         subGrid1_Linesclass = "" ;
         GXt_char3 = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GXt_char4 = "" ;
         GXt_char5 = "" ;
         GXt_char6 = "" ;
         GXt_char7 = "" ;
         GXt_char8 = "" ;
         Grid1Column = new GXWebColumn();
         TempTags = "" ;
         bttBtn_cancel_Jsonclick = "" ;
         lblTextblockhardware_id_Jsonclick = "" ;
         lblTextblocktipos_de_hardware_id_Jsonclick = "" ;
         lblTextblockhardware_descripcion_Jsonclick = "" ;
         lblTextblockfecha_alta_Jsonclick = "" ;
         GXt_char10 = "" ;
         GXt_char9 = "" ;
         lblTextblocknombre_del_tipo_de_hd_Jsonclick = "" ;
         lblTextblockth_direc_Jsonclick = "" ;
         lblTextblockmodelo_de_componentes_id_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         Grid1Row = new GXWebRow();
         ROClassString = "" ;
         GXt_char11 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx00n0__default(),
            new Object[][] {
                new Object[] {
               H004L2_A313TH_DIREC, H004L2_A184HARDWARE_NRO_BIEN, H004L2_A189MARCAS_ID, H004L2_A188MODELO_DE_COMPONENTES_NOMBRE, H004L2_A183MODELO_DE_COMPONENTES_ID, H004L2_A187NOMBRE_DEL_TIPO_DE_HD, H004L2_A182fecha_alta, H004L2_n182fecha_alta, H004L2_A58HARDWARE_DESCRIPCION, H004L2_A181TIPOS_DE_HARDWARE_ID,
               H004L2_A10HARDWARE_ID
               }
               , new Object[] {
               H004L3_AGRID1_nRecordCount
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_Grid1 ;
      private short nGXsfl_51_idx=1 ;
      private short AV11cTH_DIREC ;
      private short AV6cHARDWARE_ID ;
      private short AV7cTIPOS_DE_HARDWARE_ID ;
      private short AV12cMODELO_DE_COMPONENTES_ID ;
      private short AV13pHARDWARE_ID ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short GRID1_nEOF ;
      private short wbEnd ;
      private short wbStart ;
      private short A10HARDWARE_ID ;
      private short A181TIPOS_DE_HARDWARE_ID ;
      private short A183MODELO_DE_COMPONENTES_ID ;
      private short A189MARCAS_ID ;
      private short nDonePA ;
      private short subGrid1_Rows ;
      private short A313TH_DIREC ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short subGrid1_Collapsed ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int Grid1_PageSize51 ;
      private int GRID1_nFirstRecordOnPage ;
      private int subGrid1_Islastpage ;
      private int GRID1_nCurrentRecord ;
      private int GRID1_nRecordCount ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private long A184HARDWARE_NRO_BIEN ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_51_idx="0001" ;
      private String AV10cNOMBRE_DEL_TIPO_DE_HD ;
      private String sDynURL ;
      private String FormProcess ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavLinkselection_Internalname ;
      private String edtHARDWARE_ID_Internalname ;
      private String edtTIPOS_DE_HARDWARE_ID_Internalname ;
      private String edtHARDWARE_DESCRIPCION_Internalname ;
      private String edtfecha_alta_Internalname ;
      private String edtNOMBRE_DEL_TIPO_DE_HD_Internalname ;
      private String edtMODELO_DE_COMPONENTES_ID_Internalname ;
      private String edtMODELO_DE_COMPONENTES_NOMBRE_Internalname ;
      private String edtMARCAS_ID_Internalname ;
      private String edtHARDWARE_NRO_BIEN_Internalname ;
      private String A187NOMBRE_DEL_TIPO_DE_HD ;
      private String A188MODELO_DE_COMPONENTES_NOMBRE ;
      private String edtavChardware_id_Internalname ;
      private String scmdbuf ;
      private String lV10cNOMBRE_DEL_TIPO_DE_HD ;
      private String edtavCtipos_de_hardware_id_Internalname ;
      private String edtavChardware_descripcion_Internalname ;
      private String edtavCfecha_alta_Internalname ;
      private String edtavCnombre_del_tipo_de_hd_Internalname ;
      private String cmbavCth_direc_Internalname ;
      private String edtavCmodelo_de_componentes_id_Internalname ;
      private String sStyleString ;
      private String tblTable1_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String grpGroup1_Internalname ;
      private String grpGroup2_Internalname ;
      private String tblTable3_Internalname ;
      private String subGrid1_Internalname ;
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
      private String edtavLinkselection_Link ;
      private String edtTIPOS_DE_HARDWARE_ID_Link ;
      private String tblTable4_Internalname ;
      private String TempTags ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblockhardware_id_Internalname ;
      private String lblTextblockhardware_id_Jsonclick ;
      private String edtavChardware_id_Jsonclick ;
      private String lblTextblocktipos_de_hardware_id_Internalname ;
      private String lblTextblocktipos_de_hardware_id_Jsonclick ;
      private String edtavCtipos_de_hardware_id_Jsonclick ;
      private String lblTextblockhardware_descripcion_Internalname ;
      private String lblTextblockhardware_descripcion_Jsonclick ;
      private String edtavChardware_descripcion_Jsonclick ;
      private String lblTextblockfecha_alta_Internalname ;
      private String lblTextblockfecha_alta_Jsonclick ;
      private String GXt_char10 ;
      private String edtavCfecha_alta_Jsonclick ;
      private String GXt_char9 ;
      private String lblTextblocknombre_del_tipo_de_hd_Internalname ;
      private String lblTextblocknombre_del_tipo_de_hd_Jsonclick ;
      private String edtavCnombre_del_tipo_de_hd_Jsonclick ;
      private String lblTextblockth_direc_Internalname ;
      private String lblTextblockth_direc_Jsonclick ;
      private String cmbavCth_direc_Jsonclick ;
      private String lblTextblockmodelo_de_componentes_id_Internalname ;
      private String lblTextblockmodelo_de_componentes_id_Jsonclick ;
      private String edtavCmodelo_de_componentes_id_Jsonclick ;
      private String ROClassString ;
      private String edtHARDWARE_ID_Jsonclick ;
      private String edtTIPOS_DE_HARDWARE_ID_Jsonclick ;
      private String edtHARDWARE_DESCRIPCION_Jsonclick ;
      private String edtfecha_alta_Jsonclick ;
      private String edtNOMBRE_DEL_TIPO_DE_HD_Jsonclick ;
      private String edtMODELO_DE_COMPONENTES_ID_Jsonclick ;
      private String edtMODELO_DE_COMPONENTES_NOMBRE_Jsonclick ;
      private String edtMARCAS_ID_Jsonclick ;
      private String edtHARDWARE_NRO_BIEN_Jsonclick ;
      private String GXt_char11 ;
      private DateTime AV9cfecha_alta ;
      private DateTime A182fecha_alta ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n182fecha_alta ;
      private bool returnInSub ;
      private String AV8cHARDWARE_DESCRIPCION ;
      private String A58HARDWARE_DESCRIPCION ;
      private String lV8cHARDWARE_DESCRIPCION ;
      private String AV5LinkSelection ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbavCth_direc ;
      private IDataStoreProvider pr_default ;
      private short[] H004L2_A313TH_DIREC ;
      private long[] H004L2_A184HARDWARE_NRO_BIEN ;
      private short[] H004L2_A189MARCAS_ID ;
      private String[] H004L2_A188MODELO_DE_COMPONENTES_NOMBRE ;
      private short[] H004L2_A183MODELO_DE_COMPONENTES_ID ;
      private String[] H004L2_A187NOMBRE_DEL_TIPO_DE_HD ;
      private DateTime[] H004L2_A182fecha_alta ;
      private bool[] H004L2_n182fecha_alta ;
      private String[] H004L2_A58HARDWARE_DESCRIPCION ;
      private short[] H004L2_A181TIPOS_DE_HARDWARE_ID ;
      private short[] H004L2_A10HARDWARE_ID ;
      private int[] H004L3_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private short aP0_pHARDWARE_ID ;
      private GXWebForm Form ;
   }

   public class gx00n0__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH004L2 ;
          prmH004L2 = new Object[] {
          new Object[] {"@AV6cHARDWARE_ID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV7cTIPOS_DE_HARDWARE_ID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV8cHARDWARE_DESCRIPCION",SqlDbType.VarChar,40,0} ,
          new Object[] {"@AV9cfecha_alta",SqlDbType.DateTime,10,8} ,
          new Object[] {"@AV10cNOMBRE_DEL_TIPO_DE_HD",SqlDbType.Char,20,0} ,
          new Object[] {"@AV11cTH_DIREC",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@AV12cMODELO_DE_COMPONENTES_ID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmH004L3 ;
          prmH004L3 = new Object[] {
          new Object[] {"@AV6cHARDWARE_ID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV7cTIPOS_DE_HARDWARE_ID",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV8cHARDWARE_DESCRIPCION",SqlDbType.VarChar,40,0} ,
          new Object[] {"@AV9cfecha_alta",SqlDbType.DateTime,10,8} ,
          new Object[] {"@AV10cNOMBRE_DEL_TIPO_DE_HD",SqlDbType.Char,20,0} ,
          new Object[] {"@AV11cTH_DIREC",SqlDbType.SmallInt,2,0} ,
          new Object[] {"@AV12cMODELO_DE_COMPONENTES_ID",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H004L2", "SELECT [TH_DIREC], [HARDWARE_NRO_BIEN], [MARCAS_ID], [MODELO_DE_COMPONENTES_NOMBRE], [MODELO_DE_COMPONENTES_ID], [NOMBRE_DEL_TIPO_DE_HD], [fecha_alta], [HARDWARE_DESCRIPCION], [TIPOS_DE_HARDWARE_ID], [HARDWARE_ID] FROM [HARDWARE] WITH (NOLOCK) WHERE ([HARDWARE_ID] >= @AV6cHARDWARE_ID) AND ([TIPOS_DE_HARDWARE_ID] >= @AV7cTIPOS_DE_HARDWARE_ID) AND ([HARDWARE_DESCRIPCION] like @AV8cHARDWARE_DESCRIPCION) AND ([fecha_alta] >= @AV9cfecha_alta) AND ([NOMBRE_DEL_TIPO_DE_HD] like @AV10cNOMBRE_DEL_TIPO_DE_HD) AND ([TH_DIREC] >= @AV11cTH_DIREC) AND ([MODELO_DE_COMPONENTES_ID] >= @AV12cMODELO_DE_COMPONENTES_ID) ORDER BY [HARDWARE_ID]  OPTION (FAST 11)",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH004L2,11,0,false,false )
             ,new CursorDef("H004L3", "SELECT COUNT(*) FROM [HARDWARE] WITH (NOLOCK) WHERE ([HARDWARE_ID] >= @AV6cHARDWARE_ID) AND ([TIPOS_DE_HARDWARE_ID] >= @AV7cTIPOS_DE_HARDWARE_ID) AND ([HARDWARE_DESCRIPCION] like @AV8cHARDWARE_DESCRIPCION) AND ([fecha_alta] >= @AV9cfecha_alta) AND ([NOMBRE_DEL_TIPO_DE_HD] like @AV10cNOMBRE_DEL_TIPO_DE_HD) AND ([TH_DIREC] >= @AV11cTH_DIREC) AND ([MODELO_DE_COMPONENTES_ID] >= @AV12cMODELO_DE_COMPONENTES_ID) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH004L3,1,0,false,false )
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
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((long[]) buf[1])[0] = rslt.getLong(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 20) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((String[]) buf[5])[0] = rslt.getString(6, 20) ;
                ((DateTime[]) buf[6])[0] = rslt.getGXDateTime(7) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(7);
                ((String[]) buf[8])[0] = rslt.getVarchar(8) ;
                ((short[]) buf[9])[0] = rslt.getShort(9) ;
                ((short[]) buf[10])[0] = rslt.getShort(10) ;
                break;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
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
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (DateTime)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                break;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (DateTime)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                break;
       }
    }

 }

}
