/*
               File: HHARDWARE_prompt
        Description: Búsqueda de bien de uso en Hardware
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/20/2014 13:19:22.30
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
using GeneXus.Office;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class hhardware_prompt : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public hhardware_prompt( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public hhardware_prompt( IGxContext context )
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
         this.AV37pHARDWARE_ID = 0 ;
         executePrivate();
         aP0_pHARDWARE_ID=this.AV37pHARDWARE_ID;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         dynavNombre_del_tipo_de_hd = new GXCombobox();
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"vNOMBRE_DEL_TIPO_DE_HD") == 0 )
            {
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               GXDLVvNOMBRE_DEL_TIPO_DE_HD0A2( ) ;
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
               nGXsfl_34_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               sGXsfl_34_idx = GetNextPar( ) ;
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxnrGrid1_newrow( nRC_Grid1, nGXsfl_34_idx, sGXsfl_34_idx) ;
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
               AV37pHARDWARE_ID = (short)(NumberUtil.Val( gxfirstwebparm, ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV37pHARDWARE_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV37pHARDWARE_ID), 4, 0)));
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
         PA0A2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START0A2( ) ;
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("hhardware_prompt.aspx") + "?" + UrlEncode("" +AV37pHARDWARE_ID)+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, "GXH_vHARDWARE_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV15HARDWARE_ID), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vHARDWARE_DESCRIPCION", StringUtil.RTrim( AV14HARDWARE_DESCRIPCION));
         GxWebStd.gx_hidden_field( context, "GXH_vNOMBRE_DEL_TIPO_DE_HD", StringUtil.RTrim( AV27NOMBRE_DEL_TIPO_DE_HD));
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_Grid1", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid1), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPHARDWARE_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV37pHARDWARE_ID), 4, 0, ",", "")));
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
            WE0A2( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT0A2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override String GetPgmname( )
      {
         return "HHARDWARE_prompt" ;
      }

      public override String GetPgmdesc( )
      {
         return "Búsqueda de bien de uso en Hardware" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("hhardware_prompt.aspx") + "?" + UrlEncode("" +AV37pHARDWARE_ID) ;
      }

      protected void WB0A0( )
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
            context.WriteHtmlText( "<p align=\"center\">") ;
            wb_table1_3_0A2( true) ;
         }
         else
         {
            wb_table1_3_0A2( false) ;
         }
         return  ;
      }

      protected void wb_table1_3_0A2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</p>") ;
         }
         wbLoad = true ;
      }

      protected void START0A2( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "Búsqueda de bien de uso en Hardware", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP0A0( ) ;
      }

      protected void WS0A2( )
      {
         START0A2( ) ;
         EVT0A2( ) ;
      }

      protected void EVT0A2( )
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
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vHARDWARE_ID"), ",", ".") != Convert.ToDecimal( AV15HARDWARE_ID )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vHARDWARE_DESCRIPCION"), AV14HARDWARE_DESCRIPCION) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vNOMBRE_DEL_TIPO_DE_HD"), AV27NOMBRE_DEL_TIPO_DE_HD) != 0 )
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
                           else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
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
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 4), "LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) )
                           {
                              nGXsfl_34_idx = (short)(NumberUtil.Val( sEvtType, ".")) ;
                              sGXsfl_34_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_34_idx), 4, 0)), 4, "0") ;
                              edtHARDWARE_ID_Internalname = "HARDWARE_ID_"+sGXsfl_34_idx ;
                              edtHARDWARE_DESCRIPCION_Internalname = "HARDWARE_DESCRIPCION_"+sGXsfl_34_idx ;
                              edtfecha_alta_Internalname = "FECHA_ALTA_"+sGXsfl_34_idx ;
                              edtTIPOS_DE_HARDWARE_ID_Internalname = "TIPOS_DE_HARDWARE_ID_"+sGXsfl_34_idx ;
                              edtNOMBRE_DEL_TIPO_DE_HD_Internalname = "NOMBRE_DEL_TIPO_DE_HD_"+sGXsfl_34_idx ;
                              edtMARCAS_ID_Internalname = "MARCAS_ID_"+sGXsfl_34_idx ;
                              edtMARCAS_DESCRIPCION_Internalname = "MARCAS_DESCRIPCION_"+sGXsfl_34_idx ;
                              edtMODELO_DE_COMPONENTES_ID_Internalname = "MODELO_DE_COMPONENTES_ID_"+sGXsfl_34_idx ;
                              edtMODELO_DE_COMPONENTES_NOMBRE_Internalname = "MODELO_DE_COMPONENTES_NOMBRE_"+sGXsfl_34_idx ;
                              edtHARDWARE_NRO_SERIE_Internalname = "HARDWARE_NRO_SERIE_"+sGXsfl_34_idx ;
                              A10HARDWARE_ID = (short)(context.localUtil.CToN( cgiGet( edtHARDWARE_ID_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10HARDWARE_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A10HARDWARE_ID), 4, 0)));
                              A58HARDWARE_DESCRIPCION = cgiGet( edtHARDWARE_DESCRIPCION_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A58HARDWARE_DESCRIPCION", A58HARDWARE_DESCRIPCION);
                              A182fecha_alta = context.localUtil.CToT( cgiGet( edtfecha_alta_Internalname)) ;
                              n182fecha_alta = false ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A182fecha_alta", context.localUtil.TToC( A182fecha_alta, 10, 8, 0, 3, "/", ":", " "));
                              A181TIPOS_DE_HARDWARE_ID = (short)(context.localUtil.CToN( cgiGet( edtTIPOS_DE_HARDWARE_ID_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A181TIPOS_DE_HARDWARE_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A181TIPOS_DE_HARDWARE_ID), 4, 0)));
                              A187NOMBRE_DEL_TIPO_DE_HD = cgiGet( edtNOMBRE_DEL_TIPO_DE_HD_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A187NOMBRE_DEL_TIPO_DE_HD", A187NOMBRE_DEL_TIPO_DE_HD);
                              A189MARCAS_ID = (short)(context.localUtil.CToN( cgiGet( edtMARCAS_ID_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A189MARCAS_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A189MARCAS_ID), 4, 0)));
                              A190MARCAS_DESCRIPCION = cgiGet( edtMARCAS_DESCRIPCION_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A190MARCAS_DESCRIPCION", A190MARCAS_DESCRIPCION);
                              A183MODELO_DE_COMPONENTES_ID = (short)(context.localUtil.CToN( cgiGet( edtMODELO_DE_COMPONENTES_ID_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A183MODELO_DE_COMPONENTES_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A183MODELO_DE_COMPONENTES_ID), 4, 0)));
                              A188MODELO_DE_COMPONENTES_NOMBRE = cgiGet( edtMODELO_DE_COMPONENTES_NOMBRE_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A188MODELO_DE_COMPONENTES_NOMBRE", A188MODELO_DE_COMPONENTES_NOMBRE);
                              A9HARDWARE_NRO_SERIE = cgiGet( edtHARDWARE_NRO_SERIE_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9HARDWARE_NRO_SERIE", A9HARDWARE_NRO_SERIE);
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false ;
                                       /* Set Refresh If Hardware_id Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vHARDWARE_ID"), ",", ".") != Convert.ToDecimal( AV15HARDWARE_ID )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Hardware_descripcion Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vHARDWARE_DESCRIPCION"), AV14HARDWARE_DESCRIPCION) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Nombre_del_tipo_de_hd Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vNOMBRE_DEL_TIPO_DE_HD"), AV27NOMBRE_DEL_TIPO_DE_HD) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: E110A2 */
                                          E110A2 ();
                                       }
                                       dynload_actions( ) ;
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E120A2 */
                                    E120A2 ();
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

      protected void WE0A2( )
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

      protected void PA0A2( )
      {
         if ( nDonePA == 0 )
         {
            dynavNombre_del_tipo_de_hd.Name = "vNOMBRE_DEL_TIPO_DE_HD" ;
            dynavNombre_del_tipo_de_hd.WebTags = "" ;
            GX_FocusControl = edtavHardware_id_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void GXDLVvNOMBRE_DEL_TIPO_DE_HD0A2( )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
         }
         context.GX_webresponse.AddString("(new Array( new Array(");
         GXDLVvNOMBRE_DEL_TIPO_DE_HD_data0A2( ) ;
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

      protected void GXVvNOMBRE_DEL_TIPO_DE_HD_html0A2( )
      {
         String gxdynajaxvalue ;
         GXDLVvNOMBRE_DEL_TIPO_DE_HD_data0A2( ) ;
         gxdynajaxindex = 1 ;
         dynavNombre_del_tipo_de_hd.removeAllItems();
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = gxdynajaxctrlcodr.Item(gxdynajaxindex) ;
            dynavNombre_del_tipo_de_hd.addItem(gxdynajaxvalue, gxdynajaxctrldescr.Item(gxdynajaxindex), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1) ;
         }
         if ( ! context.isAjaxRequest( ) )
         {
            if ( ( dynavNombre_del_tipo_de_hd.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( AV27NOMBRE_DEL_TIPO_DE_HD)) )
            {
               AV27NOMBRE_DEL_TIPO_DE_HD = dynavNombre_del_tipo_de_hd.getItemValue(1) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27NOMBRE_DEL_TIPO_DE_HD", AV27NOMBRE_DEL_TIPO_DE_HD);
            }
         }
      }

      protected void GXDLVvNOMBRE_DEL_TIPO_DE_HD_data0A2( )
      {
         /* Using cursor H000A2 */
         pr_default.execute(0);
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("Todos");
         while ( (pr_default.getStatus(0) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.RTrim( H000A2_A187NOMBRE_DEL_TIPO_DE_HD[0]));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( H000A2_A187NOMBRE_DEL_TIPO_DE_HD[0]));
            pr_default.readNext(0);
         }
         pr_default.close(0);
      }

      protected void gxnrGrid1_newrow( short nRC_Grid1 ,
                                       short nGXsfl_34_idx ,
                                       String sGXsfl_34_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         edtHARDWARE_ID_Internalname = "HARDWARE_ID_"+sGXsfl_34_idx ;
         edtHARDWARE_DESCRIPCION_Internalname = "HARDWARE_DESCRIPCION_"+sGXsfl_34_idx ;
         edtfecha_alta_Internalname = "FECHA_ALTA_"+sGXsfl_34_idx ;
         edtTIPOS_DE_HARDWARE_ID_Internalname = "TIPOS_DE_HARDWARE_ID_"+sGXsfl_34_idx ;
         edtNOMBRE_DEL_TIPO_DE_HD_Internalname = "NOMBRE_DEL_TIPO_DE_HD_"+sGXsfl_34_idx ;
         edtMARCAS_ID_Internalname = "MARCAS_ID_"+sGXsfl_34_idx ;
         edtMARCAS_DESCRIPCION_Internalname = "MARCAS_DESCRIPCION_"+sGXsfl_34_idx ;
         edtMODELO_DE_COMPONENTES_ID_Internalname = "MODELO_DE_COMPONENTES_ID_"+sGXsfl_34_idx ;
         edtMODELO_DE_COMPONENTES_NOMBRE_Internalname = "MODELO_DE_COMPONENTES_NOMBRE_"+sGXsfl_34_idx ;
         edtHARDWARE_NRO_SERIE_Internalname = "HARDWARE_NRO_SERIE_"+sGXsfl_34_idx ;
         while ( nGXsfl_34_idx <= nRC_Grid1 )
         {
            sendrow_342( ) ;
            nGXsfl_34_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_34_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_34_idx+1)) ;
            sGXsfl_34_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_34_idx), 4, 0)), 4, "0") ;
            edtHARDWARE_ID_Internalname = "HARDWARE_ID_"+sGXsfl_34_idx ;
            edtHARDWARE_DESCRIPCION_Internalname = "HARDWARE_DESCRIPCION_"+sGXsfl_34_idx ;
            edtfecha_alta_Internalname = "FECHA_ALTA_"+sGXsfl_34_idx ;
            edtTIPOS_DE_HARDWARE_ID_Internalname = "TIPOS_DE_HARDWARE_ID_"+sGXsfl_34_idx ;
            edtNOMBRE_DEL_TIPO_DE_HD_Internalname = "NOMBRE_DEL_TIPO_DE_HD_"+sGXsfl_34_idx ;
            edtMARCAS_ID_Internalname = "MARCAS_ID_"+sGXsfl_34_idx ;
            edtMARCAS_DESCRIPCION_Internalname = "MARCAS_DESCRIPCION_"+sGXsfl_34_idx ;
            edtMODELO_DE_COMPONENTES_ID_Internalname = "MODELO_DE_COMPONENTES_ID_"+sGXsfl_34_idx ;
            edtMODELO_DE_COMPONENTES_NOMBRE_Internalname = "MODELO_DE_COMPONENTES_NOMBRE_"+sGXsfl_34_idx ;
            edtHARDWARE_NRO_SERIE_Internalname = "HARDWARE_NRO_SERIE_"+sGXsfl_34_idx ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void Refresh( )
      {
         RF0A2( ) ;
         /* End function Refresh */
      }

      protected void RF0A2( )
      {
         Grid1Container.PageSize = subGrid1_Recordsperpage( ) ;
         wbStart = 34 ;
         nGXsfl_34_idx = 1 ;
         sGXsfl_34_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_34_idx), 4, 0)), 4, "0") ;
         edtHARDWARE_ID_Internalname = "HARDWARE_ID_"+sGXsfl_34_idx ;
         edtHARDWARE_DESCRIPCION_Internalname = "HARDWARE_DESCRIPCION_"+sGXsfl_34_idx ;
         edtfecha_alta_Internalname = "FECHA_ALTA_"+sGXsfl_34_idx ;
         edtTIPOS_DE_HARDWARE_ID_Internalname = "TIPOS_DE_HARDWARE_ID_"+sGXsfl_34_idx ;
         edtNOMBRE_DEL_TIPO_DE_HD_Internalname = "NOMBRE_DEL_TIPO_DE_HD_"+sGXsfl_34_idx ;
         edtMARCAS_ID_Internalname = "MARCAS_ID_"+sGXsfl_34_idx ;
         edtMARCAS_DESCRIPCION_Internalname = "MARCAS_DESCRIPCION_"+sGXsfl_34_idx ;
         edtMODELO_DE_COMPONENTES_ID_Internalname = "MODELO_DE_COMPONENTES_ID_"+sGXsfl_34_idx ;
         edtMODELO_DE_COMPONENTES_NOMBRE_Internalname = "MODELO_DE_COMPONENTES_NOMBRE_"+sGXsfl_34_idx ;
         edtHARDWARE_NRO_SERIE_Internalname = "HARDWARE_NRO_SERIE_"+sGXsfl_34_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtHARDWARE_ID_Internalname = "HARDWARE_ID_"+sGXsfl_34_idx ;
            edtHARDWARE_DESCRIPCION_Internalname = "HARDWARE_DESCRIPCION_"+sGXsfl_34_idx ;
            edtfecha_alta_Internalname = "FECHA_ALTA_"+sGXsfl_34_idx ;
            edtTIPOS_DE_HARDWARE_ID_Internalname = "TIPOS_DE_HARDWARE_ID_"+sGXsfl_34_idx ;
            edtNOMBRE_DEL_TIPO_DE_HD_Internalname = "NOMBRE_DEL_TIPO_DE_HD_"+sGXsfl_34_idx ;
            edtMARCAS_ID_Internalname = "MARCAS_ID_"+sGXsfl_34_idx ;
            edtMARCAS_DESCRIPCION_Internalname = "MARCAS_DESCRIPCION_"+sGXsfl_34_idx ;
            edtMODELO_DE_COMPONENTES_ID_Internalname = "MODELO_DE_COMPONENTES_ID_"+sGXsfl_34_idx ;
            edtMODELO_DE_COMPONENTES_NOMBRE_Internalname = "MODELO_DE_COMPONENTES_NOMBRE_"+sGXsfl_34_idx ;
            edtHARDWARE_NRO_SERIE_Internalname = "HARDWARE_NRO_SERIE_"+sGXsfl_34_idx ;
            pr_default.dynParam(1, new Object[]{ new Object[]{
                                                 AV15HARDWARE_ID ,
                                                 A10HARDWARE_ID ,
                                                 A58HARDWARE_DESCRIPCION ,
                                                 AV14HARDWARE_DESCRIPCION ,
                                                 A187NOMBRE_DEL_TIPO_DE_HD ,
                                                 AV27NOMBRE_DEL_TIPO_DE_HD ,
                                                 A104HDW_IDT },
                                                 new int[] {
                                                 TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.INT
                                                 }
            });
            lV14HARDWARE_DESCRIPCION = StringUtil.PadR( StringUtil.RTrim( AV14HARDWARE_DESCRIPCION), 40, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14HARDWARE_DESCRIPCION", AV14HARDWARE_DESCRIPCION);
            lV27NOMBRE_DEL_TIPO_DE_HD = StringUtil.PadR( StringUtil.RTrim( AV27NOMBRE_DEL_TIPO_DE_HD), 20, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27NOMBRE_DEL_TIPO_DE_HD", AV27NOMBRE_DEL_TIPO_DE_HD);
            /* Using cursor H000A3 */
            pr_default.execute(1, new Object[] {lV14HARDWARE_DESCRIPCION, lV27NOMBRE_DEL_TIPO_DE_HD, AV15HARDWARE_ID});
            nGXsfl_34_idx = 1 ;
            GRID1_nEOF = 0 ;
            while ( ( (pr_default.getStatus(1) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) ) )
            {
               A104HDW_IDT = H000A3_A104HDW_IDT[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A104HDW_IDT", StringUtil.LTrim( StringUtil.Str( (decimal)(A104HDW_IDT), 8, 0)));
               A9HARDWARE_NRO_SERIE = H000A3_A9HARDWARE_NRO_SERIE[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9HARDWARE_NRO_SERIE", A9HARDWARE_NRO_SERIE);
               A188MODELO_DE_COMPONENTES_NOMBRE = H000A3_A188MODELO_DE_COMPONENTES_NOMBRE[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A188MODELO_DE_COMPONENTES_NOMBRE", A188MODELO_DE_COMPONENTES_NOMBRE);
               A183MODELO_DE_COMPONENTES_ID = H000A3_A183MODELO_DE_COMPONENTES_ID[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A183MODELO_DE_COMPONENTES_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A183MODELO_DE_COMPONENTES_ID), 4, 0)));
               A190MARCAS_DESCRIPCION = H000A3_A190MARCAS_DESCRIPCION[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A190MARCAS_DESCRIPCION", A190MARCAS_DESCRIPCION);
               A189MARCAS_ID = H000A3_A189MARCAS_ID[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A189MARCAS_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A189MARCAS_ID), 4, 0)));
               A187NOMBRE_DEL_TIPO_DE_HD = H000A3_A187NOMBRE_DEL_TIPO_DE_HD[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A187NOMBRE_DEL_TIPO_DE_HD", A187NOMBRE_DEL_TIPO_DE_HD);
               A181TIPOS_DE_HARDWARE_ID = H000A3_A181TIPOS_DE_HARDWARE_ID[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A181TIPOS_DE_HARDWARE_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A181TIPOS_DE_HARDWARE_ID), 4, 0)));
               A182fecha_alta = H000A3_A182fecha_alta[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A182fecha_alta", context.localUtil.TToC( A182fecha_alta, 10, 8, 0, 3, "/", ":", " "));
               n182fecha_alta = H000A3_n182fecha_alta[0] ;
               A58HARDWARE_DESCRIPCION = H000A3_A58HARDWARE_DESCRIPCION[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A58HARDWARE_DESCRIPCION", A58HARDWARE_DESCRIPCION);
               A10HARDWARE_ID = H000A3_A10HARDWARE_ID[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10HARDWARE_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A10HARDWARE_ID), 4, 0)));
               /* Execute user event: E120A2 */
               E120A2 ();
               pr_default.readNext(1);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(1) == 101) ? 1 : 0)) ;
            pr_default.close(1);
            wbEnd = 34 ;
            WB0A0( ) ;
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
         pr_default.dynParam(2, new Object[]{ new Object[]{
                                              AV15HARDWARE_ID ,
                                              A10HARDWARE_ID ,
                                              A58HARDWARE_DESCRIPCION ,
                                              AV14HARDWARE_DESCRIPCION ,
                                              A187NOMBRE_DEL_TIPO_DE_HD ,
                                              AV27NOMBRE_DEL_TIPO_DE_HD ,
                                              A104HDW_IDT },
                                              new int[] {
                                              TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.INT
                                              }
         });
         lV14HARDWARE_DESCRIPCION = StringUtil.PadR( StringUtil.RTrim( AV14HARDWARE_DESCRIPCION), 40, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14HARDWARE_DESCRIPCION", AV14HARDWARE_DESCRIPCION);
         lV27NOMBRE_DEL_TIPO_DE_HD = StringUtil.PadR( StringUtil.RTrim( AV27NOMBRE_DEL_TIPO_DE_HD), 20, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27NOMBRE_DEL_TIPO_DE_HD", AV27NOMBRE_DEL_TIPO_DE_HD);
         /* Using cursor H000A4 */
         pr_default.execute(2, new Object[] {lV14HARDWARE_DESCRIPCION, lV27NOMBRE_DEL_TIPO_DE_HD, AV15HARDWARE_ID});
         GRID1_nRecordCount = H000A4_AGRID1_nRecordCount[0] ;
         pr_default.close(2);
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

      protected void STRUP0A0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         GXVvNOMBRE_DEL_TIPO_DE_HD_html0A2( ) ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( ! context.localUtil.VCNumber( cgiGet( edtavHardware_id_Internalname), "ZZZ9") || ( context.localUtil.CToN( cgiGet( edtavHardware_id_Internalname), ",", ".") < Convert.ToDecimal( 0 )) || ( ( context.localUtil.CToN( cgiGet( edtavHardware_id_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vHARDWARE_ID");
               GX_FocusControl = edtavHardware_id_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV15HARDWARE_ID = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15HARDWARE_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15HARDWARE_ID), 4, 0)));
            }
            else
            {
               AV15HARDWARE_ID = (short)(context.localUtil.CToN( cgiGet( edtavHardware_id_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15HARDWARE_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15HARDWARE_ID), 4, 0)));
            }
            AV14HARDWARE_DESCRIPCION = cgiGet( edtavHardware_descripcion_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14HARDWARE_DESCRIPCION", AV14HARDWARE_DESCRIPCION);
            dynavNombre_del_tipo_de_hd.Name = dynavNombre_del_tipo_de_hd_Internalname ;
            dynavNombre_del_tipo_de_hd.CurrentValue = cgiGet( dynavNombre_del_tipo_de_hd_Internalname) ;
            AV27NOMBRE_DEL_TIPO_DE_HD = cgiGet( dynavNombre_del_tipo_de_hd_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27NOMBRE_DEL_TIPO_DE_HD", AV27NOMBRE_DEL_TIPO_DE_HD);
            /* Read saved values. */
            nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ",", ".")) ;
            AV37pHARDWARE_ID = (short)(context.localUtil.CToN( cgiGet( "vPHARDWARE_ID"), ",", ".")) ;
            GRID1_nFirstRecordOnPage = (int)(context.localUtil.CToN( cgiGet( "GRID1_nFirstRecordOnPage"), ",", ".")) ;
            GRID1_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID1_nEOF"), ",", ".")) ;
            /* Read subfile selected row values. */
            nGXsfl_34_idx = (short)(context.localUtil.CToN( cgiGet( subGrid1_Internalname+"_ROW"), ",", ".")) ;
            sGXsfl_34_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_34_idx), 4, 0)), 4, "0") ;
            edtHARDWARE_ID_Internalname = "HARDWARE_ID_"+sGXsfl_34_idx ;
            edtHARDWARE_DESCRIPCION_Internalname = "HARDWARE_DESCRIPCION_"+sGXsfl_34_idx ;
            edtfecha_alta_Internalname = "FECHA_ALTA_"+sGXsfl_34_idx ;
            edtTIPOS_DE_HARDWARE_ID_Internalname = "TIPOS_DE_HARDWARE_ID_"+sGXsfl_34_idx ;
            edtNOMBRE_DEL_TIPO_DE_HD_Internalname = "NOMBRE_DEL_TIPO_DE_HD_"+sGXsfl_34_idx ;
            edtMARCAS_ID_Internalname = "MARCAS_ID_"+sGXsfl_34_idx ;
            edtMARCAS_DESCRIPCION_Internalname = "MARCAS_DESCRIPCION_"+sGXsfl_34_idx ;
            edtMODELO_DE_COMPONENTES_ID_Internalname = "MODELO_DE_COMPONENTES_ID_"+sGXsfl_34_idx ;
            edtMODELO_DE_COMPONENTES_NOMBRE_Internalname = "MODELO_DE_COMPONENTES_NOMBRE_"+sGXsfl_34_idx ;
            edtHARDWARE_NRO_SERIE_Internalname = "HARDWARE_NRO_SERIE_"+sGXsfl_34_idx ;
            if ( nGXsfl_34_idx > 0 )
            {
               A10HARDWARE_ID = (short)(context.localUtil.CToN( cgiGet( edtHARDWARE_ID_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A10HARDWARE_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A10HARDWARE_ID), 4, 0)));
               A58HARDWARE_DESCRIPCION = cgiGet( edtHARDWARE_DESCRIPCION_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A58HARDWARE_DESCRIPCION", A58HARDWARE_DESCRIPCION);
               A182fecha_alta = context.localUtil.CToT( cgiGet( edtfecha_alta_Internalname)) ;
               n182fecha_alta = false ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A182fecha_alta", context.localUtil.TToC( A182fecha_alta, 10, 8, 0, 3, "/", ":", " "));
               A181TIPOS_DE_HARDWARE_ID = (short)(context.localUtil.CToN( cgiGet( edtTIPOS_DE_HARDWARE_ID_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A181TIPOS_DE_HARDWARE_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A181TIPOS_DE_HARDWARE_ID), 4, 0)));
               A187NOMBRE_DEL_TIPO_DE_HD = cgiGet( edtNOMBRE_DEL_TIPO_DE_HD_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A187NOMBRE_DEL_TIPO_DE_HD", A187NOMBRE_DEL_TIPO_DE_HD);
               A189MARCAS_ID = (short)(context.localUtil.CToN( cgiGet( edtMARCAS_ID_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A189MARCAS_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A189MARCAS_ID), 4, 0)));
               A190MARCAS_DESCRIPCION = cgiGet( edtMARCAS_DESCRIPCION_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A190MARCAS_DESCRIPCION", A190MARCAS_DESCRIPCION);
               A183MODELO_DE_COMPONENTES_ID = (short)(context.localUtil.CToN( cgiGet( edtMODELO_DE_COMPONENTES_ID_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A183MODELO_DE_COMPONENTES_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A183MODELO_DE_COMPONENTES_ID), 4, 0)));
               A188MODELO_DE_COMPONENTES_NOMBRE = cgiGet( edtMODELO_DE_COMPONENTES_NOMBRE_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A188MODELO_DE_COMPONENTES_NOMBRE", A188MODELO_DE_COMPONENTES_NOMBRE);
               A9HARDWARE_NRO_SERIE = cgiGet( edtHARDWARE_NRO_SERIE_Internalname) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A9HARDWARE_NRO_SERIE", A9HARDWARE_NRO_SERIE);
            }
            /* Read hidden variables. */
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      public void GXEnter( )
      {
         /* Execute user event: E110A2 */
         E110A2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E110A2( )
      {
         /* Enter Routine */
         AV37pHARDWARE_ID = A10HARDWARE_ID ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV37pHARDWARE_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV37pHARDWARE_ID), 4, 0)));
         context.setWebReturnParms(new Object[] {(short)AV37pHARDWARE_ID});
         context.nUserReturn = 1 ;
         returnInSub = true;
         if (true) return;
      }

      private void E120A2( )
      {
         /* Load Routine */
         if ( ( subGrid1_Islastpage == 1 ) || ( 10 == 0 ) || ( ( GRID1_nCurrentRecord >= GRID1_nFirstRecordOnPage ) && ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) )
         {
            sendrow_342( ) ;
         }
         GRID1_nCurrentRecord = (int)(GRID1_nCurrentRecord+1) ;
      }

      protected void wb_table1_3_0A2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            sStyleString = sStyleString + " height: " + StringUtil.LTrim( StringUtil.Str( (decimal)(104), 10, 0)) + "px" + ";" ;
            sStyleString = sStyleString + " width: " + StringUtil.LTrim( StringUtil.Str( (decimal)(912), 10, 0)) + "px" + ";" ;
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
            wb_table2_9_0A2( true) ;
         }
         else
         {
            wb_table2_9_0A2( false) ;
         }
         return  ;
      }

      protected void wb_table2_9_0A2e( bool wbgen )
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
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "ID") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "HARDWARE") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "FECHA ALTA") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "ID") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" width="+StringUtil.LTrim( StringUtil.Str( (decimal)(180), 4, 0))+"px"+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "TIPO DE HW") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "ID") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "MARCA") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "ID") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" width="+StringUtil.LTrim( StringUtil.Str( (decimal)(180), 4, 0))+"px"+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "MODELO") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "NRO. SERIE") ;
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
               Grid1Container.AddObjectProperty("Linesfont", StringUtil.RTrim( subGrid1_Linesfont));
               Grid1Container.AddObjectProperty("CmpContext", "");
               Grid1Container.AddObjectProperty("InMasterPage", "false");
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A10HARDWARE_ID), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A58HARDWARE_DESCRIPCION));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", context.localUtil.Format(A182fecha_alta, "99/99/9999 99:99:99"));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A181TIPOS_DE_HARDWARE_ID), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A187NOMBRE_DEL_TIPO_DE_HD));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A189MARCAS_ID), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A190MARCAS_DESCRIPCION));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A183MODELO_DE_COMPONENTES_ID), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A188MODELO_DE_COMPONENTES_NOMBRE));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A9HARDWARE_NRO_SERIE));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Container.AddObjectProperty("Allowselection", "true");
               Grid1Container.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Selectioncolor), 9, 0, ".", "")));
               Grid1Container.AddObjectProperty("Allowhover", "true");
               Grid1Container.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Hoveringcolor), 9, 0, ".", "")));
               Grid1Container.AddObjectProperty("Allowcollapsing", "false");
               Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 9, 0, ".", "")));
            }
         }
         if ( wbEnd == 34 )
         {
            wbEnd = 0 ;
            nRC_Grid1 = (short)(nGXsfl_34_idx-1) ;
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
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_3_0A2e( true) ;
         }
         else
         {
            wb_table1_3_0A2e( false) ;
         }
      }

      protected void wb_table2_9_0A2( bool wbgen )
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
            StyleString = "font-family:'Microsoft Sans Serif'; font-size:8.0pt; font-weight:bold; font-style:normal" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock12_Internalname, 1, 1, 0, "ID:", "", "", "", 0, lblTextblock12_Jsonclick, "", StyleString, ClassString, "HLP_HHARDWARE_prompt.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'" + sGXsfl_34_idx + "',0)\"" ;
            ClassString = "" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavHardware_id_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV15HARDWARE_ID), 4, 0, ",", "")), "", 4, "chr", 1, "row", 4, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", context.localUtil.Format( (decimal)(AV15HARDWARE_ID), "ZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(14);\"", 0, edtavHardware_id_Jsonclick, "", 0, 0, -1, true, "right", "HLP_HHARDWARE_prompt.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft Sans Serif'; font-size:8.0pt; font-weight:bold; font-style:normal" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock9_Internalname, 1, 1, 0, "DESCRIPCION:", "", "", "", 0, lblTextblock9_Jsonclick, "", StyleString, ClassString, "HLP_HHARDWARE_prompt.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'" + sGXsfl_34_idx + "',0)\"" ;
            ClassString = "" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavHardware_descripcion_Internalname, StringUtil.RTrim( AV14HARDWARE_DESCRIPCION), "", 40, "chr", 1, "row", 40, 1, 1, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV14HARDWARE_DESCRIPCION, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(19);\"", 0, edtavHardware_descripcion_Jsonclick, "", 0, 0, -1, true, "left", "HLP_HHARDWARE_prompt.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft Sans Serif'; font-size:8.0pt; font-weight:bold; font-style:normal" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock6_Internalname, 1, 1, 0, "TIPO DE HARDWARE:", "", "", "", 0, lblTextblock6_Jsonclick, "", StyleString, ClassString, "HLP_HHARDWARE_prompt.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            ClassString = "" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 24,'',false,'" + sGXsfl_34_idx + "',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavNombre_del_tipo_de_hd, dynavNombre_del_tipo_de_hd_Internalname, AV27NOMBRE_DEL_TIPO_DE_HD, "", "char", 1, 1, 0, 1, 0, 20, "chr", 0, "", StyleString, ClassString, "", 0, dynavNombre_del_tipo_de_hd_Jsonclick, "", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(24);\"", true, "HLP_HHARDWARE_prompt.htm");
            dynavNombre_del_tipo_de_hd.CurrentValue = AV27NOMBRE_DEL_TIPO_DE_HD ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavNombre_del_tipo_de_hd_Internalname, "Values", (String)(dynavNombre_del_tipo_de_hd.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 30,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttButton7_Internalname, "Actualizar", "Actualizar", "", StyleString, ClassString, 1, 1, "rounded", 5, bttButton7_Jsonclick, "EREFRESH.", TempTags, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(34), 3, 0)+","+"null"+");", "", "HLP_HHARDWARE_prompt.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_9_0A2e( true) ;
         }
         else
         {
            wb_table2_9_0A2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV37pHARDWARE_ID = Convert.ToInt16(getParm(obj,0)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV37pHARDWARE_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV37pHARDWARE_ID), 4, 0)));
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
         PA0A2( ) ;
         WS0A2( ) ;
         WE0A2( ) ;
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
         AddThemeStyleSheetFile("", "Modern.css", "?15564175");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?13192291");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?42940");
         context.AddJavascriptSource("hhardware_prompt.js", "?13192292");
         /* End function include_jscripts */
      }

      protected void sendrow_342( )
      {
         WB0A0( ) ;
         if ( ( 10 * 1 == 0 ) || ( nGXsfl_34_idx <= subGrid1_Recordsperpage( ) * 1 ) )
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
               if ( ((int)(nGXsfl_34_idx) % (2)) == 0 )
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
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft Sans Serif'; font-size:8.0pt; font-weight:normal; font-style:normal" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtHARDWARE_ID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A10HARDWARE_ID), 4, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)4,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A10HARDWARE_ID), "ZZZ9"),(String)"",(short)5,(String)edtHARDWARE_ID_Jsonclick,"EENTER."+sGXsfl_34_idx,(short)34,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft Sans Serif'; font-size:8.0pt; font-weight:normal; font-style:normal" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtHARDWARE_DESCRIPCION_Internalname,StringUtil.RTrim( A58HARDWARE_DESCRIPCION),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)40,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A58HARDWARE_DESCRIPCION, "")),(String)"",(short)5,(String)edtHARDWARE_DESCRIPCION_Jsonclick,"EENTER."+sGXsfl_34_idx,(short)34,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft Sans Serif'; font-size:8.0pt; font-weight:normal; font-style:normal" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtfecha_alta_Internalname,context.localUtil.Format(A182fecha_alta, "99/99/9999 99:99:99"),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)19,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( A182fecha_alta, "99/99/9999 99:99:99"),(String)"",(short)0,(String)edtfecha_alta_Jsonclick,(String)"",(short)34,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft Sans Serif'; font-size:8.0pt; font-weight:normal; font-style:normal" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTIPOS_DE_HARDWARE_ID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A181TIPOS_DE_HARDWARE_ID), 4, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)4,(short)0,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A181TIPOS_DE_HARDWARE_ID), "ZZZ9"),(String)"",(short)0,(String)edtTIPOS_DE_HARDWARE_ID_Jsonclick,(String)"",(short)34,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft Sans Serif'; font-size:8.0pt; font-weight:normal; font-style:normal" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtNOMBRE_DEL_TIPO_DE_HD_Internalname,StringUtil.RTrim( A187NOMBRE_DEL_TIPO_DE_HD),(String)"",(short)180,(String)"px",(short)17,(String)"",(short)20,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A187NOMBRE_DEL_TIPO_DE_HD, "XXXXXXXXXXXXXXXXXXXX")),(String)"",(short)0,(String)edtNOMBRE_DEL_TIPO_DE_HD_Jsonclick,(String)"",(short)34,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft Sans Serif'; font-size:8.0pt; font-weight:normal; font-style:normal" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtMARCAS_ID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A189MARCAS_ID), 4, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)4,(short)0,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A189MARCAS_ID), "ZZZ9"),(String)"",(short)0,(String)edtMARCAS_ID_Jsonclick,(String)"",(short)34,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft Sans Serif'; font-size:8.0pt; font-weight:normal; font-style:normal" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtMARCAS_DESCRIPCION_Internalname,StringUtil.RTrim( A190MARCAS_DESCRIPCION),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)20,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A190MARCAS_DESCRIPCION, "XXXXXXXXXXXXXXXXXXXX")),(String)"",(short)0,(String)edtMARCAS_DESCRIPCION_Jsonclick,(String)"",(short)34,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft Sans Serif'; font-size:8.0pt; font-weight:normal; font-style:normal" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtMODELO_DE_COMPONENTES_ID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A183MODELO_DE_COMPONENTES_ID), 4, 0, ",", "")),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)4,(short)0,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,context.localUtil.Format( (decimal)(A183MODELO_DE_COMPONENTES_ID), "ZZZ9"),(String)"",(short)0,(String)edtMODELO_DE_COMPONENTES_ID_Jsonclick,(String)"",(short)34,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft Sans Serif'; font-size:8.0pt; font-weight:normal; font-style:normal" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtMODELO_DE_COMPONENTES_NOMBRE_Internalname,StringUtil.RTrim( A188MODELO_DE_COMPONENTES_NOMBRE),(String)"",(short)180,(String)"px",(short)17,(String)"",(short)20,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A188MODELO_DE_COMPONENTES_NOMBRE, "XXXXXXXXXXXXXXXXXXXX")),(String)"",(short)0,(String)edtMODELO_DE_COMPONENTES_NOMBRE_Jsonclick,(String)"",(short)34,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft Sans Serif'; font-size:8.0pt; font-weight:normal; font-style:normal" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtHARDWARE_NRO_SERIE_Internalname,StringUtil.RTrim( A9HARDWARE_NRO_SERIE),(String)"",(short)0,(String)"px",(short)17,(String)"",(short)20,(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)ROClassString,StringUtil.RTrim( context.localUtil.Format( A9HARDWARE_NRO_SERIE, "")),(String)"",(short)0,(String)edtHARDWARE_NRO_SERIE_Jsonclick,(String)"",(short)34,(short)1,(short)1,(bool)true,(String)"left"});
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_34_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_34_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_34_idx+1)) ;
            sGXsfl_34_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_34_idx), 4, 0)), 4, "0") ;
            edtHARDWARE_ID_Internalname = "HARDWARE_ID_"+sGXsfl_34_idx ;
            edtHARDWARE_DESCRIPCION_Internalname = "HARDWARE_DESCRIPCION_"+sGXsfl_34_idx ;
            edtfecha_alta_Internalname = "FECHA_ALTA_"+sGXsfl_34_idx ;
            edtTIPOS_DE_HARDWARE_ID_Internalname = "TIPOS_DE_HARDWARE_ID_"+sGXsfl_34_idx ;
            edtNOMBRE_DEL_TIPO_DE_HD_Internalname = "NOMBRE_DEL_TIPO_DE_HD_"+sGXsfl_34_idx ;
            edtMARCAS_ID_Internalname = "MARCAS_ID_"+sGXsfl_34_idx ;
            edtMARCAS_DESCRIPCION_Internalname = "MARCAS_DESCRIPCION_"+sGXsfl_34_idx ;
            edtMODELO_DE_COMPONENTES_ID_Internalname = "MODELO_DE_COMPONENTES_ID_"+sGXsfl_34_idx ;
            edtMODELO_DE_COMPONENTES_NOMBRE_Internalname = "MODELO_DE_COMPONENTES_NOMBRE_"+sGXsfl_34_idx ;
            edtHARDWARE_NRO_SERIE_Internalname = "HARDWARE_NRO_SERIE_"+sGXsfl_34_idx ;
         }
         /* End function sendrow_342 */
      }

      protected void init_default_properties( )
      {
         lblTextblock12_Internalname = "TEXTBLOCK12" ;
         edtavHardware_id_Internalname = "vHARDWARE_ID" ;
         lblTextblock9_Internalname = "TEXTBLOCK9" ;
         edtavHardware_descripcion_Internalname = "vHARDWARE_DESCRIPCION" ;
         lblTextblock6_Internalname = "TEXTBLOCK6" ;
         dynavNombre_del_tipo_de_hd_Internalname = "vNOMBRE_DEL_TIPO_DE_HD" ;
         bttButton7_Internalname = "BUTTON7" ;
         tblTable2_Internalname = "TABLE2" ;
         tblTable1_Internalname = "TABLE1" ;
         Form.Internalname = "FORM" ;
         subGrid1_Internalname = "GRID1" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         edtHARDWARE_NRO_SERIE_Jsonclick = "" ;
         edtMODELO_DE_COMPONENTES_NOMBRE_Jsonclick = "" ;
         edtMODELO_DE_COMPONENTES_ID_Jsonclick = "" ;
         edtMARCAS_DESCRIPCION_Jsonclick = "" ;
         edtMARCAS_ID_Jsonclick = "" ;
         edtNOMBRE_DEL_TIPO_DE_HD_Jsonclick = "" ;
         edtTIPOS_DE_HARDWARE_ID_Jsonclick = "" ;
         edtfecha_alta_Jsonclick = "" ;
         edtHARDWARE_DESCRIPCION_Jsonclick = "" ;
         edtHARDWARE_ID_Jsonclick = "" ;
         dynavNombre_del_tipo_de_hd_Jsonclick = "" ;
         edtavHardware_descripcion_Jsonclick = "" ;
         edtavHardware_id_Jsonclick = "" ;
         subGrid1_Hoveringcolor = (int)(0x00C0C0) ;
         subGrid1_Selectioncolor = (int)(0x80FFFF) ;
         subGrid1_Linesfont = "font-family:Microsoft Sans Serif;font-size:8pt;" ;
         subGrid1_Class = "Grid" ;
         subGrid1_Backcolorstyle = 3 ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Búsqueda de bien de uso en Hardware" ;
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
         sDynURL = "" ;
         FormProcess = "" ;
         AV14HARDWARE_DESCRIPCION = "" ;
         AV27NOMBRE_DEL_TIPO_DE_HD = "" ;
         GX_FocusControl = "" ;
         Form = new GXWebForm();
         sPrefix = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         edtHARDWARE_ID_Internalname = "" ;
         edtHARDWARE_DESCRIPCION_Internalname = "" ;
         edtfecha_alta_Internalname = "" ;
         edtTIPOS_DE_HARDWARE_ID_Internalname = "" ;
         edtNOMBRE_DEL_TIPO_DE_HD_Internalname = "" ;
         edtMARCAS_ID_Internalname = "" ;
         edtMARCAS_DESCRIPCION_Internalname = "" ;
         edtMODELO_DE_COMPONENTES_ID_Internalname = "" ;
         edtMODELO_DE_COMPONENTES_NOMBRE_Internalname = "" ;
         edtHARDWARE_NRO_SERIE_Internalname = "" ;
         A58HARDWARE_DESCRIPCION = "" ;
         A182fecha_alta = (DateTime)(DateTime.MinValue) ;
         A187NOMBRE_DEL_TIPO_DE_HD = "" ;
         A190MARCAS_DESCRIPCION = "" ;
         A188MODELO_DE_COMPONENTES_NOMBRE = "" ;
         A9HARDWARE_NRO_SERIE = "" ;
         gxdynajaxctrlcodr = new GeneXus.Utils.GxStringCollection();
         gxdynajaxctrldescr = new GeneXus.Utils.GxStringCollection();
         gxwrpcisep = "" ;
         scmdbuf = "" ;
         H000A2_A10HARDWARE_ID = new short[1] ;
         H000A2_A187NOMBRE_DEL_TIPO_DE_HD = new String[] {""} ;
         Grid1Container = new GXWebGrid( context);
         lV14HARDWARE_DESCRIPCION = "" ;
         lV27NOMBRE_DEL_TIPO_DE_HD = "" ;
         H000A3_A104HDW_IDT = new int[1] ;
         H000A3_A9HARDWARE_NRO_SERIE = new String[] {""} ;
         H000A3_A188MODELO_DE_COMPONENTES_NOMBRE = new String[] {""} ;
         H000A3_A183MODELO_DE_COMPONENTES_ID = new short[1] ;
         H000A3_A190MARCAS_DESCRIPCION = new String[] {""} ;
         H000A3_A189MARCAS_ID = new short[1] ;
         H000A3_A187NOMBRE_DEL_TIPO_DE_HD = new String[] {""} ;
         H000A3_A181TIPOS_DE_HARDWARE_ID = new short[1] ;
         H000A3_A182fecha_alta = new DateTime[] {DateTime.MinValue} ;
         H000A3_n182fecha_alta = new bool[] {false} ;
         H000A3_A58HARDWARE_DESCRIPCION = new String[] {""} ;
         H000A3_A10HARDWARE_ID = new short[1] ;
         H000A4_AGRID1_nRecordCount = new int[1] ;
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
         GXt_char9 = "" ;
         Grid1Column = new GXWebColumn();
         GXt_char10 = "" ;
         lblTextblock12_Jsonclick = "" ;
         TempTags = "" ;
         lblTextblock9_Jsonclick = "" ;
         lblTextblock6_Jsonclick = "" ;
         bttButton7_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         Grid1Row = new GXWebRow();
         ROClassString = "" ;
         GXt_char11 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.hhardware_prompt__default(),
            new Object[][] {
                new Object[] {
               H000A2_A10HARDWARE_ID, H000A2_A187NOMBRE_DEL_TIPO_DE_HD
               }
               , new Object[] {
               H000A3_A104HDW_IDT, H000A3_A9HARDWARE_NRO_SERIE, H000A3_A188MODELO_DE_COMPONENTES_NOMBRE, H000A3_A183MODELO_DE_COMPONENTES_ID, H000A3_A190MARCAS_DESCRIPCION, H000A3_A189MARCAS_ID, H000A3_A187NOMBRE_DEL_TIPO_DE_HD, H000A3_A181TIPOS_DE_HARDWARE_ID, H000A3_A182fecha_alta, H000A3_n182fecha_alta,
               H000A3_A58HARDWARE_DESCRIPCION, H000A3_A10HARDWARE_ID
               }
               , new Object[] {
               H000A4_AGRID1_nRecordCount
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_Grid1 ;
      private short nGXsfl_34_idx=1 ;
      private short AV37pHARDWARE_ID ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short AV15HARDWARE_ID ;
      private short GRID1_nEOF ;
      private short wbEnd ;
      private short wbStart ;
      private short A10HARDWARE_ID ;
      private short A181TIPOS_DE_HARDWARE_ID ;
      private short A189MARCAS_ID ;
      private short A183MODELO_DE_COMPONENTES_ID ;
      private short nDonePA ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short subGrid1_Collapsed ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int GRID1_nFirstRecordOnPage ;
      private int gxdynajaxindex ;
      private int subGrid1_Islastpage ;
      private int A104HDW_IDT ;
      private int GRID1_nCurrentRecord ;
      private int GRID1_nRecordCount ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int subGrid1_Selectioncolor ;
      private int subGrid1_Hoveringcolor ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_34_idx="0001" ;
      private String sDynURL ;
      private String FormProcess ;
      private String AV27NOMBRE_DEL_TIPO_DE_HD ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtHARDWARE_ID_Internalname ;
      private String edtHARDWARE_DESCRIPCION_Internalname ;
      private String edtfecha_alta_Internalname ;
      private String edtTIPOS_DE_HARDWARE_ID_Internalname ;
      private String edtNOMBRE_DEL_TIPO_DE_HD_Internalname ;
      private String edtMARCAS_ID_Internalname ;
      private String edtMARCAS_DESCRIPCION_Internalname ;
      private String edtMODELO_DE_COMPONENTES_ID_Internalname ;
      private String edtMODELO_DE_COMPONENTES_NOMBRE_Internalname ;
      private String edtHARDWARE_NRO_SERIE_Internalname ;
      private String A187NOMBRE_DEL_TIPO_DE_HD ;
      private String A190MARCAS_DESCRIPCION ;
      private String A188MODELO_DE_COMPONENTES_NOMBRE ;
      private String edtavHardware_id_Internalname ;
      private String gxwrpcisep ;
      private String scmdbuf ;
      private String lV27NOMBRE_DEL_TIPO_DE_HD ;
      private String edtavHardware_descripcion_Internalname ;
      private String dynavNombre_del_tipo_de_hd_Internalname ;
      private String subGrid1_Internalname ;
      private String sStyleString ;
      private String tblTable1_Internalname ;
      private String ClassString ;
      private String StyleString ;
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
      private String subGrid1_Linesfont ;
      private String GXt_char10 ;
      private String tblTable2_Internalname ;
      private String lblTextblock12_Internalname ;
      private String lblTextblock12_Jsonclick ;
      private String TempTags ;
      private String edtavHardware_id_Jsonclick ;
      private String lblTextblock9_Internalname ;
      private String lblTextblock9_Jsonclick ;
      private String edtavHardware_descripcion_Jsonclick ;
      private String lblTextblock6_Internalname ;
      private String lblTextblock6_Jsonclick ;
      private String dynavNombre_del_tipo_de_hd_Jsonclick ;
      private String bttButton7_Internalname ;
      private String bttButton7_Jsonclick ;
      private String ROClassString ;
      private String edtHARDWARE_ID_Jsonclick ;
      private String edtHARDWARE_DESCRIPCION_Jsonclick ;
      private String edtfecha_alta_Jsonclick ;
      private String edtTIPOS_DE_HARDWARE_ID_Jsonclick ;
      private String edtNOMBRE_DEL_TIPO_DE_HD_Jsonclick ;
      private String edtMARCAS_ID_Jsonclick ;
      private String edtMARCAS_DESCRIPCION_Jsonclick ;
      private String edtMODELO_DE_COMPONENTES_ID_Jsonclick ;
      private String edtMODELO_DE_COMPONENTES_NOMBRE_Jsonclick ;
      private String edtHARDWARE_NRO_SERIE_Jsonclick ;
      private String GXt_char11 ;
      private DateTime A182fecha_alta ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n182fecha_alta ;
      private bool returnInSub ;
      private String AV14HARDWARE_DESCRIPCION ;
      private String A58HARDWARE_DESCRIPCION ;
      private String A9HARDWARE_NRO_SERIE ;
      private String lV14HARDWARE_DESCRIPCION ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private GXCombobox dynavNombre_del_tipo_de_hd ;
      private IDataStoreProvider pr_default ;
      private short[] H000A2_A10HARDWARE_ID ;
      private String[] H000A2_A187NOMBRE_DEL_TIPO_DE_HD ;
      private int[] H000A3_A104HDW_IDT ;
      private String[] H000A3_A9HARDWARE_NRO_SERIE ;
      private String[] H000A3_A188MODELO_DE_COMPONENTES_NOMBRE ;
      private short[] H000A3_A183MODELO_DE_COMPONENTES_ID ;
      private String[] H000A3_A190MARCAS_DESCRIPCION ;
      private short[] H000A3_A189MARCAS_ID ;
      private String[] H000A3_A187NOMBRE_DEL_TIPO_DE_HD ;
      private short[] H000A3_A181TIPOS_DE_HARDWARE_ID ;
      private DateTime[] H000A3_A182fecha_alta ;
      private bool[] H000A3_n182fecha_alta ;
      private String[] H000A3_A58HARDWARE_DESCRIPCION ;
      private short[] H000A3_A10HARDWARE_ID ;
      private int[] H000A4_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private short aP0_pHARDWARE_ID ;
      private GXWebForm Form ;
   }

   public class hhardware_prompt__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H000A3( short AV15HARDWARE_ID ,
                                             short A10HARDWARE_ID ,
                                             String A58HARDWARE_DESCRIPCION ,
                                             String AV14HARDWARE_DESCRIPCION ,
                                             String A187NOMBRE_DEL_TIPO_DE_HD ,
                                             String AV27NOMBRE_DEL_TIPO_DE_HD ,
                                             int A104HDW_IDT )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int12 ;
         GXv_int12 = new short [3] ;
         Object[] GXv_Object13 ;
         GXv_Object13 = new Object [2] ;
         scmdbuf = "SELECT [HDW_IDT], [HARDWARE_NRO_SERIE], [MODELO_DE_COMPONENTES_NOMBRE], [MODELO_DE_COMPONENTES_ID], [MARCAS_DESCRIPCION], [MARCAS_ID], [NOMBRE_DEL_TIPO_DE_HD], [TIPOS_DE_HARDWARE_ID], [fecha_alta], [HARDWARE_DESCRIPCION], [HARDWARE_ID] FROM [HARDWARE] WITH (NOLOCK)" ;
         scmdbuf = scmdbuf + " WHERE (UPPER([HARDWARE_DESCRIPCION]) like UPPER(@AV14HARDWARE_DESCRIPCION))" ;
         scmdbuf = scmdbuf + " and (UPPER([NOMBRE_DEL_TIPO_DE_HD]) like UPPER(@AV27NOMBRE_DEL_TIPO_DE_HD))" ;
         scmdbuf = scmdbuf + " and ([HDW_IDT] = 0 or ([HDW_IDT] = convert(int, 0)))" ;
         if ( ! (0==AV15HARDWARE_ID) )
         {
            sWhereString = sWhereString + " and ([HARDWARE_ID] = @AV15HARDWARE_ID)" ;
         }
         else
         {
            GXv_int12[2] = 1 ;
         }
         scmdbuf = scmdbuf + sWhereString ;
         scmdbuf = scmdbuf + " ORDER BY [HARDWARE_ID]" ;
         scmdbuf = scmdbuf + " OPTION (FAST 11)" ;
         GXv_Object13[0] = scmdbuf ;
         GXv_Object13[1] = (Object)(GXv_int12) ;
         return GXv_Object13 ;
      }

      protected Object[] conditional_H000A4( short AV15HARDWARE_ID ,
                                             short A10HARDWARE_ID ,
                                             String A58HARDWARE_DESCRIPCION ,
                                             String AV14HARDWARE_DESCRIPCION ,
                                             String A187NOMBRE_DEL_TIPO_DE_HD ,
                                             String AV27NOMBRE_DEL_TIPO_DE_HD ,
                                             int A104HDW_IDT )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int14 ;
         GXv_int14 = new short [3] ;
         Object[] GXv_Object15 ;
         GXv_Object15 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [HARDWARE] WITH (NOLOCK)" ;
         scmdbuf = scmdbuf + " WHERE (UPPER([HARDWARE_DESCRIPCION]) like UPPER(@AV14HARDWARE_DESCRIPCION))" ;
         scmdbuf = scmdbuf + " and (UPPER([NOMBRE_DEL_TIPO_DE_HD]) like UPPER(@AV27NOMBRE_DEL_TIPO_DE_HD))" ;
         scmdbuf = scmdbuf + " and ([HDW_IDT] = 0 or ([HDW_IDT] = convert(int, 0)))" ;
         if ( ! (0==AV15HARDWARE_ID) )
         {
            sWhereString = sWhereString + " and ([HARDWARE_ID] = @AV15HARDWARE_ID)" ;
         }
         else
         {
            GXv_int14[2] = 1 ;
         }
         scmdbuf = scmdbuf + sWhereString ;
         scmdbuf = scmdbuf + "" ;
         GXv_Object15[0] = scmdbuf ;
         GXv_Object15[1] = (Object)(GXv_int14) ;
         return GXv_Object15 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 1 :
                     return conditional_H000A3( (short)dynConstraints[0] , (short)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (int)dynConstraints[6] );
               case 2 :
                     return conditional_H000A4( (short)dynConstraints[0] , (short)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (int)dynConstraints[6] );
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
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH000A2 ;
          prmH000A2 = new Object[] {
          } ;
          Object[] prmH000A3 ;
          prmH000A3 = new Object[] {
          new Object[] {"@AV14HARDWARE_DESCRIPCION",SqlDbType.VarChar,40,0} ,
          new Object[] {"@AV27NOMBRE_DEL_TIPO_DE_HD",SqlDbType.Char,20,0} ,
          new Object[] {"@AV15HARDWARE_ID",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmH000A4 ;
          prmH000A4 = new Object[] {
          new Object[] {"@AV14HARDWARE_DESCRIPCION",SqlDbType.VarChar,40,0} ,
          new Object[] {"@AV27NOMBRE_DEL_TIPO_DE_HD",SqlDbType.Char,20,0} ,
          new Object[] {"@AV15HARDWARE_ID",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H000A2", "SELECT [HARDWARE_ID], [NOMBRE_DEL_TIPO_DE_HD] FROM [HARDWARE] WITH (NOLOCK) ORDER BY [NOMBRE_DEL_TIPO_DE_HD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000A2,0,0,true,false )
             ,new CursorDef("H000A3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000A3,11,0,true,false )
             ,new CursorDef("H000A4", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000A4,1,0,true,false )
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
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                break;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 20) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 20) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((String[]) buf[6])[0] = rslt.getString(7, 20) ;
                ((short[]) buf[7])[0] = rslt.getShort(8) ;
                ((DateTime[]) buf[8])[0] = rslt.getGXDateTime(9) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(9);
                ((String[]) buf[10])[0] = rslt.getVarchar(10) ;
                ((short[]) buf[11])[0] = rslt.getShort(11) ;
                break;
             case 2 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
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
             case 1 :
                sIdx = 0 ;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1) ;
                   stmt.SetParameter(sIdx, (String)parms[3]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1) ;
                   stmt.SetParameter(sIdx, (String)parms[4]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1) ;
                   stmt.SetParameter(sIdx, (short)parms[5]);
                }
                break;
             case 2 :
                sIdx = 0 ;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1) ;
                   stmt.SetParameter(sIdx, (String)parms[3]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1) ;
                   stmt.SetParameter(sIdx, (String)parms[4]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1) ;
                   stmt.SetParameter(sIdx, (short)parms[5]);
                }
                break;
       }
    }

 }

}
