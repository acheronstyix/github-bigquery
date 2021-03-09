/*
 * Copyright 2013 <a href="mailto:lincolnbaxter@gmail.com">Lincoln Baxter, III</a>
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
package org.ocpsoft.rewrite.config;

import org.ocpsoft.rewrite.param.Parameter;

/**
 * An intermediate stage {@link Rule} configuration.
 * 
 * @author <a href="mailto:lincolnbaxter@gmail.com">Lincoln Baxter, III</a>
 */
public interface ConfigurationRuleBuilderPerform extends ConfigurationBuilderRoot, ConfigurationRuleBuilderWithMetadata
{

   /**
    * Perform the given {@link Operation} when the conditions set in this {@link Rule} fail to be met.
    */
   ConfigurationRuleBuilderOtherwise otherwise(Operation condition);

   /**
    * Perform the given {@link Operation} instances when the conditions set in this {@link Rule} fail to be met.
    */
   ConfigurationRuleBuilderOtherwise otherwise(Operation operation, Operation ... operations);

   /**
    * Set the ID for the current {@link Rule}. This may be used in logging and for rule lookup purposes.
    */
   ConfigurationRuleBuilderWithId withId(String id);

   /**
    * Set the priority of this {@link Rule} instance. If {@link #priority()} differs from the priority of the
    * {@link ConfigurationProvider} from which this rule was returned, then relocate this rule to its new priority
    * position in the compiled rule set.
    */
   ConfigurationRuleBuilderWithPriority withPriority(int priority);

   /**
    * Configure the {@link Parameter} with the given name.
    */
   ConfigurationRuleParameterWhere where(String param);
}
