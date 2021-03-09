module Parsers::Xml::Enrollment
  class ShopChangeRequest < ChangeRequest
    def initialize(xml)
      super(xml)
      @enrollment_group = @payload.at_xpath('./ins:shop_market_enrollment_group', @namespaces)
      @plan = @enrollment_group.at_xpath('./ins:plan', @namespaces)
    end

    def hios_plan_id
      @plan.at_xpath('./pln:plan/pln:hios_plan_id', @namespaces).text
    end

    def plan_year
      subscriber = Parsers::Xml::Enrollment::ShopEnrollee.new(@enrollment_group.xpath('./ins:subscriber', @namespaces), employer)
      begin
        subscriber.rate_period_date.start_date.year
      rescue
        subscriber.rate_period_date.year
      end
    end

    def premium_amount_total
      @plan.at_xpath('./ins:premium_amount_total', @namespaces).text.to_f
    end

    def enrollees
      enrollees = @enrollment_group.xpath('./ins:subscriber | ./ins:member', @namespaces)
      enrollees.collect { |e| Parsers::Xml::Enrollment::ShopEnrollee.new(e, self.employer) }
    end

    def employer
      fein = @enrollment_group.xpath('./emp:employer/emp:fein', @namespaces).text
      Employer.find_for_fein(fein)
    end

    def credit
      @plan.at_xpath('./ins:total_employer_responsibility_amount', @namespaces).text.to_f
    end

    def total_responsible_amount
      @plan.at_xpath('./ins:total_responsible_amount', @namespaces).text.to_f
    end
  end
end
